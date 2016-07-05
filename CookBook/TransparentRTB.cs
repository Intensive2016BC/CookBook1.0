﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookBook
{
    public class TransparentRTB : RichTextBox
    {
        public TransparentRTB()
        {
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.TextChanged += TransparentLabel_TextChanged;
            this.VScroll += TransparentLabel_TextChanged;
            this.HScroll += TransparentLabel_TextChanged;
        }

        void TransparentLabel_TextChanged(object sender, System.EventArgs e)
        {
            this.ForceRefresh();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ExStyle |= 0x20; 
                return parms;
            }
        }
        public void ForceRefresh()
        {
            this.UpdateStyles();
        }
}
}
