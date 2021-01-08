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
    public partial class EditDiagnoses : Form
    {
        поставлені_діагнозиTableAdapter діагнозиTableAdapter;
        int id = -999;
        bool flagForDate = false;

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
        public EditDiagnoses(поставлені_діагнозиTableAdapter діагнозиTableAdapter, int id)
        {
            InitializeComponent();
            this.id = id;
            this.діагнозиTableAdapter = діагнозиTableAdapter;

        }

        public EditDiagnoses()
        {
            InitializeComponent();

        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (clientUpDown.Text != "Оберіть клієнта" && diseaseUpDown.Text != "Оберіть хворобу"
                      && stateUpDown.Text != "Оберіть стан" && flagForDate != false)
            {
                if (id != -999)
                {

                    string date = дата_озвучуванняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    // '2014-03-16 00:00:00.000'  

                    string updateQuery = "UPDATE Поставлені_діагнози SET  Дата_озвучування = '" + date + "',Id_Клієнта2 = (SELECT Id_Клієнта From Клієнти WHERE Прізвище = '" + clientUpDown.Text + "'), Id_Хвороби2 = (SELECT Id_Хвороби From Хвороби WHERE Назва_Хвороби = '" + diseaseUpDown.Text + "'), Затвердження_нарадою =  '" + stateUpDown.Text + "' where Id_Поставленого_діагнозу = '" + id + "'; ";
                    executeMyQuery(updateQuery);
                    this.Close();
                }
                else
                {
                    string date = дата_озвучуванняDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    //    // '2014-03-16 00:00:00.000'

                    string addQuery = @"INSERT INTO Поставлені_діагнози(Id_Клієнта2, Id_Хвороби2, Дата_озвучування, Затвердження_нарадою)
                VALUES((SELECT Id_Клієнта From Клієнти WHERE Прізвище = '" + clientUpDown.Text + "'),(SELECT Id_Хвороби From Хвороби WHERE Назва_Хвороби = '" + diseaseUpDown.Text + "') , '" + date + "','" + stateUpDown.Text + "');";
                    executeMyQuery(addQuery);
                    this.Close();
                }
              
            }
            else
            {
                MessageBox.Show("Заповніть дані про діагноз коректно");
            }
        }

        private void EditDiagnoses_Load(object sender, EventArgs e)
        {
            flagForDate = true;
            string selectQuery1 = "SELECT Прізвище FROM клієнти";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection);
            adapter1.Fill(table1);
            dataGridView4.DataSource = table1;

            string selectQuery = "SELECT Назва_хвороби FROM хвороби";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView2.DataSource = table;


            //PS.
            List<string> DataDZ = new List<string> { };
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataDZ.Add(row.Cells[0].Value.ToString());
            }
            diseaseUpDown.Items.Clear();
            diseaseUpDown.Items.AddRange(DataDZ);
            //CL.
            List<string> DataCL = new List<string> { };
            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                DataCL.Add(row.Cells[0].Value.ToString());
            }
            clientUpDown.Items.Clear();
            clientUpDown.Items.AddRange(DataCL);

            if (id != -999)
            {

                діагнозиTableAdapter.GetData();
                string q = "select Id_Поставленого_діагнозу, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Дата_озвучування, Затвердження_нарадою from поставлені_діагнози left join клієнти  on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби where Id_Поставленого_діагнозу = '"+id+"'; ";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(q, connection);
                adapter2.Fill(table2);
                dataGridView1.DataSource = table2;
                id_Поставленого_діагнозуTextBox.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                clientUpDown.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                diseaseUpDown.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                
                дата_озвучуванняDateTimePicker.Value = (DateTime)dataGridView1.Rows[0].Cells[3].Value;
                stateUpDown.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();            
            }
            else
            {
                id_Поставленого_діагнозуTextBox.Hide();
                label2.Hide();
            }
        }

        private void дата_озвучуванняDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (дата_озвучуванняDateTimePicker.Value > DateTime.Now || дата_озвучуванняDateTimePicker.Value < DateTime.Now.AddYears(-25))
            {
                дата_озвучуванняDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                flagForDate = true;
            }
        }
    }
}
