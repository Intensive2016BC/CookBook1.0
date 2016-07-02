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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text == "" || tbUserName.Text.Length > 25)
            {
                MessageBox.Show("Введено слишком короткое или слишком длинное имя!");
                return;
            } 
            UserManager userManager = new UserManager();
            userManager.CreateNewUser(tbUserName.Text);
            this.Close();
        }
    }
}
