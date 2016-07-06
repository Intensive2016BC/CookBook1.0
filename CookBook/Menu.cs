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
            volume = true;
            UserName = username;
            this.auth = auth;
            UserManager userManager = new UserManager();
            List<User> users = userManager.GetList();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Login == username)
                    if (!users[i].IsAdmin)
                    {
                        btnAdmin.Visible = false;
                        pbVolume.Location = new Point(pbVolume.Location.X, pbVolume.Location.Y-64);
                    }
            }
        }
        AuthorizeForm auth;
        bool closing = false;
        bool volume;

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChangeLabelLevel();
        }

        public void ChangeLabelLevel()
        {
            UserManager userManager = new UserManager();
            User user = userManager.GetList().First(u => u.Login == UserName);
            lblUserName.Text = user.Login;
            lblUserPoints.Text = "Набранные баллы: "+ user.Points.ToString();
            lblUserLevel.Text = "Уровень: "+userManager.GetLevel(user.Points).ToString();
        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            auth.GetUsers();
            auth.Show();
            closing = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            auth.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            GameForm gform = new GameForm(int.Parse(lblUserLevel.Text.Split(' ')[1]), this, UserName, volume);
            gform.Show();
            this.Hide();
        }

        private void btnCookBook_Click(object sender, EventArgs e)
        {
            CategoriesForm cform = new CategoriesForm(int.Parse(lblUserLevel.Text.Split(' ')[1]), this, volume);
            cform.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm aform = new AdminForm(volume);
            aform.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing)
                auth.Close();
        }

        private void pbVolume_Click(object sender, EventArgs e)
        {
            if (volume)
            {
                volume = false;
                pbVolume.BackgroundImage = CookBook.Properties.Resources.volumeoff;
            }
            else
            {
                volume = true;
                pbVolume.BackgroundImage = CookBook.Properties.Resources.volumeon;
            }
        }
    }
}
