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
    public partial class InfoForm : Form
    {
        public InfoForm(string text, bool volume)
        {
            InitializeComponent();
            TextLabel.Text = text;
            Volume = volume;
        }
        bool Volume;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            if (Volume)
                MusicManager.playResultSound("simplesound.wav");
            buttonOK.Location = new Point(this.Width / 2 - 40, TextLabel.Location.Y + TextLabel.Size.Height + 20);
        }
    }
}
