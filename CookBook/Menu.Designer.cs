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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.lblUserPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGame
            // 
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.Image = global::CookBook.Properties.Resources.food;
            this.btnGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.Location = new System.Drawing.Point(12, 124);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(340, 64);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Начать играть";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnCookBook
            // 
            this.btnCookBook.FlatAppearance.BorderSize = 0;
            this.btnCookBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnCookBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCookBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCookBook.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCookBook.Image = global::CookBook.Properties.Resources.book;
            this.btnCookBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCookBook.Location = new System.Drawing.Point(12, 194);
            this.btnCookBook.Name = "btnCookBook";
            this.btnCookBook.Size = new System.Drawing.Size(340, 64);
            this.btnCookBook.TabIndex = 1;
            this.btnCookBook.Text = "Посмотреть книгу рецептов";
            this.btnCookBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCookBook.UseVisualStyleBackColor = true;
            this.btnCookBook.Click += new System.EventHandler(this.btnCookBook_Click);
            // 
            // btnUserChange
            // 
            this.btnUserChange.FlatAppearance.BorderSize = 0;
            this.btnUserChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnUserChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnUserChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChange.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserChange.Image = global::CookBook.Properties.Resources.return1;
            this.btnUserChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserChange.Location = new System.Drawing.Point(12, 264);
            this.btnUserChange.Name = "btnUserChange";
            this.btnUserChange.Size = new System.Drawing.Size(340, 64);
            this.btnUserChange.TabIndex = 2;
            this.btnUserChange.Text = "Сменить пользователя";
            this.btnUserChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserChange.UseVisualStyleBackColor = true;
            this.btnUserChange.Click += new System.EventHandler(this.btnUserChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Image = global::CookBook.Properties.Resources.logout;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(12, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(340, 64);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Выход";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.Image = global::CookBook.Properties.Resources.admin;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdmin.Location = new System.Drawing.Point(12, 404);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(340, 64);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = " Администрирование";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.Location = new System.Drawing.Point(13, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 33);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "label1";
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserLevel.Location = new System.Drawing.Point(13, 51);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(62, 26);
            this.lblUserLevel.TabIndex = 10;
            this.lblUserLevel.Text = "label1";
            // 
            // lblUserPoints
            // 
            this.lblUserPoints.AutoSize = true;
            this.lblUserPoints.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserPoints.Location = new System.Drawing.Point(13, 82);
            this.lblUserPoints.Name = "lblUserPoints";
            this.lblUserPoints.Size = new System.Drawing.Size(62, 26);
            this.lblUserPoints.TabIndex = 11;
            this.lblUserPoints.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CookBook.Properties.Resources.backmenu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 480);
            this.Controls.Add(this.lblUserPoints);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUserChange);
            this.Controls.Add(this.btnCookBook);
            this.Controls.Add(this.btnGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnCookBook;
        private System.Windows.Forms.Button btnUserChange;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Label lblUserPoints;
    }
}