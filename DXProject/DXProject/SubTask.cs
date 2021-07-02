using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXProject
{
    public enum Status
    {
        NotAssigned = 1,
        Running = 2,
        Done = 4
    }
    class SubTask
    {
        int id;
        public int ID
        {
            get { return id; }
        }
        public string Name;
        public string Description;
        public Employee Employee;
        public DateTime DeadLine;
        public Status Status = Status.NotAssigned;
        public static int CurID;
        public SubTask()
        {
            id = ++CurID;
        }
        public SubTask(SubTask t)
        {
            id = t.id;
            Name = t.Name;
            Description = t.Description;
            Employee = t.Employee;
            DeadLine = t.DeadLine;
            Status = t.Status;

        }
        public SubTask(string name, string Desc)
        {
            id = ++CurID;
            Name = name;
            Description = Desc;
        }
        public SubTask(string name, string Desc, Employee Emp, DateTime deadLin, Status stat)
        {
            id = ++CurID;
            Name = name;
            Description = Desc;
            Employee = Emp;
            DeadLine = deadLin;
            Status = stat;
        }
    }
}
