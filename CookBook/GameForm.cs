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
    public partial class GameForm : Form
    {
        public GameForm(int level, Menu menu, string user, bool vol)
        {
            InitializeComponent();
            this.Level = level;
            User = user;
            this.menu = menu;
            volume = vol;
        }
        string User;
        int Level;
        Menu menu;
        bool volume;
        bool closing = false;

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManager.playSound();
            CategoryGameForm cgform = new CategoryGameForm(Level, User, this, volume);
            cgform.Show();
            this.Hide();
        }

        private void buttonLevel_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManager.playSound();
            LevelGameForm lgform = new LevelGameForm(Level, User, this, volume);
            lgform.Show();
            this.Hide();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManager.playSound();
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList();
            List<int> indexes = new List<int>();
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
                else
                    indexes.Add(i);
            }
            TestManager testManager = new TestManager(volume);
            if (testManager.StartGame(recipes, indexes, User))
                ReturnToMenu();
        }

        public void ReturnToMenu()
        {
            menu.Show();
            menu.ChangeLabelLevel();
            closing = true;
            this.Close();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
            {
                ReturnToMenu();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (volume)
                MusicManager.playSound();
            ReturnToMenu();
        }
    }
}
