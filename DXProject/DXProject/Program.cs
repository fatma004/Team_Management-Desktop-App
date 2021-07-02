using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DXProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<Employee> systemEmployees = new List<Employee>();
        public static List<Team> Teams = new List<Team>();
        public static List<User> SystemUsers = new List<User>();
        [STAThread]
        static void Main()
        {
            SystemUsers.Add(new User("Admin", "1234"));
            SystemUsers.Add(new User("noor", "noor"));
            SystemUsers.Add(new User("nawal", "nawal"));
            SystemUsers.Add(new User("nada", "nada"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTask());
        }
    }
}
