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
    //TODO Client
    public partial class NewSessionNewClient : Form
    {
        Label label;
        bool flagForDate = false;
        string date;
        string time;
        string SurnameP;
        string NameP;
        DateTime prob;
        DateTime prob2;
        string timeBeg;
        string timeEnd;
        int idOfPs;
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

            DateTime.Today.AddDays(1);
            radioButton1.Text = DateTime.Today.AddDays(1).ToShortDateString();
            radioButton2.Text = DateTime.Today.AddDays(2).ToShortDateString();
            radioButton3.Text = DateTime.Today.AddDays(3).ToShortDateString();
            radioButton4.Text = DateTime.Today.AddDays(4).ToShortDateString();
            radioButton5.Text = DateTime.Today.AddDays(5).ToShortDateString();
            radioButton6.Text = DateTime.Today.AddDays(6).ToShortDateString();
            radioButton7.Text = DateTime.Today.AddDays(7).ToShortDateString();
            EndPanel.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true ||
                radioButton5.Checked == true || radioButton6.Checked == true || radioButton7.Checked == true)
            {
                if (timeUpDown.Text != "Обрати час:")
                {
                    if (прізвищеTextBox.Text != "" && ім_яTextBox.Text != ""
                        && по_батьковіTextBox.Text != "" && flagForDate != false
                        && статьUpDown.Text != "" && телефонTextBox.Text != ""
                        && поштаTextBox.Text != "")
                    {
                        string dateCl = дата_народженняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        string addQuery = "INSERT INTO  Клієнти (Прізвище,Ім_я,По_батькові,Дата_народження, Стать, Телефон, Пошта) VALUES('" + прізвищеTextBox.Text + "', '" + ім_яTextBox.Text + "', '" + по_батьковіTextBox.Text + "', '" + dateCl + "', '" + статьUpDown.Text + "', '" + телефонTextBox.Text + "', '" + поштаTextBox.Text + "')";
                        executeMyQuery(addQuery);
                        EndPanel.Show();
                        // Создать сессию 
                        time = timeUpDown.Text;
                        DateTime prob = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime prob2 = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).AddHours(1);
                        string timeBeg = prob.ToString("HH:mm:ss");
                        string timeEnd = prob2.ToString("HH:mm:ss");

                        if (radioButton1.Checked == true)
                        {
                            date = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else if (radioButton2.Checked == true)
                        {
                            date = DateTime.Today.AddDays(2).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else if (radioButton3.Checked == true)
                        {
                            date = DateTime.Today.AddDays(3).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else if (radioButton4.Checked == true)
                        {
                            date = DateTime.Today.AddDays(4).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else if (radioButton5.Checked == true)
                        {
                            date = DateTime.Today.AddDays(5).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else if (radioButton6.Checked == true)
                        {
                            date = DateTime.Today.AddDays(6).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            date = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        // Психологи которые могут в это время
                        this.психологиTableAdapter = психологиTableAdapter1;
                        психологиTableAdapter.GetData();
                        string q = "SELECT Прізвище, Ім_я, По_батькові FROM Психологи WHERE ID_Психолога NOT IN(SELECT ID_Психолога2 FROM Сесії WHERE'" + timeBeg + "' >= Початок_сесії  AND '" + timeEnd + "' <= Кінець_сесії  AND Дата = '" + date + "'OR '" + timeEnd + "' >= Початок_сесії  AND '" + timeEnd + "' <= Кінець_сесії  AND Дата = '" + date + "'OR '" + timeBeg + "' >= Початок_сесії  AND '" + timeBeg + "' <= Кінець_сесії    AND Дата = '" + date + "'GROUP BY ID_Психолога2)";
                        DataTable table = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;

                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Заповніть дані про себе коректно");
                    }

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
            string q = "SELECT ID_Психолога FROM Психологи WHERE ID_Психолога  IN(SELECT ID_Психолога from психологи where Прізвище = '"+ dataGridView1.SelectedRows[0].Cells[0].Value.ToString() +"')";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
            adapter.Fill(table);
            dataGridView3.DataSource = table;

            idOfPs = int.Parse(dataGridView3.Rows[0].Cells[0].Value.ToString());
            SurnameP = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            NameP = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            prob = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            prob2 = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).AddHours(1);
            timeBeg = prob.ToString("HH:mm:ss");
            timeEnd = prob2.ToString("HH:mm:ss");
            string addQuery = "INSERT INTO  Сесії (ID_Психолога2, ID_Клієнта2, Дата , Початок_сесії , Кінець_сесії , Результат) VALUES((SELECT ID_Психолога FROM Психологи WHERE Прізвище = '" + SurnameP + "' and Ім_я = '" + NameP + "' LIMIT 1),(SELECT Id_Клієнта from Клієнти ORDER BY Id_Клієнта DESC LIMIT 1), '" + date + "', '" + timeBeg + "', '" + timeEnd + "', 'Запланована')";
            executeMyQuery(addQuery);
            UpdateSchedule();
            this.Close();
            MessageBox.Show("Дякуємо Вам, що обрали наших спеціалістів!");
            label.Text = "end";

        }

        private void дата_народженняDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            flagForDate = true;
        }
        private void UpdateSchedule()
        {
            // schedule 

            prob = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            prob2 = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).AddHours(1);
            timeBeg = prob.ToString("HH:mm:ss");
            timeEnd = prob2.ToString("HH:mm:ss");
            string selectQuery = "SELECT * FROM розклади_психолога where ID_Психолога2 = (Select ID_Психолога from психологи where Прізвище = '" + SurnameP + "' LIMIT 1)and Дата = '" + date + "' ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView2.DataSource = table;

            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[0].Selected = true;
                var activeRow = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];
                //add session make schedule longer.

                //Longer
                string selectQuery1 = @" UPDATE розклади_психолога
                SET     `Початок_ роботи` = CASE
                                       WHEN `Початок_ роботи` >= '" + timeEnd + "' OR `Початок_ роботи` > '" + timeBeg + "' AND `Початок_ роботи` < '" + timeEnd + "'THEN '" + timeBeg + "'ELSE `Початок_ роботи`END WHERE   ID_Психолога2 = '" + activeRow.Cells[1].Value + "';";
                string selectQuery2 = @"UPDATE розклади_психолога SET Кінець_роботи = CASE WHEN Кінець_роботи <= '" + timeBeg + "' OR Кінець_роботи > '" + timeBeg + "'  AND Кінець_роботи< '" + timeEnd + "'THEN '" + timeEnd + "'ELSE Кінець_роботи END WHERE   ID_Психолога2 = '" + activeRow.Cells[1].Value + "';";
                executeMyQuery(selectQuery1);
                executeMyQuery(selectQuery2);
                this.Close();
            }
            else
            {

                string addQuery = "INSERT INTO Розклади_психолога(ID_Психолога2, Дата,`Початок_ роботи`, Кінець_роботи) VALUES('" + idOfPs + "', '" + date + "', '" + timeBeg + "', '" + timeEnd + "')";
                executeMyQuery(addQuery);
                this.Close();

            }
        }
    }
}
