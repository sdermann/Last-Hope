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
    public partial class NewClientForm : Form
    {

        int count;
        Label Label;
        public NewClientForm(Label label)
        {
            InitializeComponent();
            Label = label;
        }

        
        //Add child form
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            //ChildForm.Dock = DockStyle.Fill;
            TestPanel.Controls.Add(ChildForm);
            TestPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
        Step1 test = null;
        Invite invite = null;
        private void NewClientForm_Load(object sender, EventArgs e)
        {
            test = new Step1();
            OpenChildForm(test);
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            if(count %2 == 0)
            {
                test.label8.Text = "get result!";
                count++;
            }
            else
            {
                test.label8.Text = "get!";
                count++;
            }
            
            if (test.butt != 8)
            {
                MessageBox.Show("Перевірте, чи не пропустили ви якесь запитання!\nДякуємо :)");
            }
            else
            {
                if(test.result <= 28)
                {
                    MessageBox.Show("Низький рівень стресу. Можна сказати, що останнім часом Ви\nне відчуваєте надмірне хвилювання і тривогу. Швидше за все,\nВаше життя здається Вам передбачуваним і відносно стабільним.\nЦе такий Лайт-стресовий режим, коли Ви не потрапляєте в ситуації,\n в яких Вам необхідно діяти неординарно, акумулюючи\n для цього внутрішні ресурси.");
                    test = new Step1();
                    OpenChildForm(test);
                }
                else if(test.result <= 33)
                {
                    MessageBox.Show("Середній рівень стресу. Можна сказати, що Ви в прекрасній \n«бойовий» формі, можете проявляти активність, ефективно діяти в \nнестандартних ситуаціях. І взагалі, творити й 'витворяти', у Вас \nдосить для цього життєвої енергії і сил!");
                    test = new Step1();
                    OpenChildForm(test);
                }
                else if(test.result <= 38)
                {
                    MessageBox.Show("Високий рівень стресу. Напевно, Вам довелося зіткнутися \nз труднощами, які Вас порядком виснажили. Ви турбуєтеся за своє \nмайбутнє і деякі події, які насправді можуть розгорнутися і в позитивну сторону. \nНасправді Ви відчуваєте легку депресію і Вам треба трохи відпочити і менше турбуватися. Постарайтеся\n створити для себе такі умови, і Ви швидко прийдете в норму.");
                    test = new Step1();
                    OpenChildForm(test);
                    invite = new Invite();
                    invite.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Ваш стан повинен викликати не просто занепокоєння, \nВам необхідно звернутися до фахівця, оскільки частий\nабо постійний прояв подібних симптомів, може означати прояву \nдепресії.");
                    test = new Step1();
                    OpenChildForm(test);
                    invite = new Invite();
                    invite.ShowDialog();
                }


            }

            // Last form
            if (invite != null && invite.flag == true)
            {
                this.Close();
                Label.Text = "kak dela";
            }  
        }
    }
}
