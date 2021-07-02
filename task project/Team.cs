using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_project
{
    class Team
    {
        int id;
        public int ID
        {
            get { return id; }
        }
        public string Name;
        public string Description;
        public List<Employee> TeamEmployees;
        public List<Category> TeamCategories;
        public static int CurID;

       public Team ShallowCopy(Team toCopy)
        {
            return (Team) toCopy.MemberwiseClone();
            /*
                id = toCopy.id;
                Name= toCopy.Name;
                Description = toCopy.Description;
                TeamEmployees = toCopy.TeamEmployees;
                */
        }
        public Team()
        {
            id = ++CurID;
            TeamEmployees = new List<Employee>();
            TeamCategories = new List<Category>();
        }
        public Team(string name, string Desc)
        {
            id = ++CurID;
            Name = name;
            Description = Desc;
            TeamEmployees = new List<Employee>();
            TeamCategories = new List<Category>();
        }
        public Team(string name, string Desc, List<Employee> Emps, List<Category> categs)
        {
            id = ++CurID;
            Name = name;
            Description = Desc;
            TeamEmployees = Emps;
            TeamCategories = categs;
        }

    }
}
