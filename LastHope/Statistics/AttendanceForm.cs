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
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }
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
        private void TextSearchBox_TextChanged(object sender, EventArgs e)
        {
            string surnameC = TextSearchBox.Text;
            string q1 = "SELECT Прізвище, Ім_я, По_батькові, Телефон FROM Клієнти WHERE Прізвище  LIKE  '%" + surnameC + "%'  ";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            string q1 = "SELECT Прізвище, Ім_я, По_батькові, Телефон FROM Клієнти ";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dateTime;
            DateTime otherDateTime;
            string date;
            if (dataGridView2.Rows.Count != 0)
            {


                if (FiltData.Text == "Весь час")
                {
                    dateTime = DateTime.Now;
                    otherDateTime = dateTime.AddDays(-8000);
                    date = otherDateTime.ToString("yyyy-MM-dd");
                }
                else if (FiltData.Text == "Неділя")
                {
                    dateTime = DateTime.Now;
                    otherDateTime = dateTime.AddDays(-7);
                    date = otherDateTime.ToString("yyyy-MM-dd");
                }
                else if (FiltData.Text == "Місяць")
                {
                    dateTime = DateTime.Now;
                    otherDateTime = dateTime.AddDays(-30);
                    date = otherDateTime.ToString("yyyy-MM-dd");
                }
                else
                {
                    dateTime = DateTime.Now;
                    otherDateTime = dateTime.AddDays(-365);
                    date = otherDateTime.ToString("yyyy-MM-dd");
                }

                if (dataGridView2.Rows.Count != 0)
                {
                    var activeRow = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];

                    string q1 = "SELECT Дата, Початок_сесії, Кінець_сесії, Результат FROM  Сесії WHERE ID_Клієнта2 = (SELECT Id_Клієнта From  Клієнти WHERE Прізвище = '" + activeRow.Cells[0].Value.ToString() + "') AND Результат != 'Запланована' AND Дата >= '" + date + "'";
                    DataTable table2 = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(q1, connection);
                    adapter2.Fill(table2);

                    dataGridView1.DataSource = table2;
                    if (dataGridView1.Rows.Count != 0)
                    {
                        //SelectFirstRow();
                        AmountOfSessions.Text = dataGridView1.Rows.Count.ToString();
                    }
                    else
                    {
                        AmountOfSessions.Text = "0 - Нагадайте клієнтові";
                    }
                }
            }
        }

        private void TextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
