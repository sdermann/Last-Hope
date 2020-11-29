using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastHope
{
    public partial class RiskForm : Form
    {
        //SQL
        const string ConnectionString = @"server=127.0.0.1; userid=Sdermann;password = 896520;database=mydb";
        MySqlConnection connection = new MySqlConnection(ConnectionString);
        MySqlCommand command;
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        //SQL-end
        public RiskForm()
        {
            InitializeComponent();
        }

        private void TextSearchBox_TextChanged(object sender, EventArgs e)
        {
            string nameD = TextSearchBox.Text;
            string q1 = "SELECT COUNT(*)  AS Частота, (Select Назва_хвороби From хвороби Where Id_Хвороби = Id_Хвороби2) AS Назва FROM поставлені_діагнози WHERE Id_Хвороби2 In (Select Id_Хвороби From хвороби Where Назва_хвороби LIKE  '%" + nameD + "%') GROUP BY Id_Хвороби2;";
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(q1, connection);
            adapter2.Fill(table2);
            dataGridView2.DataSource = table2;
        }

        private void RiskForm_Load(object sender, EventArgs e)
        {
            string q1 = "SELECT  COUNT(*)  AS Частота , (Select Назва_хвороби From хвороби Where Id_Хвороби = Id_Хвороби2) AS Назва FROM поставлені_діагнози GROUP BY Id_Хвороби2;";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
            if(dataGridView2.Rows.Count > 0)
            {
                UpLabel.Text = "";
                DownLabel.Text = "";
                int temp;
                var MaxAm = dataGridView2.Rows.Cast<DataGridViewRow>()
                            .Max(r => int.TryParse(r.Cells[0].Value.ToString(), out temp) ?
                                       temp : 0);
                var MinAm  = dataGridView2.Rows.Cast<DataGridViewRow>()
                            .Min(r => int.TryParse(r.Cells[0].Value.ToString(), out temp) ?
                                       temp : 0);
                foreach(DataGridViewRow row in dataGridView2.Rows)
                {
                    if(Int32.Parse(row.Cells[0].Value.ToString()) == MaxAm)
                    {
                        UpLabel.Text += "\n" + row.Cells[1].Value.ToString();
                    }
                    else if(Int32.Parse(row.Cells[0].Value.ToString()) == MinAm)
                    {
                        DownLabel.Text += "\n" + row.Cells[1].Value.ToString();
                    }
                }

            }
            
        }

       
    }
}
