using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookBook
{
    public partial class InfoForm : Form
    {
        public InfoForm(string text)
        {
            InitializeComponent();
            TextLabel.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            buttonOK.Location = new Point(this.Width / 2 - 40, TextLabel.Location.Y + TextLabel.Size.Height + 20);
        }
    }
}
