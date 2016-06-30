using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CookBook.Models;

namespace CookBook.Managers
{
    public class CategoryManager
    {
        public List<Category> GetList(string path)
        {
            List<Category> catList = new List<Category>();
            FileStream fs = new FileStream(path, FileMode.Open);
            using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(1251)))
            {

                string line;
                int counter = 0;
                string[] catAttrs = new string[3];
                while ((line = sr.ReadLine()) != null)
                {
                    catAttrs[counter] = line;
                    counter++;
                    if (counter == 3)
                    {
                        catList.Add(new Category(int.Parse(catAttrs[0]), catAttrs[1], int.Parse(catAttrs[2])));
                        counter = 0;
                    }
                }
            }
            return catList;
        }
    }
}
