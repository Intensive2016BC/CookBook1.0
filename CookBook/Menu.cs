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
    public partial class Menu : Form
    {
        public string UserName { get; set; }
        public Menu(string username, AuthorizeForm auth)
        {
            InitializeComponent();
            UserName = username;
            this.auth = auth;
        }
        AuthorizeForm auth;

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeLabelLevel();
        }

        public void ChangeLabelLevel()
        {
            UserManager userManager = new UserManager();
            User user = userManager.GetList().First(u => u.Login == UserName);
            lbUserName.Text = user.Login;
            lbUserPoints.Text = user.Points.ToString();
            lbUserLevel.Text = userManager.GetLevel(user.Points).ToString();
        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            auth.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            auth.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            GameForm gform = new GameForm(int.Parse(lbUserLevel.Text), this, UserName);
            gform.Show();
            this.Hide();
        }

        private void btnCookBook_Click(object sender, EventArgs e)
        {
            CategoriesForm cform = new CategoriesForm(int.Parse(lbUserLevel.Text), this);
            cform.Show();
            this.Hide();
        }
    }
}
