using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using CookBook.Models;

namespace CookBook.Managers
{
    public class RecipeManager
    {
        public List<Recipe> GetList(string path)
        {
            List<Recipe> recipes = new List<Recipe>();
            FileStream fs = new FileStream(path, FileMode.Open);
            using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(1251)))
            {
                string line;
                int counter = 0;
                string[] recipeAttrs = new string[8];
                while ((line = sr.ReadLine()) != null)
                {
                    recipeAttrs[counter] = line;
                    counter++;
                    if (counter == 8)
                    {
                        int id = int.Parse(recipeAttrs[0]);
                        Image img = Image.FromFile(recipeAttrs[1]);
                        string name = recipeAttrs[2];
                        List<string> ingredients = recipeAttrs[3].Split(',').ToList();
                        string description = recipeAttrs[4];
                        int lvl = int.Parse(recipeAttrs[5]);
                        int points = int.Parse(recipeAttrs[6]);
                        int cId = int.Parse(recipeAttrs[7]);
                        recipes.Add(new Recipe(id, img, name, ingredients, description, lvl, points, cId));
                        counter = 0;
                    }
                }
                return recipes;
            }
        }
    }
}
