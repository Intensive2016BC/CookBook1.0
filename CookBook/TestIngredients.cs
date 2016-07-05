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
        public List<int> indexes;
        public int countWrong;
        public bool change = false;
        public bool answer = false;
        public bool exitGame = false;
        public bool cancelGame = false;

        public TestIngredients(Recipe recipe)
        {
            InitializeComponent();
            MyRecipe = recipe;
            lblName.Text += recipe.Name;
            TestManager testManager = new TestManager();
            int count = MyRecipe.Ingredients.Count;
            int ingrcount = count - 3;
            Ingredients = testManager.GetWrongIngreds(MyRecipe, ingrcount);
            Random rnd = new Random();
            indexes = testManager.GetIndexesForDelete(MyRecipe.Ingredients, 3);
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
            for (int i = 0; i < Ingredients.Count; i++)
            {
                lbIngreds.Items.Add(Ingredients[i]);
            }
            lbIngreds.SelectedIndex = -1;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            answer = true;
            DialogResult = DialogResult.OK;
        }

        private void lbIngreds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIngreds.SelectedIndex != -1)
            {
                string selectedItem = lbIngreds.SelectedItem.ToString();
                int index = RecipeIngredients.IndexOf("____________");
                RecipeIngredients[index] = selectedItem;
                lbRecipeIngreds.Items.Clear();
                for (int i = 0; i < RecipeIngredients.Count; i++)
                {
                    lbRecipeIngreds.Items.Add(RecipeIngredients[i]);
                }
                if (MyRecipe.Ingredients.Contains(selectedItem))
                {
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

        private void TestIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelGame && !exitGame && !answer)
                countWrong = 3;
            DialogResult = DialogResult.OK;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            lbIngreds.Items.Clear();
            lbRecipeIngreds.Items.Clear();
            countWrong = indexes.Count;
            for (int i = 0; i < indexes.Count; i++)
            {
                RecipeIngredients[indexes[i]] = "____________";
            }
            for (int i = 0; i < RecipeIngredients.Count; i++)
            {
                lbRecipeIngreds.Items.Add(RecipeIngredients[i]);
            }
            for (int i = 0; i < Ingredients.Count; i++)
            {
                lbIngreds.Items.Add(Ingredients[i]);
            }
            lbIngreds.SelectedIndex = -1;
        }
    }
}

