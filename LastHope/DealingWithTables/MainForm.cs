using LastHope.DealingWithTables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;




namespace LastHope
{
    public partial class MainForm : Form
    {
        //flag
        bool IsDirty = false;
        public MainForm()
        {
            InitializeComponent();

            //HidePanels
            SortPanel.Hide();
            FiltPanel.Hide();
            SearchPanel.Hide();
            ResetButt.Hide();


        }
        public void populateDGV()
        {
            string tablen = TableLabel.Text.Substring(0, TableLabel.Text.Length - 1);
            string selectQuery = "SELECT * FROM " + tablen + "";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            SelectFirstRow();
        }
        public void populateShedule()
        {
            string selectQuery3 = "select Id_Розкладу_психолога,психологи.Прізвище,  Дата, `Початок_ роботи`, Кінець_роботи From розклади_психолога  left join психологи on ID_Психолога2 = психологи.ID_Психолога; ";
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
            adapter3.Fill(table3);
            dataGridView1.DataSource = table3;
            SelectFirstRow();
        }
        public void populateSession()
        {
            string selectQuery3 = "select Id_Сесії, психологи.Прізвище AS 'Психолог', клієнти.Прізвище AS 'Клієнт' , Дата, Початок_сесії, Кінець_сесії, Результат From сесії left join психологи on ID_Психолога2 = психологи.ID_Психолога left join клієнти on ID_Клієнта2 = клієнти.ID_Клієнта; ";
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
            adapter3.Fill(table3);
            dataGridView1.DataSource = table3;
            SelectFirstRow();
        }
        public void populateDiagnoses()
        {
            string selectQuery3 = "select Id_Поставленого_діагнозу, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Дата_озвучування, Затвердження_нарадою from поставлені_діагнози left join клієнти  on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби; ";
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
            adapter3.Fill(table3);
            dataGridView1.DataSource = table3;
            SelectFirstRow();
        }
        public void populateDynamics()
        {
            string selectQuery3 = "   select Id_Динаміки_лікування, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Динаміка, Реакція_клієнта, Дата_Фіксації from  динаміки_лікування left join поставлені_діагнози on Id_Поставленого_діагнозу2 = поставлені_діагнози.Id_Поставленого_діагнозу left join клієнти on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби; ";
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
            adapter3.Fill(table3);
            dataGridView1.DataSource = table3;
            SelectFirstRow();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.хвороби' table. You can move, or remove it, as needed.
            this.хворобиTableAdapter.Fill(this.mydbDataSet.хвороби);
            // TODO: This line of code loads data into the 'mydbDataSet.сесії' table. You can move, or remove it, as needed.
            this.сесіїTableAdapter.Fill(this.mydbDataSet.сесії);
            // TODO: This line of code loads data into the 'mydbDataSet.розклади_психолога' table. You can move, or remove it, as needed.
            this.розклади_психологаTableAdapter.Fill(this.mydbDataSet.розклади_психолога);
            // TODO: This line of code loads data into the 'mydbDataSet.психологи' table. You can move, or remove it, as needed.
            this.психологиTableAdapter.Fill(this.mydbDataSet.психологи);
            // TODO: This line of code loads data into the 'mydbDataSet.поставлені_діагнози' table. You can move, or remove it, as needed.
            this.поставлені_діагнозиTableAdapter.Fill(this.mydbDataSet.поставлені_діагнози);
            // TODO: This line of code loads data into the 'mydbDataSet.клієнти' table. You can move, or remove it, as needed.
            this.клієнтиTableAdapter.Fill(this.mydbDataSet.клієнти);
            // TODO: This line of code loads data into the 'mydbDataSet.динаміки_лікування' table. You can move, or remove it, as needed.
            this.динаміки_лікуванняTableAdapter.Fill(this.mydbDataSet.динаміки_лікування);

            // TODO: This line of code loads data into the 'mydbDataSet.психологи' table. You can move, or remove it, as needed.
            //this.психологиTableAdapter.Fill(this.mydbDataSet.психологи);
            dataGridView1.AutoGenerateColumns = true;

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
                    //MessageBox.Show("Query Executed");
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
        private void SelectFirstRow()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        //SQL-end
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: add the rest
            //психологиTableAdapter.Update(mydbDataSet);
        }

        private void психологиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            bindingNavigator1.BindingSource = психологиBindingSource;
            dataGridView1.DataSource = психологиBindingSource;
            TableLabel.Text = "Психологи:";
            populateDGV();
            SelectFirstRow();
        }
 
