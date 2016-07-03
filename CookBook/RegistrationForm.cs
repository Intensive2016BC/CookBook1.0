﻿using System;
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
            btnRegistration.BackColor = Color.Transparent;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Contains(" ") || tbUserName.Text == "" || tbUserName.Text.Length > 25)
            {
                InfoForm iform = new InfoForm("Введенное имя слишком короткое, длинное или содержит пробелы!");
                iform.Show();
                return;
            } 
            UserManager userManager = new UserManager();
            userManager.CreateNewUser(tbUserName.Text);
            this.Close();
        }
    }
}
