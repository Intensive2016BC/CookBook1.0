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
            ((System.ComponentModel.ISupportInitialize)(this.pbForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbForward
            // 
            this.pbForward.BackgroundImage = global::CookBook.Properties.Resources.forward;
            this.pbForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbForward.Location = new System.Drawing.Point(597, 334);
            this.pbForward.Name = "pbForward";
            this.pbForward.Size = new System.Drawing.Size(70, 100);
            this.pbForward.TabIndex = 2;
            this.pbForward.TabStop = false;
            this.pbForward.Click += new System.EventHandler(this.pbForward_Click);
            // 
            // pbBack
            // 
            this.pbBack.BackgroundImage = global::CookBook.Properties.Resources.back;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Location = new System.Drawing.Point(12, 334);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(70, 100);
            this.pbBack.TabIndex = 1;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(89, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(296, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 24);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "label1";
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbIngredients.Location = new System.Drawing.Point(300, 41);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.ReadOnly = true;
            this.rtbIngredients.Size = new System.Drawing.Size(289, 171);
            this.rtbIngredients.TabIndex = 4;
            this.rtbIngredients.Text = "";
            // 
            // rtbRecipe
            // 
            this.rtbRecipe.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbRecipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbRecipe.Location = new System.Drawing.Point(89, 218);
            this.rtbRecipe.Name = "rtbRecipe";
            this.rtbRecipe.ReadOnly = true;
            this.rtbRecipe.Size = new System.Drawing.Size(500, 216);
            this.rtbRecipe.TabIndex = 5;
            this.rtbRecipe.Text = "";
            // 
            // RecipeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 446);
            this.Controls.Add(this.rtbRecipe);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pbForward);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbImage);
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
    }
}