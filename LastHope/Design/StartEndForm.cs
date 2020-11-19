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
    public partial class StartEndForm : Form
    {
        public StartEndForm()
        {
            InitializeComponent();
        }

        private void StartEndForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DateLabel.Text = DateTime.Now.ToShortDateString() ;
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
