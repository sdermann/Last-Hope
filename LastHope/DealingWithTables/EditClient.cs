using LastHope.mydbDataSetTableAdapters;
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

namespace LastHope.DealingWithTables
{
    public partial class EditClient : Form
    {
        клієнтиTableAdapter клієнтиTableAdapter;
        int id = -999;


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
                    // MessageBox.Show("Query Executed");
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
        public EditClient()
        {
            InitializeComponent();
        }
        public EditClient(клієнтиTableAdapter клієнтиTableAdapter, int id)
        {
            InitializeComponent();
            this.id = id;
            this.клієнтиTableAdapter = клієнтиTableAdapter;
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            if (id != -999)
            {
                dataGridView1.Hide();
                клієнтиTableAdapter.GetData();
                string q = "SELECT * FROM  Клієнти WHERE Id_Клієнта = '" + id + "'";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                id_КлієнтаTextBox.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                прізвищеTextBox.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                ім_яTextBox.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                по_батьковіTextBox.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                дата_народженняDateTimePicker.Value = (DateTime)dataGridView1.Rows[0].Cells[4].Value;
                статьTextBox.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                телефонTextBox.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                поштаTextBox.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            }
            else
            {
                dataGridView1.Hide();
                id_КлієнтаTextBox.Hide();
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (id != -999)
            {

                string date = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                // '2014-03-16 00:00:00.000'   
                string updateQuery = "UPDATE Клієнти SET Дата_народження = '" + date + "',Прізвище = '" + прізвищеTextBox.Text + "', Ім_я = '" + ім_яTextBox.Text + "', По_батькові = '" + по_батьковіTextBox.Text + "', Пошта = '" + поштаTextBox.Text + "',  Стать = '" + статьTextBox.Text + "', Телефон = '" + телефонTextBox.Text + "' WHERE Id_Клієнта = " + id + "";
                executeMyQuery(updateQuery);
                this.Close();
            }
            else
            {
                string date = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                // '2014-03-16 00:00:00.000' 
                string addQuery = "INSERT INTO  Клієнти (Прізвище,Ім_я,По_батькові,Дата_народження, Стать, Телефон, Пошта) VALUES('" + прізвищеTextBox.Text + "', '" + ім_яTextBox.Text + "', '" + по_батьковіTextBox.Text + "', '" + date + "', '" + статьTextBox.Text + "', '" + телефонTextBox.Text + "', '" + поштаTextBox.Text + "')";
                executeMyQuery(addQuery);
                this.Close();
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
