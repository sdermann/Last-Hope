using LastHope.mydbDataSetTableAdapters;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LastHope.DealingWithTables
{
    public partial class EditTreatment : Form
    {

        динаміки_лікуванняTableAdapter динамікиTableAdapter;
        int id = -999;
        bool flagForDate = false;
        public EditTreatment()
        {
            InitializeComponent();
        }
        public EditTreatment(динаміки_лікуванняTableAdapter динамікиTableAdapter,int id)
        {
            InitializeComponent();
            this.id = id;
            this.динамікиTableAdapter = динамікиTableAdapter;

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

        private void SkipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTreatment_Load(object sender, EventArgs e)
        {
            string selectQuery1 = "SELECT Прізвище FROM клієнти";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
            //CL.
            List<string> DataCL = new List<string> { };
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataCL.Add(row.Cells[0].Value.ToString());
            }
            clientUpDown.Items.Clear();
            clientUpDown.Items.AddRange(DataCL);


            if (id != -999)
            {
                flagForDate = true;
                динамікиTableAdapter.GetData();
                string q = "select Id_Динаміки_лікування, клієнти.Прізвище AS 'Клієнт' ,  Динаміка, Реакція_клієнта, Дата_Фіксації from  динаміки_лікування left join поставлені_діагнози on Id_Поставленого_діагнозу2 = поставлені_діагнози.Id_Поставленого_діагнозу left join клієнти on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби  where Id_Динаміки_лікування = '"+id+"';";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(q, connection);
                adapter2.Fill(table2);
                dataGridView3.DataSource = table2;
                id_Динаміки_лікуванняTextBox.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();
                clientUpDown.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
                stateUpDown.Text = dataGridView3.Rows[0].Cells[2].Value.ToString();
                ReactionUpDown.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();
                дата_фіксаціїDateTimePicker.Value = (DateTime)dataGridView3.Rows[0].Cells[4].Value;
                dataGridView1.Hide();
                ChoiceLabel.Hide();

                

            }
            else
            {
                id_Динаміки_лікуванняTextBox.Hide();
                label2.Hide();
            }
    }

        private void SaveButton_Click(object sender, EventArgs e)
        {
                     
            if (clientUpDown.Text != "Оберіть клієнта" && ReactionUpDown.Text != "Оберіть стан"
                      && stateUpDown.Text != "Оберіть стан" && flagForDate != false)
            {
            if (id != -999)
            {

                string date = дата_фіксаціїDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    // '2014-03-16 00:00:00.000'  
                    if (dataGridView1.Rows.Count > 0)
                    {
                        var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                        string updateQuery = @"UPDATE Динаміки_лікування SET  Дата_Фіксації = '" + date + "', Динаміка = '" + stateUpDown.Text + "' , Реакція_клієнта  = '" + ReactionUpDown.Text + "' where Id_Динаміки_лікування = '" + int.Parse(activeRow.Cells[0].Value.ToString()) + "'; ";
                        executeMyQuery(updateQuery);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Немає діагнозу для створення динаміки");
                    }
            }
            else
            {
                string date = дата_фіксаціїDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    //    // '2014-03-16 00:00:00.000'
                    if (dataGridView1.Rows.Count > 0)
                    {
                        var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                             
                        string addQuery = @" INSERT INTO  Динаміки_лікування(Id_Поставленого_діагнозу2, Динаміка, Реакція_клієнта,Дата_Фіксації)
                               VALUES('"+ int.Parse(activeRow.Cells[0].Value.ToString()) + "','" + stateUpDown.Text+"', '"+ReactionUpDown.Text+"','"+date+"');";
                         executeMyQuery(addQuery);
                         this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Немає діагнозу для створення динаміки");
                    }
                }
            }
            else
            {
                MessageBox.Show("Заповніть дані про динаміку коректно");
            }
        }

        private void clientUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

            string selectQuery = "select Id_Поставленого_діагнозу, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби' from поставлені_діагнози left join клієнти on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби where клієнти.Прізвище = '" + clientUpDown.Text + "'; ";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.Show();
                ChoiceLabel.Text = "Оберіть діагноз: ";
                ChoiceLabel.Show();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                dataGridView1.Hide();
                ChoiceLabel.Show();
                ChoiceLabel.Text = "Оберіть діагноз: на щастя, у цього клієнта немає діагнозів !";
            }
        }

        private void дата_фіксаціїDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            if (дата_фіксаціїDateTimePicker.Value > DateTime.Now|| дата_фіксаціїDateTimePicker.Value < DateTime.Now.AddYears(-25))
            {
                дата_фіксаціїDateTimePicker.Value = DateTime.Now;

            }
            else
            {
                flagForDate = true;
            }
        }
    }
}
