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
        public CategoryGameForm(int level, string user, GameForm gform)
        {
            InitializeComponent();
            Level = level;
            User = user;
            this.gform = gform;
        }
        GameForm gform;
        string User;
        int Level;

        private void pbMainMeal_Click(object sender, EventArgs e)
        {
            StartTest(2);
        }

        private void pbSalad_Click(object sender, EventArgs e)
        {
            StartTest(4);
        }

        private void pbBreakfast_Click(object sender, EventArgs e)
        {
            StartTest(3);
        }

        private void pbBakery_Click(object sender, EventArgs e)
        {
            StartTest(1);
        }

        private void pbSoup_Click(object sender, EventArgs e)
        {
            StartTest(5);
        }

        private void StartTest(int category)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != category || recipes[i].Level > Level)
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

        private void CategoryGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gform.Show();
        }
    }
}
