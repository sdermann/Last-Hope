using LastHope.mydbDataSetTableAdapters;
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
    public partial class DeleteForm : Form
    {
        //TODO: Other TableAdapters
        психологиTableAdapter ПсихологиTableAdapter;
        //розклади_психологаTableAdapter Розклади_ПсихологаTableAdapter;
       // сесіїTableAdapter СесіїTableAdapter;
        клієнтиTableAdapter КлієнтиTableAdapter;
        //поставлені_діагнозиTableAdapter Поставлені_ДіагнозиTableAdapter;
        //динаміки_лікуванняTableAdapter Динаміки_ЛікуванняTableAdapter;
        хворобиTableAdapter ХворобиTableAdapter;
        int id;
     
        public DeleteForm()
        {
            InitializeComponent();
        }

        public DeleteForm(Object AnyTableAdapter,int Id)
        {
            InitializeComponent();
            string LabelText = TableLabel.Text;
            switch (LabelText)
            {
                case "Психологи:":
                    this.ПсихологиTableAdapter = (психологиTableAdapter)AnyTableAdapter;

                    break;
                case "Клієнти:":
                    this.КлієнтиTableAdapter = (клієнтиTableAdapter)AnyTableAdapter;

                    break;
                case "Хвороби:":
                    this.ХворобиTableAdapter = (хворобиTableAdapter)AnyTableAdapter;
                    break;
            }
            this.id = Id;

        }
        private void NoButtButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesButt_Click(object sender, EventArgs e)
        {
            string LabelText = TableLabel.Text;
            switch (LabelText)
            {
                case "Психологи:":

                    //  patientTableAdapter.DeletePatient(id);
                   // ПсихологиTableAdapter.Delete(id);

                    break;
                case "Клієнти:":
                    //КлієнтиTableAdapter.Delete(id);

                    break;
                case "Хвороби:":
                    //ХворобиTableAdapter.Delete(id);
                    break;
            }
            this.Close();
        }
    }
}
