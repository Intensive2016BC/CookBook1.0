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
        public LevelGameForm(int level, string user, GameForm gform)
        {
            InitializeComponent();
            Level = level;
            User = user;
            this.gform = gform;
            List<Button> btns = new List<Button>();
            btns.Add(Level1);
            btns.Add(Level2);
            btns.Add(Level3);
            btns.Add(Level4);
            btns.Add(Level5);
            for (int i = 0; i < btns.Count; i++)
            {
                if (i+1 > Level)
                {
                    btns[i].Enabled = false;
                }
            }
        }
        GameForm gform;
        string User;
        int Level;
        bool closeAfterGame = false;

        private void Level1_Click(object sender, EventArgs e)
        {
            StartTest(1);
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            StartTest(2);
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            StartTest(3);
        }

        private void Level4_Click(object sender, EventArgs e)
        {
            StartTest(4);
        }

        private void Level5_Click(object sender, EventArgs e)
        {
            StartTest(5);
        }

        private void StartTest(int level)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            List<int> indexes = new List<int>();
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level != level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
                else
                    indexes.Add(i);
            }
            TestManager testManager = new TestManager();
            bool GameEnd = testManager.StartGame(recipes, indexes, User);
            if (GameEnd) gform.ReturnToMenu();
            closeAfterGame = true;
            this.Close();
        }

        private void LevelGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeAfterGame) gform.Show();
        }
    }
}
