using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CookBook.Models;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace CookBook.Managers
{
    public class TestManager
    {
        public int CreateTestName(List<Recipe> recipes, int index)
        {
            TestName tn = new TestName(recipes[index].Image, recipes[index].Name, recipes);
            if (tn.ShowDialog() == DialogResult.OK)
            {
                if (tn.cancelGame)
                {
                    tn.Close();
                    return -1;
                }
                if (tn.exitGame)
                {
                    tn.Close();
                    return -2;
                }
                if (tn.right)
                {
                    tn.Close();
                    return 1;
                }
                else
                {
                    tn.Close();
                    return 0;
                }
            }
            else return 0;
        }

        public List<string> GetIngreds()
        {
            List<string> ingreds = new List<string>();
            DatabaseManager dbManager = new DatabaseManager();
            DataTable ings = dbManager.GetFullList("Ingredients");
            for (int i = 0; i < ings.Rows.Count; i++)
            {
                ingreds.Add(ings.Rows[i][1].ToString());
            }
            return ingreds;
        }

        public List<string> GetWrongIngreds(Recipe recipe, int count)
        {
            List<string> wrongIngreds = new List<string>();
            List<string> ingreds = GetIngreds();
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
        public int CreateTestIngred(Recipe recipe)
        {
            TestIngredients ti = new TestIngredients(recipe);
            if (ti.ShowDialog() == DialogResult.OK)
            {
                if (ti.cancelGame)
                {
                    ti.Close();
                    return -1;
                }
                if (ti.exitGame)
                {
                    ti.Close();
                    return -2;
                }
                int result = ti.countWrong;
                ti.Close();
                return result;
            }
            else return 0;
        }

        public int CreateTestRecipe(Recipe recipe)
        {
            TestRecipe tr = new TestRecipe(recipe);
            if (tr.ShowDialog() == DialogResult.OK)
            {
                if (tr.cancelGame)
                {
                    tr.Close();
                    return -1;
                }
                if (tr.exitGame)
                {
                    tr.Close();
                    return -2;
                }
                if (tr.right)
                {
                    tr.Close();
                    return 1;
                }
                else
                {
                    tr.Close();
                    return 0;
                }
            }
            else return 0;
        }

        public bool StartGame(List<Recipe> recipes, List<int> indexes, string User)
        {
            TestManager testManager = new TestManager();
            int count = 0;
            List<int> DoneRecipes = new List<int>();
            List<string> Results = new List<string>();
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, indexes.Count);
                Random TestType = new Random();
                int Type = TestType.Next(1, 4);
                if (Type == 1)
                {
                    int result = testManager.CreateTestIngred(recipes[indexes[index]]);
                    if (result == -1)
                    {
                        return false;
                    }
                    if (result == -2)
                    {
                        break;
                    }
                    if (result == 0)
                    {
                        count += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + recipes[indexes[index]].Points.ToString());
                    }
                    if (result == 2)
                    {
                        count += recipes[indexes[index]].Points / 3;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + (recipes[indexes[index]].Points/3).ToString());
                    }
                    if (result == 1)
                    {
                        count += recipes[indexes[index]].Points * 2 / 3;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," +( recipes[indexes[index]].Points*2/3).ToString());
                    }
                    if (result == 3)
                    {
                        Results.Add(recipes[indexes[index]].Name + ",0");
                    }
                }
                if (Type == 2)
                {
                    int result = testManager.CreateTestName(recipes, indexes[index]);
                    if (result == -1)
                    {
                        return false;
                    }
                    if (result == -2)
                    {
                        break;
                    }
                    if (result == 1)
                    {
                        count += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + recipes[indexes[index]].Points.ToString());
                    }
                    if (result == 0)
                    {
                        Results.Add(recipes[indexes[index]].Name + ",0");
                    }
                }
                if (Type == 3)
                {
                    int result = testManager.CreateTestRecipe(recipes[indexes[index]]);
                    if (result == -1)
                    {
                        return false;
                    }
                    if (result == -2)
                    {
                        break;
                    }
                    if (result == 1)
                    {
                        count += recipes[indexes[index]].Points;
                        DoneRecipes.Add(recipes[indexes[index]].Id);
                        Results.Add(recipes[indexes[index]].Name + "," + recipes[indexes[index]].Points.ToString());
                    }
                    if (result == 0)
                    {
                        Results.Add(recipes[indexes[index]].Name + ",0");
                    }
                }
                indexes.RemoveAt(index);
            }
            ResultForm rform = new ResultForm(Results);
            UserManager userManager = new UserManager();
            userManager.ChangeUserPoints(User, count, DoneRecipes);
            if (rform.ShowDialog() == DialogResult.OK)
            {
                rform.Close();
                return true;
            }
            else return false;
        }

        public List<string> GetWordsFromDescription(Recipe recipe)
        {
            List<string> words = new List<string>();
            string[] array = recipe.Description.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != String.Empty)
                {
                    if (array[i][0] == '#')
                    {
                        words.Add(array[i].Trim('#', '!', '.', ','));
                    }
                }
            }
            return words;
        }

        public string GetDescription(Recipe recipe)
        {
            string pattern = "#[а-яА-ЯёЁ]+#";
            Regex rgx = new Regex(pattern);
            string description = rgx.Replace(recipe.Description, "____");
            return description;
        }

        public bool CheckIsUserRight(List<string> answers, List<string> list)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i] != list[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

