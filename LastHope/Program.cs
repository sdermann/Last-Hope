using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastHope.AutoClient;
using MySql.Data.MySqlClient; 

namespace LastHope
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string connStr = "server=localhost;user=Sdermann;database=mydb;password=896520;";
            //MySqlConnection conn = new MySqlConnection(connStr);
            //conn.Open();
            //string sql = "SELECT Прізвище FROM Психологи WHERE ID_Психолога = 2";
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //string name = command.ExecuteScalar().ToString();
            //Console.WriteLine(name);
            //conn.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new NewSessionNewClient());
            Application.Run(new AppForm());
        }
    }
}
