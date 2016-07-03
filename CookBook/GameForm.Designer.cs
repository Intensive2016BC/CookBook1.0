namespace CookBook
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonLevel = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCategory
            // 
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.buttonCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategory.Location = new System.Drawing.Point(12, 95);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(340, 64);
            this.buttonCategory.TabIndex = 0;
            this.buttonCategory.Text = "Выбрать категорию";
            this.buttonCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonLevel
            // 
            this.buttonLevel.FlatAppearance.BorderSize = 0;
            this.buttonLevel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.buttonLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevel.Location = new System.Drawing.Point(12, 165);
            this.buttonLevel.Name = "buttonLevel";
            this.buttonLevel.Size = new System.Drawing.Size(340, 64);
            this.buttonLevel.TabIndex = 1;
            this.buttonLevel.Text = "Выбрать уровень";
            this.buttonLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLevel.UseVisualStyleBackColor = true;
            this.buttonLevel.Click += new System.EventHandler(this.buttonLevel_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.FlatAppearance.BorderSize = 0;
            this.buttonRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.buttonRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandom.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.Location = new System.Drawing.Point(12, 235);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(340, 64);
            this.buttonRandom.TabIndex = 2;
            this.buttonRandom.Text = "Случайная игра";
            this.buttonRandom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CookBook.Properties.Resources.food;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonLevel);
            this.Controls.Add(this.buttonCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начать играть";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonLevel;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

