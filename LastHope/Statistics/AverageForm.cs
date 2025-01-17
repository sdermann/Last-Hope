﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastHope
{
    //TO DO : appropriate convertation
    public partial class AverageForm : Form
    {
        public AverageForm()
        {
            InitializeComponent();
            dataGridView1.Hide();
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
        private void AverageForm_Load(object sender, EventArgs e)
        {
            string q1 = "SELECT Прізвище, Ім_я, По_батькові, Телефон FROM Клієнти ";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
        
        }

        private void TextSearchBox_TextChanged(object sender, EventArgs e)
        {
            string surnameC = TextSearchBox.Text;
            string q1 = "SELECT Прізвище, Ім_я, По_батькові, Телефон FROM Клієнти WHERE Прізвище  LIKE  '%" + surnameC + "%'  ";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                var activeRow = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];

                string q1 = "Select SEC_TO_TIME(AVG(TIME_TO_SEC(timediff(Кінець_сесії,Початок_сесії )))) From сесії where ID_Клієнта2 = (SELECT Id_Клієнта From  Клієнти WHERE Прізвище = '" + activeRow.Cells[0].Value.ToString() + "') AND Результат != 'Запланована'";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(q1, connection);
                adapter2.Fill(table2);
            
                dataGridView1.DataSource = table2;
             

                if (dataGridView1.Rows.Count != 0)
                {
                    string hours = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    string minutes = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    if (hours != "" && hours != "")
                    {
                        hours = hours.Substring(0,2);
                        minutes = minutes.Substring(3, 2);
                        
                        AvgLabel.Text = "У середньому клієнт витрачає на сесії: "+hours+ " год. та "+ minutes + " хв.";
                    }
                    else
                    {
                        AvgLabel.Text = "Клієнт не відвідав жодної сесії.\nНеобхідно йому зателефонувати";
                    }

                }
              
            }
        }

        private void FiltData_SelectedItemChanged(object sender, EventArgs e)
        {


            DateTime dateTime;
            DateTime otherDateTime;
            string date;
            DateTime dateTime2;
            DateTime otherDateTime2;
            string date2;



            if (FiltData.Text == "До 18")
            {

                dateTime2 = DateTime.Now;
                otherDateTime2 = dateTime2.AddDays(0);
                date2 = otherDateTime2.ToString("yyyy-MM-dd"); 

                dateTime = DateTime.Now;
                otherDateTime = dateTime.AddDays(-18*365);
                date = otherDateTime.ToString("yyyy-MM-dd");
            }
            else if (FiltData.Text == "Від 18 до 35")
            {

                dateTime2 = DateTime.Now;
                otherDateTime2 = dateTime2.AddDays(-18 * 365);
                date2 = otherDateTime2.ToString("yyyy-MM-dd"); 

                dateTime = DateTime.Now;
                otherDateTime = dateTime.AddDays(- 35 * 365);
                date = otherDateTime.ToString("yyyy-MM-dd");
            }
            else if (FiltData.Text == "Від 35 до 65")
            {
                dateTime2 = DateTime.Now;
                otherDateTime2 = dateTime2.AddDays(-35 * 365);
                date2 = otherDateTime2.ToString("yyyy-MM-dd");

                dateTime = DateTime.Now;
                otherDateTime = dateTime.AddDays(-65 * 365);
                date = otherDateTime.ToString("yyyy-MM-dd");
            }
            else
            {


                dateTime2 = DateTime.Now;
                otherDateTime2 = dateTime2.AddDays(-65 * 365);
                date2 = otherDateTime2.ToString("yyyy-MM-dd");
                //Після 65
                dateTime = DateTime.Now;
                otherDateTime = dateTime.AddDays(-100 * 365);
                date = otherDateTime.ToString("yyyy-MM-dd");
            }


            

            string q2 = "SELECT Прізвище, Ім_я, По_батькові, Телефон FROM Клієнти Where Дата_народження >= '"+date+ "' AND Дата_народження < '" + date2 + "'";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q2, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
            if (dataGridView2.Rows.Count > 0)
            {
                var activeRow = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];

                string q1 = "Select SEC_TO_TIME(AVG(TIME_TO_SEC(timediff(Кінець_сесії,Початок_сесії )))) From сесії where ID_Клієнта2 = (SELECT Id_Клієнта From  Клієнти WHERE Прізвище = '" + activeRow.Cells[0].Value.ToString() + "') AND Результат != 'Запланована' ";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(q1, connection);
                adapter2.Fill(table2);

                dataGridView1.DataSource = table2;
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
