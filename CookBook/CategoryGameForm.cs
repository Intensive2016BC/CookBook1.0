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
        public CategoryGameForm(int level, string user, GameForm gform, bool vol)
        {
            InitializeComponent();
            Level = level;
            User = user;
            this.gform = gform;
            volume = vol;
        }
        GameForm gform;
        string User;
        int Level;
        bool closeAfterGame = false;
        bool volume;

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
            List<Recipe> recipes = recipesManager.GetList();
            List<int> indexes = new List<int>();
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != category || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
                else
                    indexes.Add(i);
            }
            TestManager testManager = new TestManager();
            bool GameEnd = testManager.StartGame(recipes, indexes, User);
            if (GameEnd)
            {
                gform.ReturnToMenu();
                closeAfterGame = true;
                this.Close();
            }
        }

        private void CategoryGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeAfterGame) gform.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
