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
        public EditPsycho()
        {
            InitializeComponent();
        }

        private void психологиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.психологиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void сесіїBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сесіїBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void розклади_психологаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void психологиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.психологиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }

        private void EditPsycho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.сесії' table. You can move, or remove it, as needed.
            this.сесіїTableAdapter.Fill(this.mydbDataSet.сесії);
            // TODO: This line of code loads data into the 'mydbDataSet.психологи' table. You can move, or remove it, as needed.
            this.психологиTableAdapter.Fill(this.mydbDataSet.психологи);

        }
    }
}
