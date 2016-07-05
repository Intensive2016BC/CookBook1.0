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
            DatabaseManager dbManager = new DatabaseManager();
            pass = dbManager.Request("User", "Login = 'Admin'").Rows[0][1].ToString();
        }
        bool Admin = false;
        string pass = "";
        TextBox Password = new TextBox();

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            UserManager userManager = new UserManager();
            cbUsers.DataSource = userManager.GetList().Select(u => u.Login).ToList();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MusicManager.playSound("cartoon008.wav");
            if (Admin && cbUsers.SelectedItem.ToString() != "Admin")
            {
                Admin = false;
                Controls.Remove(Password);
                Password.Text = "";
                cbUsers.Location = new Point(104, 224);
                Menu mainForm = new Menu(cbUsers.SelectedItem.ToString(), this);
                mainForm.Show();
                this.Hide();
                return;
            } 
            if (!Admin)
            {
                if (cbUsers.SelectedItem.ToString() == "Admin")
                {
                    Admin = true;
                    cbUsers.Location = new Point(cbUsers.Location.X, cbUsers.Location.Y-40);
                    Password.Location = new Point(cbUsers.Location.X, cbUsers.Location.Y+40);
                    Password.Height = 31;
                    Password.Width = 300;
                    Password.Font = new Font("Candara", 14, FontStyle.Regular);
                    Controls.Add(Password);
                }
                else
                {
                    Menu mainForm = new Menu(cbUsers.SelectedItem.ToString(), this);
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                if (Password.Text == pass)
                {
                    Menu mainForm = new Menu("Admin", this);
                    Admin = false;
                    Controls.Remove(Password);
                    Password.Text = "";
                    cbUsers.Location = new Point(104, 224);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    InfoForm iform = new InfoForm("Неверный пароль!");
                    iform.Show();
                    Password.Text = "";
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.BackColor = Color.Gold;
            this.TransparencyKey = this.BackColor;
            btnLogIn.BackColor = Color.Transparent;
            buttonExit.BackColor = Color.Transparent;
            buttonExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRegistration.BackColor = Color.Transparent;
            GetUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void GetUsers()
        {
            UserManager userManager = new UserManager();
            cbUsers.DataSource = userManager.GetList().Select(u => u.Login).ToList();
        }

        private void AuthorizeForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
