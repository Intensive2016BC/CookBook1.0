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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Location = new System.Drawing.Point(12, 139);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(260, 39);
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
            this.btnCookBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCookBook.Location = new System.Drawing.Point(12, 184);
            this.btnCookBook.Name = "btnCookBook";
            this.btnCookBook.Size = new System.Drawing.Size(282, 34);
            this.btnCookBook.TabIndex = 1;
            this.btnCookBook.Text = "Посмотреть книгу рецептов";
            this.btnCookBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCookBook.UseVisualStyleBackColor = true;
            this.btnCookBook.Click += new System.EventHandler(this.btnCookBook_Click);
            // 
            // btnUserChange
            // 
            this.btnUserChange.FlatAppearance.BorderSize = 0;
            this.btnUserChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserChange.Location = new System.Drawing.Point(12, 224);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Size = new System.Drawing.Size(271, 34);
            this.btnUserChange.TabIndex = 2;
            this.btnUserChange.Text = "Сменить пользователя";
            this.btnUserChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserChange.UseVisualStyleBackColor = true;
            this.btnUserChange.Click += new System.EventHandler(this.btnUserChange_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(20, 9);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(76, 25);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "label1";
            // 
            // lbUserPoints
            // 
            this.lbUserPoints.AutoSize = true;
            this.lbUserPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserPoints.Location = new System.Drawing.Point(22, 76);
            this.lbUserPoints.Name = "lbUserPoints";
            this.lbUserPoints.Size = new System.Drawing.Size(60, 24);
            this.lbUserPoints.TabIndex = 4;
            this.lbUserPoints.Text = "label2";
            // 
            // lbUserLevel
            // 
            this.lbUserLevel.AutoSize = true;
            this.lbUserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserLevel.Location = new System.Drawing.Point(22, 46);
            this.lbUserLevel.Name = "lbUserLevel";
            this.lbUserLevel.Size = new System.Drawing.Size(60, 24);
            this.lbUserLevel.TabIndex = 5;
            this.lbUserLevel.Text = "label3";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(12, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(271, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выход";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.Location = new System.Drawing.Point(12, 302);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(271, 32);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Администрирование";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 355);
            this.Controls.Add(this.btnAdmin);
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
        private System.Windows.Forms.Button btnAdmin;
    }
}