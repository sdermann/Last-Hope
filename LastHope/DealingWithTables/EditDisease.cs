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
    public partial class EditDisease : Form
    {
        хворобиTableAdapter хворобиTableAdapter;
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
        public EditDisease()
        {
            InitializeComponent();
        }
        public EditDisease(хворобиTableAdapter хворобиTableAdapter, int id)
        {
            InitializeComponent();
            this.id = id;
            this.хворобиTableAdapter = хворобиTableAdapter;
        }



        private void EditDisease_Load(object sender, EventArgs e)
        {

            if (id != -999)
            {
                dataGridView1.Hide();
                хворобиTableAdapter.GetData();
                string q = "SELECT * FROM  Хвороби WHERE Id_Хвороби = '" + id + "'";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                id_ХворобиTextBox.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                назва_хворобиTextBox.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                короткий_описTextBox.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                тяжкість_лікуванняUpDown.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
              
            }
            else
            {
                dataGridView1.Hide();
                id_ХворобиTextBox.Hide();
                label2.Hide();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (назва_хворобиTextBox.Text != "" && короткий_описTextBox.Text != ""
                 && тяжкість_лікуванняUpDown.Text != "" )
            {
                if (id != -999)
            {
                string updateQuery = "UPDATE Хвороби SET Назва_хвороби = '" + назва_хворобиTextBox.Text + "', Короткий_опис = '" + короткий_описTextBox.Text + "',Тяжкість_лікування = '" + тяжкість_лікуванняUpDown.Text + "' WHERE Id_Хвороби = " + id + "";
                executeMyQuery(updateQuery);
                this.Close();
            }
            else
            {
                
                string addQuery = "INSERT INTO  Хвороби (Назва_хвороби, Короткий_опис, Тяжкість_лікування) VALUES( '"+назва_хворобиTextBox.Text+"','"+короткий_описTextBox.Text+"','"+ тяжкість_лікуванняUpDown.Text+"')";
                executeMyQuery(addQuery);
                this.Close();
            }
            }
            else
            {
                MessageBox.Show("Заповніть дані про хворобу коректно");
            }
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void назва_хворобиTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
