using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LastHope
{
    public partial class SQLForm : Form
    {
        const string ConnectionString = @"server=127.0.0.1; userid=Sdermann;password = 896520;database=mydb";
    
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

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                
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
