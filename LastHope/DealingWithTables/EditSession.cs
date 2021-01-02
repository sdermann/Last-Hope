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


//ToDO TimeBags
namespace LastHope.DealingWithTables
{
    public partial class EditSession : Form
    {

        сесіїTableAdapter сесіїTableAdapter;
        int id = -999;
        string date;

        int idOfPs;
        int idOfCL;

        string time1;
        string time2;
        DateTime prob1;
        DateTime prob2;
        string timeBeg;
        string timeEnd;
        public EditSession()
        {
            InitializeComponent();
            
        }

        public EditSession(сесіїTableAdapter сесіїTableAdapter, int id)
        {
            InitializeComponent();
            this.id = id;
            this.сесіїTableAdapter = сесіїTableAdapter;
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
                    // MessageBox.Show("Query Executed");
                }
                else
                {
                    // MessageBox.Show("Query Not Executed");
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

        private void EditSession_Load(object sender, EventArgs e)
        {

            
            //Clients+Psychos 
            string selectQuery = "SELECT Прізвище FROM психологи";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;


            string selectQuery1 = "SELECT Прізвище FROM клієнти";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
            //PS.
            List<string> DataPS = new List<string> {};
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataPS.Add(row.Cells[0].Value.ToString());
            }
            PsychoUpDown.Items.Clear();
            PsychoUpDown.Items.AddRange(DataPS);
            //CL.
            List<string> DataCL = new List<string> { };
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataCL.Add(row.Cells[0].Value.ToString());
            }
            clientUpDown.Items.Clear();
            clientUpDown.Items.AddRange(DataCL);
            //Result.
            List<string> Result = new List<string> {"Негативний", "Позитивний","Стабільний" };
            ResultUpDown.Items.Clear();
            ResultUpDown.Items.AddRange(Result);
            if (id != -999)
            {
               
                сесіїTableAdapter.GetData();
                string q = "select Id_Сесії, психологи.Прізвище AS 'Психолог', клієнти.Прізвище AS 'Клієнт' , Дата, Початок_сесії, Кінець_сесії, Результат From сесії left join психологи on ID_Психолога2 = психологи.ID_Психолога left join клієнти on ID_Клієнта2 = клієнти.ID_Клієнта WHERE Id_Сесії = '" + id + "'";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(q, connection);
                adapter2.Fill(table2);
                dataGridView3.DataSource = table2;
                id_СесіїTextBox.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();
                PsychoUpDown.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
                clientUpDown.Text = dataGridView3.Rows[0].Cells[2].Value.ToString();
                датаDateTimePicker.Value = (DateTime)dataGridView3.Rows[0].Cells[3].Value;
                begSessionUpDown.Text = dataGridView3.Rows[0].Cells[4].Value.ToString();
                EndSessionUpDown.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                ResultUpDown.Text = dataGridView3.Rows[0].Cells[6].Value.ToString();
            }
            else
            {
                id_СесіїTextBox.Hide();
            }

        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Query = "Select ID_Психолога from психологи where Прізвище = '" + PsychoUpDown.Text + "' LIMIT 1";
            DataTable table11 = new DataTable();
            MySqlDataAdapter adapter11 = new MySqlDataAdapter(Query, connection);
            adapter11.Fill(table11);
            dataGridView4.DataSource = table11;
            idOfPs = int.Parse(dataGridView4.Rows[0].Cells[0].Value.ToString());
            dataGridView4.Rows.RemoveAt(0);


          
           

