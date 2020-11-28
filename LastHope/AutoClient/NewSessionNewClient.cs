using LastHope.mydbDataSetTableAdapters;
using MySql.Data.MySqlClient;
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

namespace LastHope.AutoClient
{
    public partial class NewSessionNewClient : Form
    {
        Label label;
        string date;
        string time;
        string SurnameP;
        string NameP;
        психологиTableAdapter психологиTableAdapter;
        
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
        public NewSessionNewClient(Label label)
        {
            InitializeComponent();
            this.label = label;
            EndPanel.Hide();
        }
        public NewSessionNewClient()
        {
            InitializeComponent();
          
            EndPanel.Hide();
        }


        private void NewSessionNewClient_Load(object sender, EventArgs e)
        {
            this.клієнтиTableAdapter.Fill(this.mydbDataSet.клієнти);
            DateTime.Today.AddDays(1);
            radioButton1.Text = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
            radioButton2.Text = DateTime.Today.AddDays(2).ToString("yyyy-MM-dd HH:mm:ss");
            radioButton3.Text = DateTime.Today.AddDays(3).ToString("yyyy-MM-dd HH:mm:ss");
            radioButton4.Text = DateTime.Today.AddDays(4).ToString("yyyy-MM-dd HH:mm:ss");
            radioButton5.Text = DateTime.Today.AddDays(5).ToString("yyyy-MM-dd HH:mm:ss");
            radioButton6.Text = DateTime.Today.AddDays(6).ToString("yyyy-MM-dd HH:mm:ss");
            radioButton7.Text = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd HH:mm:ss");
            EndPanel.Hide();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true ||
                radioButton5.Checked == true || radioButton6.Checked == true || radioButton7.Checked == true)
            {
                if(timeUpDown.Text != "Обрати час:")
                {
                    //TODO Client
                      EndPanel.Show();
                    // Создать сессию 
                    time = timeUpDown.Text;
                    DateTime prob = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTime prob2 = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).AddHours(1);
                    string timeBeg = prob.ToString("HH:mm:ss");
                    string timeEnd = prob2.ToString("HH:mm:ss");
                    // Психологи которые могут в это время
                    this.психологиTableAdapter = психологиTableAdapter1;
                    психологиTableAdapter.GetData();
                    string q = "SELECT Прізвище,Ім_я,По_батькові FROM  Психологи";
 //                   SELECT Прізвище, Ім_я, По_батькові FROM Психологи WHERE ID_Психолога NOT IN
 //(SELECT ID_Психолога2 FROM Сесії WHERE
 //"16:00:00" >= Початок_сесії  AND "19:00:00" <= Кінець_сесії  AND Дата = "2020-11-12"
 //OR "19:00:00" >= Початок_сесії  AND "19:00:00" <= Кінець_сесії  AND Дата = "2020-11-12"
 // OR "16:00:00" >= Початок_сесії  AND "16:00:00" <= Кінець_сесії    AND Дата = "2020-11-12"
 //GROUP BY ID_Психолога2);
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    if (radioButton1.Checked == true)
                    {
                        date = radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        date = radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        date = radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        date = radioButton4.Text;
                    }
                    else if (radioButton5.Checked == true)
                    {
                        date = radioButton5.Text;
                    }
                    else if (radioButton6.Checked == true)
                    {
                        date = radioButton6.Text;
                    }
                    else 
                    {
                        date = radioButton7.Text;
                    }
                     
                    MessageBox.Show(date);
                    string date2 = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    // '2014-03-16 00:00:00.000' 
                    string addQuery = "INSERT INTO  Клієнти (Прізвище,Ім_я,По_батькові,Дата_народження, Стать, Телефон, Пошта) VALUES('" + прізвищеTextBox.Text + "', '" + ім_яTextBox.Text + "', '" + по_батьковіTextBox.Text + "', '" + date2 + "', '" + статьUpDown.Text + "', '" + телефонTextBox.Text + "', '" + поштаTextBox.Text + "')";
                    executeMyQuery(addQuery);
                }
                else
                {
                    MessageBox.Show("Оберіть час");
                }
            }
            else
            {
                MessageBox.Show("Оберіть день тижня");
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {


            DateTime prob = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime prob2 = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).AddHours(1);
            string timeBeg = prob.ToString("HH:mm:ss");
            string timeEnd = prob2.ToString("HH:mm:ss");
            //string addQuery = "INSERT INTO  Сесії (ID_Психолога2, ID_Клієнта2, Дата , Початок_сесії , Кінець_сесії , Результат) VALUES((SELECT ID_Психолога FROM Психологи WHERE Прізвище = '"+SurnameP+"' and Ім_я = '"+NameP+"' LIMIT 1),(SELECT Id_Клієнта from Клієнти ORDER BY Id_Клієнта DESC LIMIT 1), '" + date + "', '" + timeBeg + "', '" + timeEnd + "', 'Запланована')";
            string addQuery = "INSERT INTO  Сесії (ID_Психолога2, ID_Клієнта2, Дата , Початок_сесії , Кінець_сесії , Результат) VALUES(12,2, '" + date + "', '" + timeBeg + "', '" + timeEnd + "', 'Запланована')";
            executeMyQuery(addQuery);
            this.Close();
            
        }
    }
}
