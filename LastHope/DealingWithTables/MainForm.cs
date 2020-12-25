using LastHope.DealingWithTables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            bindingNavigator1.BindingSource = розкладипсихологаBindingSource;
            dataGridView1.DataSource = розкладипсихологаBindingSource;
            TableLabel.Text = "Розклади психологів:";
            //populateDGV();
            SelectFirstRow();
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
            bindingNavigator1.BindingSource = сесіїBindingSource;
            dataGridView1.DataSource = сесіїBindingSource;
            TableLabel.Text = "Сесії:";
            populateDGV();
            SelectFirstRow();
        }

        private void поставленіДіагнозиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = поставленідіагнозиBindingSource;
            dataGridView1.DataSource = поставленідіагнозиBindingSource;
            TableLabel.Text = "Поставлені діагнози:";
           // populateDGV();
            SelectFirstRow();
        }

        private void динамікиЛікуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = динамікилікуванняBindingSource;
            dataGridView1.DataSource = динамікилікуванняBindingSource;
            TableLabel.Text = "Динаміки лікування:";
            //populateDGV();
            SelectFirstRow();
        }

        private void хворобиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = хворобиBindingSource;
            dataGridView1.DataSource = хворобиBindingSource;
            TableLabel.Text = "Хвороби:";
            //populateDGV();
            SelectFirstRow();
        }

        //TODO : Clients Labels
        private void TableLabel_TextChanged(object sender, EventArgs e)
        {
            //Filling panels.
            string LabelText = TableLabel.Text;

            switch (LabelText)
            {
                case "Психологи:":
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
                    //Sort.
                    List<string> sortData2 = new List<string> { "ID", "Прізвищем", "Ім'ям", "По-батькові", "Віком", "Статтю", "Телефоном", "Поштою" };
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData2);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    List<string> filtData2 = new List<string> { "жіноча", "чоловіча", "трансгендер" };
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
                    //Sort.
                    List<string> sortData5 = new List<string> { "ID", "Психологом","Клієнтом", "Датою", "Початком роботи", "Кінцем роботи", "Результатом" };
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData5);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    string tablen2 = TableLabel.Text.Substring(0, TableLabel.Text.Length - 1);
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
                    //Search.
                    SearchLabel.Text = "За датою:";
                    SearchPanel.Show();
                    ResetButt.Show();
                    break;
                case "Поставлені діагнози:":
                    //Sort.
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
                    //Sort.
                    List<string> sortData7 = new List<string> { "ID", "Діагнозом","Динамікою","Реакцією"};
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
            }
        }




        //TODO:Edit

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
                }
            }

        }


        private void ResetButt_Click_1(object sender, EventArgs e)
        {
            populateDGV();
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
                }
                var res = MessageBox.Show("Чи насправді Ви хочете видалити данний елемент?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    var activeRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                    string deleteQuery = "DELETE FROM " + tableName + " WHERE " + IdNum + " ='" + int.Parse(activeRow.Cells[0].Value.ToString()) + "'    ";
                    executeMyQuery(deleteQuery);
                    populateDGV();
                    IsDirty = true;

                }
                else
                {
                    //
                }

            }

        }
        //TODO: new Item
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
                }
            }
        }
    }
}
