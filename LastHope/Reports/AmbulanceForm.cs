using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastHope
{
    public partial class AmbulanceForm : Form
    {
        public AmbulanceForm()
        {
            InitializeComponent();
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
                    // MessageBox.Show("Query Executed");
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

        //SQL-end
        private void AmbulanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.new_view' table. You can move, or remove it, as needed.
            this.new_viewTableAdapter.Fill(this.mydbDataSet.new_view);

            this.reportViewer1.RefreshReport();
        }

        private void PrintButt_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }

        private void ExportToPDF()
        {
            string deciveInfo = "";
            string[] streamIds;
            Warning[] warnings;

            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;

            ReportViewer viewer = new ReportViewer();
            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = @"D:\Настя\Last-Hope\LastHope\Report1.rdlc";
            MySqlDataAdapter temp = new MySqlDataAdapter(@"SELECT `mydb`.`клієнти`.`Прізвище` AS `Прізвище`,
                `mydb`.`клієнти`.`Ім_я` AS `Ім_я`,
                `mydb`.`клієнти`.`По_батькові` AS `По_батькові`,
                `mydb`.`клієнти`.`Дата_народження` AS `Дата_Народження`,
                `mydb`.`клієнти`.`Стать` AS `Стать`,
                `mydb`.`клієнти`.`Телефон` AS `Телефон`,
                `mydb`.`клієнти`.`Пошта` AS `Пошта`,
                `mydb`.`поставлені_діагнози`.`Дата_озвучування` AS `Дата_озвучування`,
                `mydb`.`хвороби`.`Назва_хвороби` AS `Назва_хвороби`,
                `mydb`.`хвороби`.`Тяжкість_лікування` AS `Тяжкість_лікування`

    FROM
        ((`mydb`.`клієнти`

        JOIN `mydb`.`поставлені_діагнози` ON((`mydb`.`поставлені_діагнози`.`Id_Клієнта2` = `mydb`.`клієнти`.`Id_Клієнта`)))
                JOIN `mydb`.`хвороби` ON((`mydb`.`хвороби`.`Id_Хвороби` = `mydb`.`поставлені_діагнози`.`Id_Хвороби2`)))
            Order by `mydb`.`клієнти`.`Id_Клієнта`", connection);
                    DataTable dt = new DataTable();
            temp.Fill(dt);
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            viewer.RefreshReport();
            var bytes = viewer.LocalReport.Render("PDF", deciveInfo, out mimeType, out encoding, out extension,
                out streamIds, out warnings);
            string fileName = @"D:\Настя\report1.pdf";
            File.WriteAllBytes(fileName, bytes);
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
