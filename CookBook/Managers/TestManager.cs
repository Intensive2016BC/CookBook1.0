using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CookBook.Models;
using System.Windows.Forms;

namespace CookBook.Managers
{
    public class TestManager
    {
        public bool CreateTestName(List<Recipe> recipes, int index)
        {
            TestName tn = new TestName(recipes[index].Image, recipes[index].Name, recipes);
            if (tn.ShowDialog() == DialogResult.OK)
            {
                if (tn.right)
                {
                    tn.Close();
                    return true;
                }
                else
                {
                    tn.Close();
                    return false;
                }
            }
            else return false;
        }

        public List<string> GetIngreds(string path)
        {
            List<string> ingreds = new List<string>();
            ingreds.AddRange(File.ReadAllLines(path));
            return ingreds;
        }

        public List<string> GetWrongIngreds(Recipe recipe, int count)
        {
            List<string> wrongIngreds = new List<string>();
            List<string> ingreds = GetIngreds(AppDomain.CurrentDomain.BaseDirectory + "Ingredients.txt");
            wrongIngreds.AddRange(ingreds.Where(i => !recipe.Ingredients.Contains(i)).OrderBy(i => Guid.NewGuid()).Take(count));
            return wrongIngreds;
        }

        public List<int> GetIndexesForDelete(List<string> ingreds, int count)
        {
            List<int> indexes = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int num = rnd.Next(ingreds.Count);
                if (!indexes.Contains(num))
                {
                    indexes.Add(num);
                }
                else
                {
                    i--;
                }
            }
            return indexes;
        }
        public bool CreateTestIngred(Recipe recipe)
        {
            TestIngredients ti = new TestIngredients(recipe);
            if (ti.ShowDialog() == DialogResult.OK)
            {
                if (ti.right)
                {
                    ti.Close();
                    return true;
                }
                else
                {
                    ti.Close();
                    return false;
                }
            }
            else return false;
        }
    }
}

