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
    public partial class TreatmentForm : Form
    {
        public TreatmentForm()
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
        private void TreatmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.new_view2' table. You can move, or remove it, as needed.
            this.new_view2TableAdapter.Fill(this.mydbDataSet.new_view2);

            this.reportViewer1.RefreshReport();


            string selectQuery3 = "select Прізвище, Ім_я, По_батькові From клієнти where  Id_Клієнта in (Select Id_Клієнта2 From сесії) ";
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(selectQuery3, connection);
            adapter3.Fill(table3);
            dataGridView1.DataSource = table3;
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
            viewer.LocalReport.ReportPath = @"D:\Настя\Last-Hope\LastHope\Report2.rdlc";
            MySqlDataAdapter temp = new MySqlDataAdapter(@" SELECT 
        `mydb`.`клієнти`.`Id_Клієнта` AS `Id_Клієнта`,
        `mydb`.`клієнти`.`Прізвище` AS `Прізвище`,
        `mydb`.`поставлені_діагнози`.`Дата_озвучування` AS `Дата_озвучування`,
        `mydb`.`хвороби`.`Назва_хвороби` AS `Назва_хвороби`,
        `mydb`.`хвороби`.`Тяжкість_лікування` AS `Тяжкість_лікування`,
        `mydb`.`сесії`.`Дата` AS `Дата_сесії`,
        `mydb`.`сесії`.`Результат` AS `Результат_сесії`
    FROM
        (((`mydb`.`клієнти`
        left JOIN `mydb`.`поставлені_діагнози` ON ((`mydb`.`поставлені_діагнози`.`Id_Клієнта2` = `mydb`.`клієнти`.`Id_Клієнта`)))
        leftJOIN `mydb`.`хвороби` ON ((`mydb`.`хвороби`.`Id_Хвороби` = `mydb`.`поставлені_діагнози`.`Id_Хвороби2`)))
        left JOIN `mydb`.`сесії` ON ((`mydb`.`сесії`.`ID_Клієнта2` = `mydb`.`клієнти`.`Id_Клієнта`)))
    WHERE
        (`mydb`.`сесії`.`Результат` != 'Запланована')
    Order BY `mydb`.`клієнти`.`Id_Клієнта`", connection);
            DataTable dt = new DataTable();
            temp.Fill(dt);
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            viewer.RefreshReport();
            var bytes = viewer.LocalReport.Render("PDF", deciveInfo, out mimeType, out encoding, out extension,
                out streamIds, out warnings);
            string fileName = @"D:\Настя\report2.pdf";
            File.WriteAllBytes(fileName, bytes);
            System.Diagnostics.Process.Start(fileName);
        }

        private void TextSearchBox_TextChanged(object sender, EventArgs e)
        {
            string surnameC = TextSearchBox.Text;
            string q1 = "SELECT Прізвище, Ім_я, По_батькові From клієнти where  Id_Клієнта in (Select Id_Клієнта2 From сесії) AND Прізвище  LIKE  '%" + surnameC + "%'  ";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView1.DataSource = table1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deciveInfo = "";
            string[] streamIds;
            Warning[] warnings;

            string surname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            string q1 = "SELECT Id_Клієнта FROM Клієнти WHERE Прізвище  =  '" + surname + "'  ";
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(q1, connection);
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1;
            int id = int.Parse(dataGridView2.Rows[0].Cells[0].Value.ToString());
            ReportViewer viewer = new ReportViewer();
            viewer.ProcessingMode = ProcessingMode.Local;
            viewer.LocalReport.ReportPath = @"D:\Настя\Last-Hope\LastHope\Report2.rdlc";
            MySqlDataAdapter temp = new MySqlDataAdapter(@" SELECT 
        `mydb`.`клієнти`.`Id_Клієнта` AS `Id_Клієнта`,
        `mydb`.`клієнти`.`Прізвище` AS `Прізвище`,
        `mydb`.`поставлені_діагнози`.`Дата_озвучування` AS `Дата_озвучування`,
        `mydb`.`хвороби`.`Назва_хвороби` AS `Назва_хвороби`,
        `mydb`.`хвороби`.`Тяжкість_лікування` AS `Тяжкість_лікування`,
        `mydb`.`сесії`.`Дата` AS `Дата_сесії`,
        `mydb`.`сесії`.`Результат` AS `Результат_сесії`
    FROM
        (((`mydb`.`клієнти`
        left JOIN `mydb`.`поставлені_діагнози` ON ((`mydb`.`поставлені_діагнози`.`Id_Клієнта2` = `mydb`.`клієнти`.`Id_Клієнта`)))
        left JOIN `mydb`.`хвороби` ON ((`mydb`.`хвороби`.`Id_Хвороби` = `mydb`.`поставлені_діагнози`.`Id_Хвороби2`)))
        left JOIN `mydb`.`сесії` ON ((`mydb`.`сесії`.`ID_Клієнта2` = `mydb`.`клієнти`.`Id_Клієнта`)))
    WHERE
        (`mydb`.`сесії`.`Результат` != 'Запланована' AND `mydb`.`клієнти`.`Id_Клієнта` = '"+id+"') Order BY `mydb`.`клієнти`.`Id_Клієнта`", connection);
            DataTable dt = new DataTable();
            temp.Fill(dt);
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            viewer.RefreshReport();
            var bytes = viewer.LocalReport.Render("PDF", deciveInfo, out mimeType, out encoding, out extension,
                out streamIds, out warnings);
            string fileName = @"D:\Настя\report2.pdf";
            File.WriteAllBytes(fileName, bytes);
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
