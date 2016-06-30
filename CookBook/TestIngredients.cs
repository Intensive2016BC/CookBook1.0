using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBook.Models;
using CookBook.Managers;

namespace CookBook
{
    public partial class TestIngredients : Form
    {
        public TestIngredients(Recipe recipe, List<Recipe> recipes)
        {
            InitializeComponent();
            pbImage.Image = recipe.Image;
        }
        public bool right;

        private void btnAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
