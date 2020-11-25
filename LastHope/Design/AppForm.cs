using LastHope.AutoClient;
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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            CustomizeDesign();
            OpenChildForm(new StartEndForm());
        }

        private void CustomizeDesign()
        {
            ReportsPanel.Visible = false;
            StatisticsPanel.Visible = false;
        }

        private void HideSubMenus()
        {
            if(ReportsPanel.Visible == true)
            {
                ReportsPanel.Visible = false;
            }
            if (StatisticsPanel.Visible == true)
            {
                StatisticsPanel.Visible = false;
            }
        }

        private void ShowSubMenus(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                HideSubMenus();
                SubMenu.Visible = true; 
            }
            else
            {
                SubMenu.Visible = false;
            }

        }
        //Reports start
        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenus(ReportsPanel);
        }

        private void AmbulanceButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AmbulanceForm());
            HideSubMenus();
        }

        private void TreatmentButton_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            OpenChildForm(new TreatmentForm());
        }


        //Reports end
        private void StatisticsName_Click(object sender, EventArgs e)
        {
            ShowSubMenus(StatisticsPanel);
        }

        //Statistics start
        private void RiskButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RiskForm());
            HideSubMenus();
        }

        private void FrequencyButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrequencyForm());
            HideSubMenus();
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AttendanceForm());
            HideSubMenus();
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AverageForm());
            HideSubMenus();
        }
        //Statistics end

        //Add child form
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(ChildForm);
            ChildFormPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MainForm());
        }

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm(label2);
            OpenChildForm(newClientForm);
        }

        private void SQLButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SQLForm());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StartEndForm());
            var res = MessageBox.Show("Чи насправді Ви хочете покинути додаток?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            OpenChildForm(new NewSessionNewClient());
        }
    }
}

