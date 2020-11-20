using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LastHope
{
    public partial class SQLForm : Form
    {
        const string ConnectionString = @"server=127.0.0.1; userid=Sdermann;password = 896520;database=mydb";
    
        //Sdermann@127.0.0.1:3306

        // @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Temp\Hostel\Hostel\Hostel.mdf;Integrated Security=True";

        public SQLForm()
        {
            InitializeComponent();
        }

        private void DoSQLButt_Click(object sender, EventArgs e)
        {
            try
            {
   
                MySqlConnection sqlconn = new MySqlConnection(ConnectionString);
                sqlconn.Open();
                MySqlDataAdapter oda = new MySqlDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Rows[0].Selected = true;
                this.dataGridView1.Columns[dataGridView1.Columns.Count-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void ClearSQLButt_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "";
        }
    }
}
