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
    public partial class CategoryGameForm : Form
    {
        public CategoryGameForm(int level, string user)
        {
            InitializeComponent();
            Level = level;
            User = user;
        }
        string User;
        int Level;

        private void pbMainMeal_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != 2 || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < recipes.Count; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void pbSalad_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != 4 || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < recipes.Count; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void pbBreakfast_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != 3 || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < recipes.Count; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void pbBakery_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != 1 || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < recipes.Count; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, recipes.Count);
                if (testManager.CreateTestName(recipes, index))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }

        private void pbSoup_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != 5 || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            TestManager testManager = new TestManager();
            int count = 0;
            int test = recipes.Count;
            if (test > 10) test = 10;
            for (int i = 0; i < recipes.Count; i++)
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
