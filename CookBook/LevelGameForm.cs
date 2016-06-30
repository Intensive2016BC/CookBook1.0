using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBook.Managers;
using CookBook.Models;

namespace CookBook
{
    public partial class LevelGameForm : Form
    {
        public LevelGameForm(int level, string user)
        {
            InitializeComponent();
            Level = level;
            User = user;
            List<Label> labels = new List<Label>();
            labels.Add(Level1);
            labels.Add(Level2);
            labels.Add(Level3);
            labels.Add(Level4);
            labels.Add(Level5);
            for (int i = 0; i < labels.Count; i++)
            {
                if (i+1 > Level)
                {
                    labels[i].Enabled = false;
                }
            }
        }
        string User;
        int Level;

        private void Level1_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level != 1)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level != 2)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level != 3)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void Level4_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level != 4)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void Level5_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level != 5)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < test; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }
    }
}
