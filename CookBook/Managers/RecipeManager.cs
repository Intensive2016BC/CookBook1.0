using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Data;
using CookBook.Models;
using System.Windows.Forms;

namespace CookBook.Managers
{
    public class RecipeManager
    {
        public List<Recipe> GetList()
        {
            List<Recipe> recipesList = new List<Recipe>();
            DatabaseManager dbManager = new DatabaseManager();
            DataTable recipes = dbManager.GetFullList("Recipe");
            for (int i = 0; i < recipes.Rows.Count; i++)
            {
                byte[] a = (System.Byte[])recipes.Rows[i][1];
                MemoryStream ms = new MemoryStream(a, 0, a.Length);
                ms.Write(a, 0, a.Length);
                Image image = new Bitmap(ms);
                List<string> ings = new List<string>();
                string[] ingreds = recipes.Rows[i][3].ToString().Split(',');
                for (int m = 0; m < ingreds.Length; m++)
                {
                    ings.Add(ingreds[m]);
                }
                Recipe recipe = new Recipe(Convert.ToInt32(recipes.Rows[i][0]), image, recipes.Rows[i][2].ToString(), ings, recipes.Rows[i][4].ToString(), Convert.ToInt32(recipes.Rows[i][5]), Convert.ToInt32(recipes.Rows[i][6]), Convert.ToInt32(recipes.Rows[i][7]));
                recipesList.Add(recipe);
            }
            return recipesList;
        }

        public List<string> GetWordsFromDescription(Recipe recipe)
        {
            List<string> words = new List<string>();
            string[] array = recipe.Description.Split(',');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i][0] == '#')
                {
                    words.Add(array[i].Trim());
                    //words.Add(array[i].Trim('#'));
                }
            }
            return words;
        }
    }
}
