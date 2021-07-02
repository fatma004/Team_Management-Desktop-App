using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static List<Employee> SystemEmployees = new List<Employee>();
        public static List<Team> Teams = new List<Team>();
        public static List<User> SystemUsers = new List<User>();
        [STAThread]
        static void Main()
        {
            SystemUsers.Add(new User("Admin", "1234"));
            SystemUsers.Add(new User("noor", "noor"));
            SystemUsers.Add(new User("nawal", "nawal"));
            SystemUsers.Add(new User("nada", "nada"));

            SystemEmployees.Add(new Employee("esraa"));
            SystemEmployees.Add(new Employee("zahraa")) ;

            Teams.Add( new Team("first team", "desc of first team"));

            Teams[0].TeamCategories.Add(new Category(CategoryTitle.HR));
            Teams[0].TeamCategories.Add( new Category(CategoryTitle.Design));

            Teams[0].TeamCategories[0].CategoryTasks.Add( new Task("hr-task1", "desc of task1",
                                                                    new List<SubTask>() { new SubTask("subTask1", "desc of subtask",new Employee("noor"), DateTime.Now, Status.Running) },
                                                                    new List<Employee>() { new Employee("noor") },
                                                                     DateTime.Now,
                                                                     Status.Running,
                                                                     new List<string>() { "C///:hhh/hhh/nnn/mm.jpg" },
                                                                     false));
            Teams[0].TeamCategories[0].CategoryTasks.Add(new Task("hr-task2", "desc of task2",
                                                                    new List<SubTask>() { new SubTask("subTask2", "desc of subtask2", new Employee("noor"),DateTime.Now,Status.Running) },
                                                                   new List<Employee>() { new Employee("noor2") },
                                                                    DateTime.Now,
                                                                    Status.Running,
                                                                    new List<string>() { "C///:hhh/hhh/nnn/mm2.jpg" },
                                                                    false));
            Teams[0].TeamCategories[1].CategoryTasks.Add(new Task("Des-task1", "desc of task2",
                                                                  new List<SubTask>() { new SubTask("subTask1", "desc of subtask2", new Employee("noor"), DateTime.Now, Status.Running) },
                                                                 new List<Employee>() { new Employee("noor2") },
                                                                  DateTime.Now,
                                                                  Status.Running,
                                                                  new List<string>() { "C///:hhh/hhh/nnn/mm2.jpg" },
                                                                  false));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStart());
          




        }    
    }
}
