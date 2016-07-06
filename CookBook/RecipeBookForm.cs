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
        private int CurentPosition = 0;
        public RecipeBookForm(int level, int category, CategoriesForm cform, bool vol)
        {
            InitializeComponent();
            Level = level;
            Category = category;
            CForm = cform;
            volume = vol;
            pbUp2.Visible = false;
            pbUp1.Visible = false;
            pbDown1.Visible = false;
            pbDown2.Visible = false;
            t.ToolTipTitle = "Обратите внимание";
        }
        CategoriesForm CForm;
        int Level;
        int Category;
        List<Recipe> recipes;
        int Index = 0;
        bool volume;
        ToolTip t = new ToolTip();

        void rtbIngredients_MouseWheel(object sender, MouseEventArgs e)
        {
            int position = CurentPosition -= e.Delta;

            if (position >= 0)
            {
                CurentPosition = position;
                rtbRecipe.SelectionStart = CurentPosition;
                rtbRecipe.ScrollToCaret();
            }
            if (position < 0)
            {
                CurentPosition = 120;
            }
            if (rtbRecipe.SelectionStart == rtbRecipe.TextLength)
            {
                CurentPosition -= 120;
            }
        }

        void rtbRecipe_MouseWheel(object sender, MouseEventArgs e)
        {
            int position = CurentPosition -= e.Delta;

            if (position >= 0)
            {
                CurentPosition = position;
                rtbRecipe.SelectionStart = CurentPosition;
                rtbRecipe.ScrollToCaret();
            }
            if (position < 0)
            {
                CurentPosition = 120;
            }
            if (rtbRecipe.SelectionStart == rtbRecipe.TextLength)
            {
                CurentPosition -= 120;
            }
        }

        private int LinesCount(RichTextBox rtb)
        {
            Graphics g = CreateGraphics();
            float count = (g.MeasureString(rtb.Text, rtb.Font).Width / rtb.Width);
            int n = (int)count;
            if (count > n)
                n++;
            return n;
        }

        private void RecipeBookForm_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.BackColor = Color.DarkGoldenrod;
            this.TransparencyKey = this.BackColor;
            rtbIngredients.ScrollBars = RichTextBoxScrollBars.None;
            rtbRecipe.ScrollBars = RichTextBoxScrollBars.None;
            rtbIngredients.MouseWheel += new MouseEventHandler(rtbIngredients_MouseWheel);
            rtbRecipe.MouseWheel += new MouseEventHandler(rtbRecipe_MouseWheel);
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

                    if (rtbRecipe.Text.Length > 450)
                    {
                        pbUp2.Visible = true;
                        pbDown2.Visible = true;
                    }
                    else
                    {
                        pbUp2.Visible = false;
                        pbDown2.Visible = false;
                    }
                    if (rtbIngredients.Lines.Length > 6)
                    {
                        pbUp1.Visible = true;
                        pbDown1.Visible = true;
                    }
                    else
                    {
                        pbUp1.Visible = false;
                        pbDown1.Visible = false;
                    }
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
                if (rtbRecipe.Text.Length > 450)
                {
                    pbUp2.Visible = true;
                    pbDown2.Visible = true;
                }
                else
                {
                    pbUp2.Visible = false;
                    pbDown2.Visible = false;
                }
                if (rtbIngredients.Lines.Length > 6)
                {
                    pbUp1.Visible = true;
                    pbDown1.Visible = true;
                }
                else
                {
                    pbUp1.Visible = false;
                    pbDown1.Visible = false;
                }
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
                if (rtbRecipe.Text.Length > 450)
                {
                    pbUp2.Visible = true;
                    pbDown2.Visible = true;
                }
                else
                {
                    pbUp2.Visible = false;
                    pbDown2.Visible = false;
                }
                if (rtbIngredients.Lines.Length > 6)
                {
                    pbUp1.Visible = true;
                    pbDown1.Visible = true;
                }
                else
                {
                    pbUp1.Visible = false;
                    pbDown1.Visible = false;
                }
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

        private void pbUp1_MouseHover(object sender, EventArgs e)
        {
            t.SetToolTip(pbUp1, "Список ингредиентов можно прокрутить");
        }

        private void pbDown1_MouseHover(object sender, EventArgs e)
        {
            t.SetToolTip(pbDown1, "Список ингредиентов можно прокрутить");
        }

        private void pbUp2_MouseHover(object sender, EventArgs e)
        {
            t.SetToolTip(pbUp2, "Рецепт можно прокрутить");
        }

        private void pbDown2_MouseHover(object sender, EventArgs e)
        {
            t.SetToolTip(pbDown2, "Рецепт можно прокрутить");
        }
    }
}
