using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastHope
{
    public partial class MainForm : Form
    {
        //flag
       // bool IsDirty = false;
        public MainForm()
        {
            InitializeComponent();
            //HidePanels
            SortPanel.Hide();
            FiltPanel.Hide();
            SearchPanel.Hide();
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


       private void SelectFirstRow()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: add the rest
            психологиTableAdapter.Update(mydbDataSet);
        }

    

        private void психологиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = психологиBindingSource;
            dataGridView1.DataSource = психологиBindingSource;
            TableLabel.Text = "Психологи:";
            SelectFirstRow();
        }

        private void розкладиПсихологівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = розкладипсихологаBindingSource;
            dataGridView1.DataSource = розкладипсихологаBindingSource;
            TableLabel.Text = "Розклади психологів:";
            SelectFirstRow();
        }

        private void клієнтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = клієнтиBindingSource;
            dataGridView1.DataSource = клієнтиBindingSource;
            TableLabel.Text = "Клієнти:";
            SelectFirstRow();
        }

        private void сесіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = сесіїBindingSource;
            dataGridView1.DataSource = сесіїBindingSource;
            TableLabel.Text = "Сесії:";
            SelectFirstRow();
        }

        private void поставленіДіагнозиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = поставленідіагнозиBindingSource;
            dataGridView1.DataSource = поставленідіагнозиBindingSource;
            TableLabel.Text = "Поставлені діагнози:";
            SelectFirstRow();
        }

        private void динамікиЛікуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = динамікилікуванняBindingSource;
            dataGridView1.DataSource = динамікилікуванняBindingSource;
            TableLabel.Text = "Динаміки лікування:";
            SelectFirstRow();
        }

        private void хворобиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = хворобиBindingSource;
            dataGridView1.DataSource = хворобиBindingSource;
            TableLabel.Text = "Хвороби:";
            SelectFirstRow();
        }

        private void TableLabel_TextChanged(object sender, EventArgs e)
        {
            //Filling panels.
            string  LabelText = TableLabel.Text;
          
            switch (LabelText)
            {
                case "Психологи:":
                    //Sort.
                    List<string> sortData1 = new List<string> { "ID","Віком"};
                    SortData.Items.Clear();
                    SortData.Items.AddRange(sortData1);
                    SortData.Text = "ID";
                    SortPanel.Show();
                    //Filt.
                    List<string> filtData1 = new List<string> { "жіноча", "чоловіча", "трансгендер" };
                    FiltLabel.Text = "Cтаттю";
                    FiltData.Items.Clear();
                    FiltData.Items.AddRange(filtData1);
                    FiltData.Text = "жіноча";
                    FiltPanel.Show();
                    //Search.
                    SearchLabel.Text = "За прізвищем:";
                    SearchPanel.Show();

                    break;
                case "Клієнти:":
                    //Sort.
                    List<string> sortData2 = new List<string> { "ID", "Віком" };
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

                    break;
                case "Хвороби:":
                    //Sort.
                    List<string> sortData3 = new List<string> { "ID", "Назвою" };
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
                    break;
            }
        }
    }
}
