﻿using LastHope.mydbDataSetTableAdapters;
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
    public partial class EditPsycho : Form

    {

        
        психологиTableAdapter психологиTableAdapter;
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
        public EditPsycho()
        {
            InitializeComponent();
        }
        public EditPsycho(психологиTableAdapter психологиTableAdapter, int id)
        {

            InitializeComponent();
            this.id = id;
            this.психологиTableAdapter = психологиTableAdapter;
        }

     

        private void EditPsycho_Load(object sender, EventArgs e)
        {
            if (id != -999)
            {
                dataGridView1.Hide();
                психологиTableAdapter.GetData();
                string q = "SELECT * FROM Психологи WHERE ID_Психолога = '" + id + "'  ";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                iD_ПсихологаTextBox.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                прізвищеTextBox.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                ім_яTextBox.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                по_батьковіTextBox.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                дата_народженняDateTimePicker.Value = (DateTime)dataGridView1.Rows[0].Cells[4].Value;
                статьTextBox.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                телефонTextBox.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                поштаTextBox.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                роки_кваліфікаціїTextBox.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                лікарська_ступіньTextBox.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            }
            else
            {
                dataGridView1.Hide();
                iD_ПсихологаTextBox.Hide();        
            }
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButt_Click(object sender, EventArgs e)
        {
            if (id != -999)
            {

                string date = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                // '2014-03-16 00:00:00.000'   
                string updateQuery = "UPDATE Психологи SET Дата_народження = '" + date + "',Прізвище = '" + прізвищеTextBox.Text + "', Ім_я = '" + ім_яTextBox.Text + "', По_батькові = '" + по_батьковіTextBox.Text + "', Пошта = '" + поштаTextBox.Text + "', Роки_кваліфікації = " + int.Parse(роки_кваліфікаціїTextBox.Text) + ",  Стать = '" + статьTextBox.Text + "', Телефон = '" + телефонTextBox.Text + "', Лікарська_ступінь = '" + лікарська_ступіньTextBox.Text + "' WHERE ID_Психолога = " + id + "";
                executeMyQuery(updateQuery);
                this.Close();
            }
            else
            {
                string date = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                // '2014-03-16 00:00:00.000' 
                string addQuery = "INSERT INTO  Психологи (Прізвище,Ім_я,По_батькові,Дата_народження, Стать, Телефон, Пошта,Роки_кваліфікації, Лікарська_ступінь) VALUES('" + прізвищеTextBox.Text + "', '" + ім_яTextBox.Text + "', '" + по_батьковіTextBox.Text + "', '" + date + "', '" + статьTextBox.Text + "', '" + телефонTextBox.Text + "', '" + поштаTextBox.Text + "', " + int.Parse(роки_кваліфікаціїTextBox.Text) + ",  '" + лікарська_ступіньTextBox.Text + "')";
                executeMyQuery(addQuery);
                this.Close();
            }

        }
    }
}
