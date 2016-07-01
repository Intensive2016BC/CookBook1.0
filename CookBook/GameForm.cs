﻿using System;
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
        public GameForm(int level, Menu menu, string user)
        {
            InitializeComponent();
            this.Level = level;
            User = user;
            this.menu = menu;
        }
        string User;
        int Level;
        Menu menu;

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            CategoryGameForm cgform = new CategoryGameForm(Level, User, this);
            cgform.Show();
            this.Hide();
        }

        private void buttonLevel_Click(object sender, EventArgs e)
        {
            LevelGameForm lgform = new LevelGameForm(Level, User, this);
            lgform.Show();
            this.Hide();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            List<Recipe> recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
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
            TestManager testManager = new TestManager();
            if (testManager.StartGame(recipes, indexes, User))
                ReturnToMenu();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ReturnToMenu();
        }

        public void ReturnToMenu()
        {
            menu.Show();
            menu.ChangeLabelLevel();
            this.Close();
        }
    }
}
