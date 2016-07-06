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
            btnRegistration.BackColor = Color.Transparent;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Contains(" ") || tbUserName.Text == "" || tbUserName.Text.Length > 25)
            {
                InfoForm iform = new InfoForm("Введенное имя слишком короткое, длинное или содержит пробелы!", true);
                iform.Show();
                return;
            } 
            UserManager userManager = new UserManager();
            if (userManager.CreateNewUser(tbUserName.Text))
            {
                InfoForm iform = new InfoForm("Пользователь успешно добавлен!", true);
                if (iform.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                InfoForm inform = new InfoForm("Пользователь с такими именем уже существует", true);
                if (inform.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