            if (id != -999)
            {
                time1 = begSessionUpDown.Text;
                time2 = EndSessionUpDown.Text;
                prob1 = DateTime.ParseExact(time1, "HH:mm:ss", CultureInfo.InvariantCulture);
                prob2 = DateTime.ParseExact(time2, "HH:mm:ss", CultureInfo.InvariantCulture);
                timeBeg = prob1.ToString("HH:mm:ss");
                timeEnd = prob2.ToString("HH:mm:ss");
                date = датаDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                // '2014-03-16 00:00:00.000'   
                string updateQuery = "update сесії set ID_Психолога2 = (Select ID_Психолога from психологи where Прізвище = '"+PsychoUpDown.Text+ "' LIMIT 1),ID_Клієнта2 = (Select Id_Клієнта from клієнти  where Прізвище = '" + clientUpDown.Text+ "' LIMIT 1),Дата = '" + date + "'  ,Початок_сесії = '"+timeBeg+"',Кінець_сесії = '"+timeEnd+"' ,Результат ='"+ResultUpDown.Text+"'  WHERE Id_Сесії = '" + id + "'";
                executeMyQuery(updateQuery);
                UpdateSchedule();
                this.Close();
            }
            else
            {
                time1 = begSessionUpDown.Text;
                time2 = EndSessionUpDown.Text;
                prob1 = DateTime.ParseExact(time1, "HH:mm:ss", CultureInfo.InvariantCulture);
                prob2 = DateTime.ParseExact(time2, "HH:mm:ss", CultureInfo.InvariantCulture);
                timeBeg = prob1.ToString("HH:mm:ss");
                timeEnd = prob2.ToString("HH:mm:ss");
                date = датаDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                // '2014-03-16 00:00:00.000'   
                string addQuery =  "INSERT INTO  Сесії (ID_Психолога2, ID_Клієнта2, Дата , Початок_сесії , Кінець_сесії , Результат) VALUES((SELECT ID_Психолога FROM Психологи WHERE Прізвище = '"+PsychoUpDown.Text+"' LIMIT 1),(SELECT Id_Клієнта from клієнти where Прізвище = '" + clientUpDown.Text+ "' LIMIT 1), '" + date + "', '" + timeBeg + "', '" + timeEnd + "', '"+ResultUpDown.Text+"')";
                executeMyQuery(addQuery);
                UpdateSchedule();
                this.Close();
            }
        }
        private void UpdateSchedule()
        {
                  // schedule 
                  string selectQuery = "SELECT * FROM розклади_психолога where ID_Психолога2 = (Select ID_Психолога from психологи where Прізвище = '"+PsychoUpDown.Text+ "' LIMIT 1) and Дата = '"+date+"'";
                  DataTable table = new DataTable();
                  MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                  adapter.Fill(table);
                  dataGridView4.DataSource = table;
            if(dataGridView4.Rows.Count == 1)
            {
                dataGridView4.Rows[0].Selected = true;
                var activeRow = dataGridView4.Rows[dataGridView4.CurrentCell.RowIndex];
                //add session make schedule longer.

                //Longer
                string selectQuery1 = @" UPDATE розклади_психолога
                SET     `Початок_ роботи` = CASE
                                       WHEN `Початок_ роботи` >= '" + timeEnd + "' OR `Початок_ роботи` > '" + timeBeg + "' AND `Початок_ роботи` < '" + timeEnd + "'THEN '" + timeBeg + "'ELSE `Початок_ роботи`END WHERE   ID_Психолога2 = 4; UPDATE розклади_психолога SET Кінець_роботи = CASE WHEN Кінець_роботи <= '" + timeBeg + "' OR Кінець_роботи > '" + timeBeg + "'  AND Кінець_роботи< '" + timeEnd + "'THEN '" + timeEnd + "'ELSE Кінець_роботи END WHERE   ID_Психолога2 = 4;";
                executeMyQuery(selectQuery1);
                this.Close();
            }
            else
            {
                MessageBox.Show(idOfPs.ToString());
                string addQuery = "INSERT INTO Розклади_психолога(ID_Психолога2, Дата,`Початок_ роботи`, Кінець_роботи) VALUES('"+idOfPs+"', '"+date+"', '"+ timeBeg + "', '"+ timeEnd + "')";
                executeMyQuery(addQuery);
                this.Close();
                              
            }
            
        }
    }
}
