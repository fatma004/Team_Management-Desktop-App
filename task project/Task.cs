using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_project
{

    class Task
    {
        int id;
        public int ID
        {
            get { return id; }
        }
        public string Name;
        public string Description;
        public DateTime DeadLine;

        public List<SubTask> SubTasks;
        public List<Employee> Employees;
        public List<string> FilesPathes;

        public Status Status = Status.NotAssigned;
        public bool IsArchived;
       
        public static int CurID;

        public Task(Task t)
        {
            Name = t.Name;
            Description = t.Description;
            id = t.id;
            SubTasks = t.SubTasks;
            Employees = t.Employees;
            DeadLine = t.DeadLine;
            Status = t.Status;
            FilesPathes = t.FilesPathes;
            IsArchived = t.IsArchived;
        }
        public Task()
        {
            id = CurID++;
            SubTasks = new List<SubTask>();
            Employees = new List<Employee>();
            FilesPathes = new List<string>();
        }

        public Task(string name, string Desc)
        {
            Name = name;
            Description = Desc;
            id = CurID++;
            SubTasks = new List<SubTask>();
            Employees = new List<Employee>();
            FilesPathes = new List<string>();
        }
        public Task(string name, string Desc, List<SubTask> ListOfsubTasks, List<Employee> Emps, DateTime DT, Status S,List<string>FPths,bool isArchvd)
        {
            Name = name;
            Description = Desc;
            id = CurID++;
            SubTasks = ListOfsubTasks;
            Employees = Emps;
            DeadLine = DT;
            Status = S;
             FilesPathes = FPths;
            IsArchived = isArchvd;
        }
    }
}
