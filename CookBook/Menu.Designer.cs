namespace CookBook
{
    partial class Menu
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
            this.btnGame = new System.Windows.Forms.Button();
            this.btnCookBook = new System.Windows.Forms.Button();
            this.btnUserChange = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPoints = new System.Windows.Forms.Label();
            this.lbUserLevel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Location = new System.Drawing.Point(12, 64);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(260, 23);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Начать играть";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnCookBook
            // 
            this.btnCookBook.FlatAppearance.BorderSize = 0;
            this.btnCookBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCookBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCookBook.Location = new System.Drawing.Point(12, 93);
            this.btnCookBook.Name = "btnCookBook";
            this.btnCookBook.Size = new System.Drawing.Size(260, 23);
            this.btnCookBook.TabIndex = 1;
            this.btnCookBook.Text = "Посмтреть книгу рецептов";
            this.btnCookBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCookBook.UseVisualStyleBackColor = true;
            this.btnCookBook.Click += new System.EventHandler(this.btnCookBook_Click);
            // 
            // btnUserChange
            // 
            this.btnUserChange.FlatAppearance.BorderSize = 0;
            this.btnUserChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChange.Location = new System.Drawing.Point(12, 122);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Size = new System.Drawing.Size(271, 23);
            this.btnUserChange.TabIndex = 2;
            this.btnUserChange.Text = "Сменить пользователя";
            this.btnUserChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserChange.UseVisualStyleBackColor = true;
            this.btnUserChange.Click += new System.EventHandler(this.btnUserChange_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(20, 9);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(35, 13);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "label1";
            // 
            // lbUserPoints
            // 
            this.lbUserPoints.AutoSize = true;
            this.lbUserPoints.Location = new System.Drawing.Point(20, 22);
            this.lbUserPoints.Name = "lbUserPoints";
            this.lbUserPoints.Size = new System.Drawing.Size(35, 13);
            this.lbUserPoints.TabIndex = 4;
            this.lbUserPoints.Text = "label2";
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.Location = new System.Drawing.Point(61, 9);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(35, 13);
            this.lbUserLevel.TabIndex = 5;
            this.lbUserLevel.Text = "label3";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(12, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(271, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выход";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 259);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbUserLevel);
            this.Controls.Add(this.lbUserPoints);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnUserChange);
            this.Controls.Add(this.btnCookBook);
            this.Controls.Add(this.btnGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnCookBook;
        private System.Windows.Forms.Button btnUserChange;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserPoints;
        private System.Windows.Forms.Label lbUserLevel;
        private System.Windows.Forms.Button btnClose;
    }
}