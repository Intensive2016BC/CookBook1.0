using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using CookBook.Models;

namespace CookBook.Managers
{
    public class CategoryManager
    {
        public List<Category> GetList(string path)
        {
            List<Category> catList = new List<Category>();
            DatabaseManager dbManager = new DatabaseManager();
            DataTable cats = dbManager.GetFullList("Category");
            for (int i = 0; i < cats.Rows.Count; i++)
            {
                Category cat = new Category(Convert.ToInt32(cats.Rows[i][0]), cats.Rows[i][1].ToString(), Convert.ToInt32(cats.Rows[i][2]));
                catList.Add(cat);
            }
            return catList;
        }
    }
}
