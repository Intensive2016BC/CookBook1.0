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
        public Recipe MyRecipe { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> RecipeIngredients { get; set; }
        public int countWrong;
        public bool change = false;
        public bool exitGame = false;
        public bool cancelGame = false;

        public TestIngredients(Recipe recipe)
        {
            InitializeComponent();
            lbIngreds.SelectedIndex = -1;
            MyRecipe = recipe;
            lblName.Text += recipe.Name;
            TestManager testManager = new TestManager();
            int count = MyRecipe.Ingredients.Count;
            int ingrcount = count - 3;
            Ingredients = testManager.GetWrongIngreds(MyRecipe, ingrcount);
            Random rnd = new Random();
            List<int> indexes = testManager.GetIndexesForDelete(MyRecipe.Ingredients, 3);
            RecipeIngredients = new List<string>();
            for (int i = 0; i < MyRecipe.Ingredients.Count; i++)
            {
                RecipeIngredients.Add(MyRecipe.Ingredients[i]);
            }
            countWrong = indexes.Count;
            for (int i = 0; i < indexes.Count; i++)
            {
                Ingredients.Insert(rnd.Next(Ingredients.Count), MyRecipe.Ingredients[indexes[i]]);
                RecipeIngredients[indexes[i]] = "____________";
            }
            for (int i = 0; i < RecipeIngredients.Count; i++)
            {
                lbRecipeIngreds.Items.Add(RecipeIngredients[i]);
            }
            lbIngreds.DataSource = Ingredients;
            change = true;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void lbIngreds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change)
            {
                string selectedItem = lbIngreds.SelectedItem.ToString();
                if (MyRecipe.Ingredients.Contains(selectedItem))
                {
                    int index = MyRecipe.Ingredients.IndexOf(MyRecipe.Ingredients.First(r => r == selectedItem));
                    RecipeIngredients[index] = selectedItem;
                    lbRecipeIngreds.Items.Clear();
                    for (int i = 0; i < RecipeIngredients.Count;i++)
                    {
                        lbRecipeIngreds.Items.Add(RecipeIngredients[i]);
                    }
                    countWrong--;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelGame = true;
            DialogResult = DialogResult.OK;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            exitGame = true;
            DialogResult = DialogResult.OK;
        }
    }
}

