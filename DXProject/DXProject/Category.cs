using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXProject
{
    public enum CategoryTitle
    {
        HR = 1,
        Developing = 2,
        Design = 4,
        PR = 8,
        Management = 16,
        Finance = 32
    }
    class CategoryData
    {
        public static List<Category> Category_data_list = new List<Category>();
    }
    class Category
    {

        int id;
        public int ID
        {
            get { return id; }
        }
        public CategoryTitle Title;
        public List<Task> CategoryTasks;
        public string Description;
        public static int CurID;

        public Category()
        {
            id = ++CurID;
            CategoryTasks = new List<Task>();
        }

        public Category(CategoryTitle CategTitle)
        {
            id = ++CurID;
            Title = CategTitle;
            CategoryTasks = new List<Task>();
        }
        public Category(CategoryTitle CategTitle, string Desc)
        {
            id = ++CurID;
            Title = CategTitle;
            Description = Desc;
            CategoryTasks = new List<Task>();
        }
        public Category(CategoryTitle CategTitle, string Desc, List<Task> ListOfTasks)
        {
            id = ++CurID;
            Title = CategTitle;
            Description = Desc;
            CategoryTasks = ListOfTasks;
        }
        public Category(Category cat)
        {
            id = cat.id;
            Title = cat.Title;
            Description = cat.Description;
            CategoryTasks = cat.CategoryTasks;
        }
    }
}
