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
            this.AllowTransparency = true;
            this.BackColor = Color.DarkGoldenrod;
            this.TransparencyKey = this.BackColor;
            try
            {
                RecipeManager recipesManager = new RecipeManager();
                recipes = recipesManager.GetList();
                for (int i = 0; i < recipes.Count; i++)
                {
                    if (recipes[i].CategoryId != Category || recipes[i].Level > Level)
                    {
                        recipes.RemoveAt(i);
                        i--;
                    }
                }
                if (recipes.Count!=0)
                {
                    pbImage.BackgroundImage = recipes[0].Image;
                    pbImage.BackgroundImageLayout = ImageLayout.Stretch;
                    labelName.Text = recipes[0].Name;
                    rtbIngredients.Text = "";
                    for (int i = 0; i < recipes[0].Ingredients.Count; i++)
                    {
                        rtbIngredients.Text += recipes[0].Ingredients[i] + "\n";
                    }
                    rtbRecipe.Text = recipes[0].Description.Replace("#", "");
                    pbBack.Visible = false;
                    if (recipes.Count == 1) pbForward.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            if (Index!=0)
            {
                Index--;
                pbImage.BackgroundImage = recipes[Index].Image;
                labelName.Text = recipes[Index].Name;
                rtbIngredients.Text = "";
                for (int i = 0; i < recipes[Index].Ingredients.Count; i++)
                {
                    if (i != recipes[Index].Ingredients.Count - 1) rtbIngredients.Text += recipes[Index].Ingredients[i] + "\n";
                    else
                        rtbIngredients.Text += recipes[Index].Ingredients[i];
                }
                rtbRecipe.Text = recipes[Index].Description.Replace("#", "");
                if (Index == 0)
                    pbBack.Visible = false;
                if (Index + 1 == recipes.Count)
                    pbForward.Visible = false;
                else
                    pbForward.Visible = true;
            }
        }

        private void pbForward_Click(object sender, EventArgs e)
        {
            if (Index != recipes.Count-1)
            {
                Index++;
                pbImage.BackgroundImage = recipes[Index].Image;
                labelName.Text = recipes[Index].Name;
                rtbIngredients.Text = "";
                for (int i = 0; i < recipes[Index].Ingredients.Count; i++)
                {
                    if (i != recipes[Index].Ingredients.Count - 1) rtbIngredients.Text += recipes[Index].Ingredients[i] + "\n";
                    else
                        rtbIngredients.Text += recipes[Index].Ingredients[i];
                }
                rtbRecipe.Text = recipes[Index].Description.Replace("#", "");
                if (Index == recipes.Count-1)
                    pbForward.Visible = false;
                if (Index == 0)
                    pbBack.Visible = false;
                else
                    pbBack.Visible = true;
            }
        }

        private void RecipeBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecipeBookForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
