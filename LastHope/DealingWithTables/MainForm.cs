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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'mydbDataSet.психологи' table. You can move, or remove it, as needed.
            this.психологиTableAdapter.Fill(this.mydbDataSet.психологи);
            dataGridView1.AutoGenerateColumns = true;


        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            психологиTableAdapter.Update(mydbDataSet);
        }

    

        private void психологиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = психологиBindingSource;
            dataGridView1.DataSource = психологиBindingSource;
            label1.Text = "Психологи";
        }

       
    }
}
