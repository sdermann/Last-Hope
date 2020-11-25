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
    public partial class Step1 : Form
    {
        public int result = 0;
        public int butt = 0;
       
       
        public Step1()
        {
            InitializeComponent();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            butt = 0;
            result = 0;
            //1
            if(radioButton1.Checked == true)
            {
                result += 3;
                butt++;
                
            }
            else if(radioButton2.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if(radioButton3.Checked == true)
            {
                result += 4;
                butt++;
            }
            //2
            if (radioButton20.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton21.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton19.Checked == true)
            {
                result += 4;
                butt++;
            }
            //3
            if (radioButton5.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton6.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton4.Checked == true)
            {
                result += 4;
                butt++;
            }
            //4      
            if(radioButton17.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton18.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton16.Checked == true)
            {
                result += 4;
                butt++;
            }
            //5
            if (radioButton8.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton9.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton7.Checked == true)
            {
                result += 4;
                butt++;
            }
            //6
            if (radioButton14.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton15.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton13.Checked == true)
            {
                result += 4;
                butt++;
            }
            //7
            if (radioButton11.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton12.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton10.Checked == true)
            {
                result += 4;
                butt++;
            }
            //8
            if (radioButton23.Checked == true)
            {
                result += 3;
                butt++;

            }
            else if (radioButton24.Checked == true)
            {
                result += 5;
                butt++;
            }
            else if (radioButton22.Checked == true)
            {
                result += 4;
                butt++;
            }

        }
    }
}
