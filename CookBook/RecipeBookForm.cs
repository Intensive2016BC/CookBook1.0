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
    public partial class RecipeBookForm : Form
    {
        public RecipeBookForm(int level, int category, CategoriesForm cform)
        {
            InitializeComponent();
            Level = level;
            Category = category;
            CForm = cform;
        }
        CategoriesForm CForm;
        int Level;
        int Category;
        List<Recipe> recipes;
        int Index = 0;

        private void RecipeBookForm_Load(object sender, EventArgs e)
        {
            RecipeManager recipesManager = new RecipeManager();
            recipes = recipesManager.GetList(AppDomain.CurrentDomain.BaseDirectory + "Recipes.txt");
            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].CategoryId != Category || recipes[i].Level > Level)
                {
                    recipes.RemoveAt(i);
                    i--;
                }
            }
            if (recipes[0]!=null)
            {
                pbImage.Image = recipes[0].Image;
                labelName.Text = recipes[0].Name;
                rtbIngredients.Text = "";
                for (int i = 0; i < recipes[0].Ingredients.Count; i++)
                {
                    rtbIngredients.Text += recipes[0].Ingredients[i] + "\n";
                }
                rtbRecipe.Text = recipes[0].Description.Replace("--", "\n");
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if (Index!=0)
            {
                Index--;
                pbImage.Image = recipes[Index].Image;
                labelName.Text = recipes[Index].Name;
                rtbIngredients.Text = "";
                for (int i = 0; i < recipes[Index].Ingredients.Count; i++)
                {
                    if (i != recipes[Index].Ingredients.Count - 1) rtbIngredients.Text += recipes[Index].Ingredients[i] + "\n";
                    else
                        rtbIngredients.Text += recipes[Index].Ingredients[i];
                }
                rtbRecipe.Text = recipes[Index].Description.Replace("--", "\n");
            }
        }

        private void pbForward_Click(object sender, EventArgs e)
        {
            if (Index != recipes.Count-1)
            {
                Index++;
                pbImage.Image = recipes[Index].Image;
                labelName.Text = recipes[Index].Name;
                rtbIngredients.Text = "";
                for (int i = 0; i < recipes[Index].Ingredients.Count; i++)
                {
                    if (i != recipes[Index].Ingredients.Count - 1) rtbIngredients.Text += recipes[Index].Ingredients[i] + "\n";
                    else
                        rtbIngredients.Text += recipes[Index].Ingredients[i];
                }
                rtbRecipe.Text = recipes[Index].Description.Replace("--", "\n");
            }
        }

        private void RecipeBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CForm.Show();
        }
    }
}
