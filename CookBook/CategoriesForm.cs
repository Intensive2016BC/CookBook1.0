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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm(int level, Menu menu)
        {
            InitializeComponent();
            Level = level;
            this.menu = menu;
        }
        Menu menu;
        int Level;
        List<Category> cats = null;

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int Category = 0;
            if (lbCategories.SelectedItem!=null)
            {
                for (int i = 0; i < cats.Count; i++)
                {
                    if (cats[i].Name == lbCategories.SelectedItem.ToString())
                    {
                        Category = cats[i].Id;
                    }
                }
                RecipeBookForm rbform = new RecipeBookForm(Level, Category, this);
                rbform.Show();
                this.Hide();
            }
        }

        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

            CategoryManager catManager = new CategoryManager();
            cats = catManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Cats.txt");
            for (int i = 0; i < cats.Count; i++)
            {
                if (cats[i].Level <= Level) lbCategories.Items.Add(cats[i]);
            }
        }
    }
}