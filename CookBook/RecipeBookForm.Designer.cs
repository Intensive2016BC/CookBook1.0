namespace CookBook
{
    partial class RecipeBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbForward = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbDown2 = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.rtbRecipe = new CookBook.TransparentRTB();
            this.rtbIngredients = new CookBook.TransparentRTB();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pbForward
            // 
            this.pbForward.BackColor = System.Drawing.Color.Transparent;
            this.pbForward.BackgroundImage = global::CookBook.Properties.Resources.forward1;
            this.pbForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbForward.Location = new System.Drawing.Point(669, 406);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(60, 60);
            this.pbForward.TabIndex = 2;
            this.pbForward.TabStop = false;
            this.pbForward.Click += new System.EventHandler(this.pbForward_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::CookBook.Properties.Resources.back1;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Location = new System.Drawing.Point(61, 401);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(60, 60);
            this.pbBack.TabIndex = 1;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(59, 73);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 150);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(57, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 26);
            this.labelName.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::CookBook.Properties.Resources.crossclose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(603, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbDown2
            // 
            this.pbDown2.BackColor = System.Drawing.Color.Transparent;
            this.pbDown2.BackgroundImage = global::CookBook.Properties.Resources.down;
            this.pbDown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDown2.Location = new System.Drawing.Point(473, 401);
            this.pbDown2.Name = "pbDown2";
            this.pbDown2.Size = new System.Drawing.Size(64, 25);
            this.pbDown2.TabIndex = 11;
            this.pbDown2.TabStop = false;
            this.pbDown2.MouseHover += new System.EventHandler(this.pbDown2_MouseHover);
            // 
            // pbDown
            // 
            this.pbDown.BackColor = System.Drawing.Color.Transparent;
            this.pbDown.BackgroundImage = global::CookBook.Properties.Resources.down;
            this.pbDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDown.Location = new System.Drawing.Point(307, 401);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(64, 25);
            this.pbDown.TabIndex = 12;
            this.pbDown.TabStop = false;
            this.pbDown.MouseHover += new System.EventHandler(this.pbDown1_MouseHover);
            // 
            // rtbRecipe
            // 
            this.rtbRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecipe.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbRecipe.Location = new System.Drawing.Point(417, 47);
            this.rtbRecipe.Name = "rtbRecipe";
            this.rtbRecipe.ReadOnly = true;
            this.rtbRecipe.Size = new System.Drawing.Size(312, 353);
            this.rtbRecipe.TabIndex = 8;
            this.rtbRecipe.Text = "";
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIngredients.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbIngredients.Location = new System.Drawing.Point(59, 229);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.ReadOnly = true;
            this.rtbIngredients.Size = new System.Drawing.Size(312, 166);
            this.rtbIngredients.TabIndex = 7;
            this.rtbIngredients.Text = "";
            // 
            // RecipeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook.Properties.Resources.book4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pbDown);
            this.Controls.Add(this.pbDown2);
            this.Controls.Add(this.rtbRecipe);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pbForward);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecipeBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecipeBookForm_FormClosing);
            this.Load += new System.EventHandler(this.RecipeBookForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecipeBookForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbForward;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnClose;
        private TransparentRTB rtbIngredients;
        private TransparentRTB rtbRecipe;
        private System.Windows.Forms.PictureBox pbDown2;
        private System.Windows.Forms.PictureBox pbDown;
    }
}