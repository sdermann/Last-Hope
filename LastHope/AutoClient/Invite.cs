using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastHope.AutoClient
{
    public partial class Invite : Form
    {
        public bool flag = false;
        public Invite()
        {
            InitializeComponent();
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            flag = true;
        }
    }
}
