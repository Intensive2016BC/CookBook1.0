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
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.rtbRecipe = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
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
            // rtbIngredients
            // 
            this.rtbIngredients.BackColor = System.Drawing.Color.PeachPuff;
            this.rtbIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIngredients.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbIngredients.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbIngredients.Location = new System.Drawing.Point(59, 229);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.ReadOnly = true;
            this.rtbIngredients.ShortcutsEnabled = false;
            this.rtbIngredients.Size = new System.Drawing.Size(307, 171);
            this.rtbIngredients.TabIndex = 4;
            this.rtbIngredients.Text = "";
            // 
            // rtbRecipe
            // 
            this.rtbRecipe.BackColor = System.Drawing.Color.PeachPuff;
            this.rtbRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecipe.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbRecipe.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtbRecipe.Location = new System.Drawing.Point(419, 45);
            this.rtbRecipe.Name = "rtbRecipe";
            this.rtbRecipe.ReadOnly = true;
            this.rtbRecipe.ShortcutsEnabled = false;
            this.rtbRecipe.Size = new System.Drawing.Size(310, 355);
            this.rtbRecipe.TabIndex = 5;
            this.rtbRecipe.Text = "";
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
            // RecipeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook.Properties.Resources.book4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbRecipe);
            this.Controls.Add(this.rtbIngredients);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbForward;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox rtbIngredients;
        private System.Windows.Forms.RichTextBox rtbRecipe;
        private System.Windows.Forms.Button btnClose;
    }
}