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
    public partial class EditPsycho : Form

    {

        
        психологиTableAdapter психологиTableAdapter;
        int id = -999;
        bool flagForDate = false;
        bool email = false;


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
                flagForDate = true;
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
                статьUpDown.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                телефонTextBox.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                поштаTextBox.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                роки_кваліфікаціїTextBox.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                лікарська_ступіньUpDown.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            }
            else
            {
                dataGridView1.Hide();
                iD_ПсихологаTextBox.Hide();
                label2.Hide();
            }
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButt_Click(object sender, EventArgs e)
        {
            if (прізвищеTextBox.Text != "" && ім_яTextBox.Text != ""
                      && по_батьковіTextBox.Text != "" && flagForDate != false
                      && статьUpDown.Text != "" && телефонTextBox.Text != ""
                      && поштаTextBox.Text != "" && email == true && роки_кваліфікаціїTextBox.Text != "" 
                      &&  лікарська_ступіньUpDown.Text != ""
                      && дата_народженняDateTimePicker.Value != DateTime.Now)
            {
                if (id != -999)
                {

                    string date = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    // '2014-03-16 00:00:00.000'   
                    string updateQuery = "UPDATE Психологи SET Дата_народження = '" + date + "',Прізвище = '" + прізвищеTextBox.Text + "', Ім_я = '" + ім_яTextBox.Text + "', По_батькові = '" + по_батьковіTextBox.Text + "', Пошта = '" + поштаTextBox.Text + "', Роки_кваліфікації = " + int.Parse(роки_кваліфікаціїTextBox.Text) + ",  Стать = '" + статьUpDown.Text + "', Телефон = '" + телефонTextBox.Text + "', Лікарська_ступінь = '" + лікарська_ступіньUpDown.Text + "' WHERE ID_Психолога = " + id + "";
                    executeMyQuery(updateQuery);
                    this.Close();
                }
                else
                {
                    string date = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    // '2014-03-16 00:00:00.000' 
                    string addQuery = "INSERT INTO  Психологи (Прізвище,Ім_я,По_батькові,Дата_народження, Стать, Телефон, Пошта,Роки_кваліфікації, Лікарська_ступінь) VALUES('" + прізвищеTextBox.Text + "', '" + ім_яTextBox.Text + "', '" + по_батьковіTextBox.Text + "', '" + date + "', '" + статьUpDown.Text + "', '" + телефонTextBox.Text + "', '" + поштаTextBox.Text + "', " + int.Parse(роки_кваліфікаціїTextBox.Text) + ",  '" + лікарська_ступіньUpDown.Text + "')";
                    executeMyQuery(addQuery);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Заповніть дані про психолога коректно");
            }

        }

        private void прізвищеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void дата_народженняDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (дата_народженняDateTimePicker.Value > DateTime.Now.AddYears(-18) || дата_народженняDateTimePicker.Value < DateTime.Now.AddYears(-100))
            {
                дата_народженняDateTimePicker.Value = DateTime.Now;

            }
            else
            {
                flagForDate = true;
            }
        }

        private void поштаTextBox_TextChanged(object sender, EventArgs e)
        {
            email = IsValidEmail(поштаTextBox.Text);
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
