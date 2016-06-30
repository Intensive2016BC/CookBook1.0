using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBook.Managers;

namespace CookBook
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
            UserManager userManager = new UserManager();
            cbUsers.DataSource = userManager.GetList().Select(u => u.Login).ToList();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            UserManager userManager = new UserManager();
            cbUsers.DataSource = userManager.GetList().Select(u => u.Login).ToList();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Menu mainForm = new Menu(cbUsers.SelectedItem.ToString(), this);
            mainForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.BackColor = Color.Bisque;
            this.TransparencyKey = this.BackColor;
        }
    }
}
