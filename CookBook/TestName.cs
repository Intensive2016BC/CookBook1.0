﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBook.Models;

namespace CookBook
{
    public partial class TestName : Form
    {
        public TestName(Image image, string name, List<Recipe> recipes)
        {
            InitializeComponent();
            RName = name;
            pbImage.Image = image;
            for (int i = 0; i < recipes.Count; i++)
            {
                cbVars.Items.Add(recipes[i].Name);
            }
        }
        string RName;
        public bool right;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbVars.Text == RName)
                right = true;
            DialogResult = DialogResult.OK;
        }
    }
}