        private void розкладиПсихологівToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            TableLabel.Text = "Розклади психологів:";      
            populateShedule();
           
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = клієнтиBindingSource;
            dataGridView1.DataSource = клієнтиBindingSource;
            TableLabel.Text = "Клієнти:";
            populateDGV();
            SelectFirstRow();
        }

        private void сесіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableLabel.Text = "Сесії:";
            populateSession();
        }

        private void поставленіДіагнозиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            TableLabel.Text = "Поставлені діагнози:";
            populateDiagnoses();
          
        }

        private void динамікиЛікуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableLabel.Text = "Динаміки лікування:";
            populateDynamics();

        }

        private void хворобиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = хворобиBindingSource;
            dataGridView1.DataSource = хворобиBindingSource;
            TableLabel.Text = "Хвороби:";
            //populateDGV();
            SelectFirstRow();
        }

        private void TableLabel_TextChanged(object sender, EventArgs e)
        {
            //Filling panels.
            string LabelText = TableLabel.Text;

            switch (LabelText)
            {
                case "Психологи:":
                    Agepanel.Hide();
                    FindDateTimePicker.Hide();
                    TextSearchBox.Show();
                    FiltLabel.Show();
                    Heeeey.Hide();
                    //Sort.
                    List<string> sortData1 = new List<string> { "ID", "Прізвищем","Ім'ям", "По-батькові", "Віком", "Статтю", "Телефоном", "Поштою", "Роками кваліфікації", "Лікарським ступенем"};
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData1);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    List<string> filtData1 = new List<string> { "жінка", "чоловік", "трансгендер" };
                    FiltLabel.Text = "Cтаттю";
                    FiltData.Items.Clear();
                    FiltData.Items.AddRange(filtData1);
                    FiltData.Text = "жінка";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За прізвищем:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
                case "Клієнти:":
                    Agepanel.Show();
                    FindDateTimePicker.Hide();
                    TextSearchBox.Show();
                    FiltLabel.Show();
                    Heeeey.Hide();
                    //Sort.
                    List<string> sortData2 = new List<string> { "ID", "Прізвищем", "Ім'ям", "По-батькові", "Віком", "Статтю", "Телефоном", "Поштою" };
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData2);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    List<string> filtData2 = new List<string> { "жінка", "чоловік", "трансгендер" };
                    FiltLabel.Text = "Cтаттю";
                    FiltData.Items.Clear();
                    FiltData.Items.AddRange(filtData2);
                    FiltData.Text = "жіноча";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За прізвищем:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
                case "Хвороби:":
                    FiltLabel.Show();
                    Heeeey.Hide();
                    Agepanel.Hide();
                    FindDateTimePicker.Hide();
                    TextSearchBox.Show();
                    //Sort.
                    List<string> sortData3 = new List<string> { "ID", "Назвою","Описом","Тяжкістю"};
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData3);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    List<string> filtData3 = new List<string> { "Низька", "Середня", "Висока" };
                    FiltData.Items.Clear();
                    FiltLabel.Text = "Тяжкістю";
                    FiltData.Items.AddRange(filtData3);
                    FiltData.Text = "Низька";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За назвою:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;


                case "Розклади психологів:":
                    FiltLabel.Show();
                    Heeeey.Hide();
                    Agepanel.Hide();
                    FindDateTimePicker.Show();
                    TextSearchBox.Hide();
                    //Sort.
                    List<string> sortData4 = new List<string> { "ID", "Психологом", "Датою","Початком роботи","Кінцем роботи" };
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData4);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    string tablen = TableLabel.Text.Substring(0, TableLabel.Text.Length - 1);
                    string selectQuery = "SELECT Прізвище FROM психологи WHERE ID_Психолога IN (SELECT ID_Психолога2 FROM розклади_психолога)";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                    List<string> filtData4 = new List<string> { };
                    for(int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        filtData4.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }
                    FiltData.Items.Clear();
                    FiltLabel.Text = "Психологом";
                    FiltData.Items.AddRange(filtData4);
                    FiltData.Text = "Оберіть психолога";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За датою:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
                case "Сесії:":
                    FiltLabel.Hide();
                    Heeeey.Show();
                    Agepanel.Hide();
                    FindDateTimePicker.Show();
                    TextSearchBox.Hide();
                    //Sort.
                    List<string> sortData5 = new List<string> { "ID", "Психологом","Клієнтом", "Датою", "Початком роботи", "Кінцем роботи", "Результатом" };
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData5);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    if(Heeeey.Text == "Психологом")
                    {
                        string selectQuery2 = "SELECT Прізвище FROM психологи WHERE ID_Психолога IN (SELECT ID_Психолога2 FROM Сесії)";
                        DataTable table2 = new DataTable();
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery2, connection);
                        adapter2.Fill(table2);
                        dataGridView2.DataSource = table2;
                        List<string> filtData5 = new List<string> { };
                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        {
                            filtData5.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                        }
                        FiltData.Items.Clear();
                        FiltLabel.Text = "Психологом";
                        FiltData.Items.AddRange(filtData5);
                        FiltData.Text = "Оберіть психолога";
                        FiltPanel.Show();
                    }
                    else
                    {
                        string selectQuery2 = "SELECT Прізвище FROM клієнти WHERE Id_Клієнта IN (SELECT Id_Клієнта FROM Сесії)";
                        DataTable table2 = new DataTable();
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery2, connection);
                        adapter2.Fill(table2);
                        dataGridView2.DataSource = table2;
                        List<string> filtData5 = new List<string> { };
                        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                        {
                            filtData5.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                        }
                        FiltData.Items.Clear();
                        FiltLabel.Text = "Психологом";
                        FiltData.Items.AddRange(filtData5);
                        FiltPanel.Show();
                    }
                    
                    //Search.
                    SearchLabel.Text = "За датою:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
                case "Поставлені діагнози:":
                    //Sort.
                    Agepanel.Hide();
                    FindDateTimePicker.Hide();
                    TextSearchBox.Show();
                    FiltLabel.Show();
                    Heeeey.Hide();
                    List<string> sortData6 = new List<string> { "ID", "Хворобою", "Клієнтом", "Датою","Затвердженням"};
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData6);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    string tablen3 = TableLabel.Text.Substring(0, TableLabel.Text.Length - 1);
                    string selectQuery3 = "SELECT Прізвище FROM клієнти WHERE Id_Клієнта IN (SELECT Id_Клієнта2 FROM поставлені_діагнози)";
                    DataTable table3 = new DataTable();
                    MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
                    adapter3.Fill(table3);
                    dataGridView2.DataSource = table3;
                    List<string> filtData6 = new List<string> { };
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        filtData6.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }
                    FiltData.Items.Clear();
                    FiltLabel.Text = "Клієнтом";
                    FiltData.Items.AddRange(filtData6);
                    FiltData.Text = "Оберіть клієнта";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За назвою:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
                case "Динаміки лікування:":
                    FiltLabel.Show();
                    Heeeey.Hide();
                    Agepanel.Hide();
                    FindDateTimePicker.Hide();
                    TextSearchBox.Show();
                    //Sort.
                    List<string> sortData7 = new List<string> { "ID", "Клієнтом","Діагнозом","Динамікою","Реакцією" , "Датою фіксації"};
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData7);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    string tablen4 = TableLabel.Text.Substring(0, TableLabel.Text.Length - 1);
                    string selectQuery4 = "SELECT Прізвище FROM клієнти WHERE Id_Клієнта IN (SELECT Id_Клієнта2 FROM поставлені_діагнози)";
                    DataTable table4 = new DataTable();
                    MySqlDataAdapter adapter4 = new MySqlDataAdapter(selectQuery4, connection);
                    adapter4.Fill(table4);
                    dataGridView2.DataSource = table4;
                    List<string> filtData7 = new List<string> { };
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        filtData7.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }
                    FiltData.Items.Clear();
                    FiltLabel.Text = "Клієнтом";
                    FiltData.Items.AddRange(filtData7);
                    FiltData.Text = "Оберіть клієнта";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За назвою:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
            }
        }

        int counter = 1;
        //Sorting of tables
        private void SortButton_Click(object sender, EventArgs e)
        {
            string LabelText = TableLabel.Text;
            switch (LabelText)
            {
                case "Психологи:":
                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["ID_Психолога"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["ID_Психолога"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Прізвищем")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Прізвище"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Прізвище"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Ім'ям")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Ім_я"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Ім_я"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "По-батькові")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["По_батькові"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["По_батькові"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Статтю")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Стать"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Стать"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Телефоном")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Телефон"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Телефон"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Поштою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Пошта"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Пошта"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Роками кваліфікації")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Роки_кваліфікації"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Роки_кваліфікації"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Лікарським ступенем")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Лікарська_ступінь"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Лікарська_ступінь"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_народження"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_народження"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
                case "Клієнти:":

                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Клієнта"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Клієнта"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Прізвищем")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Прізвище"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Прізвище"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Ім'ям")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Ім_я"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Ім_я"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "По-батькові")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["По_батькові"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["По_батькові"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Статтю")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Стать"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Стать"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Телефоном")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Телефон"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Телефон"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Поштою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Пошта"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Пошта"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_народження"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_народження"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
                case "Хвороби:":

                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Хвороби"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Хвороби"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Описом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Короткий_опис"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Короткий_опис"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Тяжкістю")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Тяжкість_лікування"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Тяжкість_лікування"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Назва_хвороби"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Назва_хвороби"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
                case "Сесії:":
                 
                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Сесії"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Сесії"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Психологом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Психолог"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Психолог"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Клієнтом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Клієнт"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Клієнт"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Датою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Початком роботи")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Початок_сесії"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Початок_сесії"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Кінцем роботи")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Кінець_сесії"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Кінець_сесії"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Результат"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Результат"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
                 
                case "Поставлені діагнози:":
                    

                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Поставленого_діагнозу"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Поставленого_діагнозу"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Хворобою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Назва хвороби"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Назва хвороби"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Клієнтом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Клієнт"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Клієнт"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Датою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_озвучування"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_озвучування"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Затвердження_нарадою"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Затвердження_нарадою"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
                case "Динаміки лікування:":
         
                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Динаміки_лікування"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Динаміки_лікування"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Діагнозом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Назва хвороби"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Назва хвороби"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Клієнтом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Клієнт"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Клієнт"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Динамікою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Динаміка"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Динаміка"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Реакцією")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Реакція_клієнта"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Реакція_клієнта"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_Фіксації"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата_Фіксації"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
                case "Розклади психологів:":
                   
                    if (SortData.Text == "ID")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Розкладу_психолога"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Id_Розкладу_психолога"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Психологом")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Прізвище"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Прізвище"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Датою")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Дата"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else if (SortData.Text == "Початком роботи")
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Початок_ роботи"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Початок_ роботи"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    else
                    {
                        if (counter % 2 == 1)
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Кінець_роботи"], ListSortDirection.Ascending);
                            counter++;
                        }
                        else
                        {
                            dataGridView1.Sort(dataGridView1.Columns["Кінець_роботи"], ListSortDirection.Descending);
                            counter++;
                        }
                    }
                    break;
            }
        }

        //Filter for tables
        private void FiltButton_Click(object sender, EventArgs e)
        {
            string LabelText = TableLabel.Text;
            switch (LabelText)
            {
                case "Психологи:":
                    string sex = FiltData.Text;
                    string q = "SELECT * FROM Психологи WHERE Стать = '" + sex + "'  ";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    break;
                case "Клієнти:":
                    string sex1 = FiltData.Text;
                    string q1 = "SELECT * FROM Клієнти WHERE Стать = '" + sex1 + "'  ";
                    DataTable table1 = new DataTable();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
                    adapter1.Fill(table1);
                    dataGridView1.DataSource = table1;
                    break;
                case "Хвороби:":
                    string hard = FiltData.Text;
                    string q2 = "SELECT * FROM Хвороби WHERE Тяжкість_лікування = '" + hard + "'  ";
                    DataTable table2 = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(q2, connection);
                    adapter2.Fill(table2);
                    dataGridView1.DataSource = table2;
                    break;
                case "Розклади психологів:":
                    string psy = FiltData.Text;
                    string selectQuery3 = "select Id_Розкладу_психолога,психологи.Прізвище,  Дата, `Початок_ роботи`, Кінець_роботи From розклади_психолога  left join психологи on ID_Психолога2 = психологи.ID_Психолога where психологи.Прізвище = '"+psy+"' ; ";
                    DataTable table3 = new DataTable();
                    MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
                    adapter3.Fill(table3);
                    dataGridView1.DataSource = table3;
                    SelectFirstRow();
                    break;
                case "Сесії:":
                    string cret = FiltData.Text;
                    if (Heeeey.Text == "Психологом")
                    {
                        string selectQuery4 = "select Id_Сесії, психологи.Прізвище AS 'Психолог', клієнти.Прізвище AS 'Клієнт' , Дата, Початок_сесії, Кінець_сесії, Результат From сесії left join психологи on ID_Психолога2 = психологи.ID_Психолога left join клієнти on ID_Клієнта2 = клієнти.ID_Клієнта where психологи.Прізвище = '" + cret + "'; ";
                        DataTable table4 = new DataTable();
                        MySqlDataAdapter adapter4 = new MySqlDataAdapter(selectQuery4, connection);
                        adapter4.Fill(table4);
                        dataGridView1.DataSource = table4;
                        SelectFirstRow();
                    }
                    else
                    {
                        string selectQuery5 = "select Id_Сесії, психологи.Прізвище AS 'Психолог', клієнти.Прізвище AS 'Клієнт' , Дата, Початок_сесії, Кінець_сесії, Результат From сесії left join психологи on ID_Психолога2 = психологи.ID_Психолога left join клієнти on ID_Клієнта2 = клієнти.ID_Клієнта where клієнти.Прізвище = '" + cret+"'; ";
                        DataTable table5 = new DataTable();
                        MySqlDataAdapter adapter5 = new MySqlDataAdapter(selectQuery5, connection);
                        adapter5.Fill(table5);
                        dataGridView1.DataSource = table5;
                        SelectFirstRow();
                    }
                        break;
                case "Поставлені діагнози:":
                    string cl = FiltData.Text;
                    string selectQuery6 = "select Id_Поставленого_діагнозу, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Дата_озвучування, Затвердження_нарадою from поставлені_діагнози left join клієнти  on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби where клієнти.Прізвище = '"+cl+"' ; ";
                    DataTable table6 = new DataTable();
                    MySqlDataAdapter adapter6 = new MySqlDataAdapter(selectQuery6, connection);
                    adapter6.Fill(table6);
                    dataGridView1.DataSource = table6;
                    SelectFirstRow();
                    break;
                case "Динаміки лікування:":
                   string cl1 = FiltData.Text;
                    string selectQuery7 = "   select Id_Динаміки_лікування, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Динаміка, Реакція_клієнта, Дата_Фіксації from  динаміки_лікування left join поставлені_діагнози on Id_Поставленого_діагнозу2 = поставлені_діагнози.Id_Поставленого_діагнозу left join клієнти on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби where  клієнти.Прізвище = '" + cl1 + "'; ";
                    DataTable table7 = new DataTable();
                    MySqlDataAdapter adapter7 = new MySqlDataAdapter(selectQuery7, connection);
                    adapter7.Fill(table7);
                    dataGridView1.DataSource = table7;
                    SelectFirstRow();
                    break;
                
            }
        }

        private void TextSearchBox_TextChanged(object sender, EventArgs e)
        {
            string LabelText = TableLabel.Text;
            switch (LabelText)
            {
                case "Психологи:":
                    string surnameP = TextSearchBox.Text;
                    string q = "SELECT * FROM Психологи WHERE Прізвище  LIKE '%" + surnameP + "%'  ";
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(q, connection);
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    break;
                case "Клієнти:":
                    string surnameC = TextSearchBox.Text;
                    string q1 = "SELECT * FROM Клієнти WHERE Прізвище  LIKE  '%" + surnameC + "%'  ";
                    DataTable table1 = new DataTable();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
                    adapter1.Fill(table1);
                    dataGridView1.DataSource = table1;
                    break;
                case "Хвороби:":
                    string hard = TextSearchBox.Text;
                    string q2 = "SELECT * FROM Хвороби WHERE Назва_хвороби  LIKE '%" + hard + "%' ";
                    DataTable table2 = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(q2, connection);
                    adapter2.Fill(table2);
                    dataGridView1.DataSource = table2;
                    break;
                case "Поставлені діагнози:":
                    string deas = TextSearchBox.Text;
                    string selectQuery6 = "select Id_Поставленого_діагнозу, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Дата_озвучування, Затвердження_нарадою from поставлені_діагнози left join клієнти  on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби WHERE хвороби.Назва_хвороби  LIKE '%" + deas + "%'";
                    DataTable table6 = new DataTable();
                    MySqlDataAdapter adapter6 = new MySqlDataAdapter(selectQuery6, connection);
                    adapter6.Fill(table6);
                    dataGridView1.DataSource = table6;
                    SelectFirstRow();
                    break;
                case "Динаміки лікування:":
                    string deas2 = TextSearchBox.Text;
                    string selectQuery7 = "   select Id_Динаміки_лікування, клієнти.Прізвище AS 'Клієнт' , хвороби.Назва_хвороби AS 'Назва хвороби', Динаміка, Реакція_клієнта, Дата_Фіксації from  динаміки_лікування left join поставлені_діагнози on Id_Поставленого_діагнозу2 = поставлені_діагнози.Id_Поставленого_діагнозу left join клієнти on Id_Клієнта2 = клієнти.Id_Клієнта left join хвороби on Id_Хвороби2 = хвороби.Id_Хвороби WHERE хвороби.Назва_хвороби  LIKE '%" + deas2 + "%'; ";
                    DataTable table7 = new DataTable();
                    MySqlDataAdapter adapter7 = new MySqlDataAdapter(selectQuery7, connection);
                    adapter7.Fill(table7);
                    dataGridView1.DataSource = table7;
                    SelectFirstRow();
                    break;
            }
        }

        private void EditStrip_Click(object sender, EventArgs e)
        {
            var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            int id = int.Parse(activeRow.Cells[0].Value.ToString());
            if (dataGridView1.Rows.Count > 0)
            {
                string LabelText = TableLabel.Text;

                switch (LabelText)
                {
                    case "Психологи:":
                        EditPsycho editPsychoForm = new EditPsycho(психологиTableAdapter, id);
                       
                        editPsychoForm.ShowDialog();
                        populateDGV();
                        IsDirty = true;
                        break;
                    case "Клієнти:":

                        EditClient editClientForm = new EditClient(клієнтиTableAdapter, id);      
                        editClientForm.ShowDialog();
                        populateDGV();
                        IsDirty = true;
                        break;
                    case "Хвороби:":
                        EditDisease editDiseaseForm = new EditDisease(хворобиTableAdapter, id);
                        editDiseaseForm.ShowDialog();
                        populateDGV();
                        IsDirty = true;
                        break;
                    case "Сесії:":
                        EditSession editSessionForm = new EditSession(сесіїTableAdapter, id);
                        editSessionForm.ShowDialog();
                        populateSession();
                        IsDirty = true;
                        break;
                    case "Поставлені діагнози:":
                        EditDiagnoses editDiagnoseForm = new EditDiagnoses(поставлені_діагнозиTableAdapter, id);
                        editDiagnoseForm.ShowDialog();
                        populateDiagnoses();
                        IsDirty = true;
                        break;
                    case "Динаміки лікування:":
                        EditTreatment editTreatmentForm = new EditTreatment(динаміки_лікуванняTableAdapter, id);
                        editTreatmentForm.ShowDialog();
                        populateDynamics();
                        IsDirty = true;
                        break;

                }
            }

        }

        private void ResetButt_Click_1(object sender, EventArgs e)
        {
            ResetCommand();
           
        }

        private void DeleteButt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string LabelText = TableLabel.Text;
                string tableName = "";
                string IdNum = "";
                switch (LabelText)
                {
                    case "Психологи:":
                        tableName = "Психологи";
                        IdNum = "ID_Психолога";
                        break;
                    case "Клієнти:":
                        tableName = "Клієнти";
                        IdNum = "Id_Клієнта";
                        break;
                    case "Хвороби:":
                        tableName = "Хвороби";
                        IdNum = "Id_Хвороби";
                        break;
                    case "Сесії:":
                        tableName = "Сесії";
                        IdNum = "Id_Сесії";
                        break;
                    case "Розклади психологів:":
                        tableName = "розклади_психолога";
                        IdNum = "Id_Розкладу_психолога";
                        break;
                    case "Поставлені діагнози:":
                        tableName = "поставлені_діагнози";
                        IdNum = "Id_Поставленого_діагнозу";
                        break;
                    case "Динаміки лікування:":
                        tableName = "динаміки_лікування";
                        IdNum = "Id_Динаміки_лікування";
                        break;


                }
                var res = MessageBox.Show("Чи насправді Ви хочете видалити данний елемент?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    if (tableName == "Сесії")
                    {
                        //Розклад
                        //психолог
                        var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                       
                        string selectQuery66 = "SELECT ID_Психолога FROM психологи where Прізвище = '"+ activeRow.Cells[1].Value.ToString() + "' LIMIT 1";
                        DataTable table66 = new DataTable();
                       
                        MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery66, connection);
                        adapter.Fill(table66);
                        dataGridView2.DataSource = table66;
                        //find schedule
                        //Get ps Id.
                       
                      
                            int ps;
                            DateTime dateX = (DateTime)activeRow.Cells[3].Value;
                            string date = dateX.ToString("yyyy-MM-dd");
                           // dataGridView2.Rows[0].Selected = true;
                           

                        ps = int.Parse(dataGridView2.Rows[0].Cells[0].Value.ToString());



                        string selectQuery1 = "SELECT * FROM розклади_психолога where ID_Психолога2 = '" + ps + "'and Дата = '" + date + "' LIMIT 1";
                        DataTable table1 = new DataTable();
                        MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection);
                        adapter1.Fill(table1);
                        dataGridView2.DataSource = table1;
                        int sessionId = int.Parse(activeRow.Cells[0].Value.ToString());
                       
                        //delete session shorten schedule.

                        string time1 = activeRow.Cells[4].Value.ToString();
                        string time2 = activeRow.Cells[5].Value.ToString();
                        DateTime prob1 = DateTime.ParseExact(time1, "HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime prob2 = DateTime.ParseExact(time2, "HH:mm:ss", CultureInfo.InvariantCulture);
                        string timeBeg = prob1.ToString("HH:mm:ss");
                        string timeEnd = prob2.ToString("HH:mm:ss");


                        //Shorten
                        string selectQuery2 = @"UPDATE розклади_психолога
                        SET     `Початок_ роботи` = Case 
                        WHEN `Початок_ роботи` = '" + timeBeg + "'  THEN '" + timeEnd + "'  ELSE `Початок_ роботи`  END WHERE   ID_Психолога2 = '" + ps + "'; ";
                        string selectQuery3 = @"UPDATE розклади_психолога 
SET Кінець_роботи = CASE
WHEN Кінець_роботи = '" + timeEnd + "'  THEN '" + timeBeg + "' ELSE Кінець_роботи END WHERE   ID_Психолога2 = '" + ps + "'; ";
                        executeMyQuery(selectQuery2);
                        string selectQuery4 = "SELECT * FROM розклади_психолога where ID_Психолога2 = '" + ps + "'and Дата = '" + date + "' LIMIT 1";
                        DataTable table2 = new DataTable();
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery4, connection);
                        adapter2.Fill(table2);
                        dataGridView2.DataSource = table2;
                        if (dataGridView2.Rows[0].Cells[3].Value.ToString() == dataGridView2.Rows[0].Cells[4].Value.ToString())
                        {

                            string deleteQuery3 = "DELETE FROM розклади_психолога   WHERE ID_Психолога2 = '" + ps + "' and Дата = '" + date + "' LIMIT 1";
                            executeMyQuery(deleteQuery3);
                            populateDGV();
                            IsDirty = true;
                        }
                        else
                        {
                            executeMyQuery(selectQuery3);
                            string selectQuery5 = "SELECT * FROM розклади_психолога where ID_Психолога2 = '" + ps + "'and Дата = '" + date + "' LIMIT 1";
                            DataTable table3 = new DataTable();
                            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery5, connection);
                            adapter3.Fill(table3);
                            dataGridView2.DataSource = table3;
                            if (dataGridView2.Rows[0].Cells[3].Value.ToString() == dataGridView2.Rows[0].Cells[4].Value.ToString())
                            {

                                string deleteQuery3 = "DELETE FROM розклади_психолога   WHERE ID_Психолога2 = '" + ps + "' and Дата = '" + date + "'";
                                executeMyQuery(deleteQuery3);
                                populateDGV();
                                IsDirty = true;
                            }

                        }
                        


                        //bag




                        string deleteQuery4 = "DELETE FROM сесії   WHERE Id_Сесії = '" + sessionId + "'";
                        executeMyQuery(deleteQuery4);
                        populateSession();
                        IsDirty = true;

                    }
                    else if(tableName == "розклади_психолога")
                    {
                        var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                        DateTime dateX = (DateTime)activeRow.Cells[2].Value;
                        string date = dateX.ToString("yyyy-MM-dd HH:mm:ss");
                        string deleteQuery = "DELETE FROM " + tableName + " WHERE " + IdNum + " ='" + int.Parse(activeRow.Cells[0].Value.ToString()) + "' ;" +
                            "Delete from сесії where ID_Психолога2 = (Select ID_Психолога from психологи where Прізвище = '" + (activeRow.Cells[1].Value.ToString()) + "') AND Дата = '"+date +"' ";
                        executeMyQuery(deleteQuery);
                        populateShedule();
                        IsDirty = true;
                    }
                    else
                    {
                        var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                        
                        string deleteQuery = "DELETE FROM " + tableName + " WHERE " + IdNum + " ='" + int.Parse(activeRow.Cells[0].Value.ToString()) + "'    ";
                        executeMyQuery(deleteQuery);
                        ResetCommand();
                        IsDirty = true;
                    }
                  
                  

                }
            }
        }

        private void AddButt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                string LabelText = TableLabel.Text;

                switch (LabelText)
                {
                    case "Психологи:":
                        EditPsycho editPsychoForm = new EditPsycho();
                        editPsychoForm.ShowDialog();
                        populateDGV();
                        IsDirty = true;
                        break;
                    case "Клієнти:":
                        EditClient editClientForm = new EditClient();
                        editClientForm.ShowDialog();
                        populateDGV();
                        IsDirty = true;
                        break;
                    case "Хвороби:":
                        EditDisease editDiseaseForm = new EditDisease();
                        editDiseaseForm.ShowDialog();
                        populateDGV();
                        IsDirty = true;
                        break;
                    case "Сесії:":
                        EditSession editSessionForm = new EditSession();
                        editSessionForm.ShowDialog();
                        populateSession();
                        IsDirty = true;
                        break;
                    case "Поставлені діагнози:":
                        EditDiagnoses editDiagnoseForm = new EditDiagnoses();
                        editDiagnoseForm.ShowDialog();
                        populateDiagnoses();
                        IsDirty = true;
                        break;
                    case "Динаміки лікування:":
                        EditTreatment editTreatmentForm = new EditTreatment();
                        editTreatmentForm.ShowDialog();
                        populateDynamics();
                        IsDirty = true;
                        break;
                }
            }
        }

        private void ResetCommand()
        {
            if (TableLabel.Text == "Розклади психологів:")
            {
                populateShedule();
            }
            else if (TableLabel.Text == "Сесії:")
            {

                populateSession();
            }
            else if (TableLabel.Text == "Поставлені діагнози:")
            {
                populateDiagnoses();
            }
            else if (TableLabel.Text == "Динаміки лікування:")
            {
                populateDynamics();
            }
            else
            {
                populateDGV();
            }
        }

        private void Heeeey_SelectedItemChanged(object sender, EventArgs e)
        {
            
            if (Heeeey.Text == "Психологом")
            {
                FiltData.Items.Clear();
                string selectQuery2 = "SELECT Прізвище FROM психологи WHERE ID_Психолога IN (SELECT ID_Психолога2 FROM Сесії)";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery2, connection);
                adapter2.Fill(table2);
                dataGridView2.DataSource = table2;
                List<string> filtData5 = new List<string> { };
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    filtData5.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
                FiltData.Items.Clear();
                FiltLabel.Text = "Психологом";
                FiltData.Items.AddRange(filtData5);
                FiltData.Text = "Оберіть психолога";
                FiltPanel.Show();
            }
            else
            {
                FiltData.Items.Clear();
                string selectQuery2 = "SELECT Прізвище FROM клієнти WHERE Id_Клієнта IN (SELECT Id_Клієнта FROM Сесії)";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery2, connection);
                adapter2.Fill(table2);
                dataGridView2.DataSource = table2;
                List<string> filtData5 = new List<string> { };
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    filtData5.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                }
                FiltData.Items.Clear();
                FiltLabel.Text = "Психологом";
                FiltData.Text = "Оберіть клієнта";
                FiltData.Items.AddRange(filtData5);
                FiltPanel.Show();
            }
        }

        private void TextSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void FindDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (FindDateTimePicker.Value > DateTime.Now || FindDateTimePicker.Value < DateTime.Now.AddYears(-25) )
            {
                FindDateTimePicker.Value = DateTime.Now;
                
            }
            else
            {
                string LabelText = TableLabel.Text;
                switch (LabelText)
                {
                    case "Розклади психологів:":
                        string date = FindDateTimePicker.Value.ToString("yyyy-MM-dd");
                        string selectQuery3 = "select Id_Розкладу_психолога,психологи.Прізвище,  Дата, `Початок_ роботи`, Кінець_роботи From розклади_психолога  left join психологи on ID_Психолога2 = психологи.ID_Психолога where Дата = '" + date + "' ; ";
                        DataTable table3 = new DataTable();
                        MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
                        adapter3.Fill(table3);
                        dataGridView1.DataSource = table3;
                        SelectFirstRow();
                        break;
                    case "Сесії:":
                        string date2 = FindDateTimePicker.Value.ToString("yyyy-MM-dd");
                        string selectQuery12 = "select Id_Сесії, психологи.Прізвище AS 'Психолог', клієнти.Прізвище AS 'Клієнт' , Дата, Початок_сесії, Кінець_сесії, Результат From сесії left join психологи on ID_Психолога2 = психологи.ID_Психолога left join клієнти on ID_Клієнта2 = клієнти.ID_Клієнта where Дата = '" + date2 + "' ; ";
                        DataTable table12 = new DataTable();
                        MySqlDataAdapter adapter12 = new MySqlDataAdapter(selectQuery12, connection);
                        adapter12.Fill(table12);
                        dataGridView1.DataSource = table12;
                        SelectFirstRow();
                        break;
                }
            }
        }
    }
}
