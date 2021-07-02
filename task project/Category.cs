using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_project
{
    class Category
    {
        int id;
        public int ID
        {
            get { return id; }
        }
        public CategoryTitle Title;
        public string Description="";
        public List<Task> CategoryTasks;
        public static int CurID;

        public Category()
        {
            id = ++CurID;
            CategoryTasks = new List<Task>();
        }
        public Category(Category c)
        {
            id = c.id;
            Title = c.Title;
            Description = c.Description;
            CategoryTasks = c.CategoryTasks;
        }
        public Category(CategoryTitle CategTitle)
        {
            id = ++CurID;
            Title = CategTitle;
            CategoryTasks = new List<Task>();
        }
        public Category(CategoryTitle CategTitle,string Desc)
        {
            id = ++CurID;
            Title = CategTitle;
            Description = Desc;
            CategoryTasks = new List<Task>();
        }

        public Category(CategoryTitle CategTitle, string Desc, List<Task> ListOfTasks)
        {
            id = ++CurID;
            Description = Desc;
            Title = CategTitle;
            CategoryTasks = ListOfTasks;

        }
    }

}
