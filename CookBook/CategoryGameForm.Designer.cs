namespace CookBook
{
    partial class CategoryGameForm
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
            this.labelBreakfast = new System.Windows.Forms.Label();
            this.labelMainMeal = new System.Windows.Forms.Label();
            this.labelBakery = new System.Windows.Forms.Label();
            this.labelSalad = new System.Windows.Forms.Label();
            this.labelSoup = new System.Windows.Forms.Label();
            this.pbSoup = new System.Windows.Forms.PictureBox();
            this.pbSalad = new System.Windows.Forms.PictureBox();
            this.pbBakery = new System.Windows.Forms.PictureBox();
            this.pbBreakfast = new System.Windows.Forms.PictureBox();
            this.pbMainMeal = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBakery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMeal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBreakfast
            // 
            this.labelBreakfast.AutoSize = true;
            this.labelBreakfast.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBreakfast.Location = new System.Drawing.Point(21, 23);
            this.labelBreakfast.Name = "labelBreakfast";
            this.labelBreakfast.Size = new System.Drawing.Size(95, 26);
            this.labelBreakfast.TabIndex = 6;
            this.labelBreakfast.Text = "Завтраки";
            // 
            // labelMainMeal
            // 
            this.labelMainMeal.AutoSize = true;
            this.labelMainMeal.Font = new System.Drawing.Font("Candara", 14F);
            this.labelMainMeal.Location = new System.Drawing.Point(239, 3);
            this.labelMainMeal.Name = "labelMainMeal";
            this.labelMainMeal.Size = new System.Drawing.Size(94, 46);
            this.labelMainMeal.TabIndex = 11;
            this.labelMainMeal.Text = "Основные\r\n    блюда";
            // 
            // labelBakery
            // 
            this.labelBakery.AutoSize = true;
            this.labelBakery.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBakery.Location = new System.Drawing.Point(21, 250);
            this.labelBakery.Name = "labelBakery";
            this.labelBakery.Size = new System.Drawing.Size(89, 26);
            this.labelBakery.TabIndex = 12;
            this.labelBakery.Text = "Выпечка";
            // 
            // labelSalad
            // 
            this.labelSalad.AutoSize = true;
            this.labelSalad.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalad.Location = new System.Drawing.Point(141, 133);
            this.labelSalad.Name = "labelSalad";
            this.labelSalad.Size = new System.Drawing.Size(76, 26);
            this.labelSalad.TabIndex = 13;
            this.labelSalad.Text = "Салаты";
            // 
            // labelSoup
            // 
            this.labelSoup.AutoSize = true;
            this.labelSoup.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSoup.Location = new System.Drawing.Point(258, 250);
            this.labelSoup.Name = "labelSoup";
            this.labelSoup.Size = new System.Drawing.Size(58, 26);
            this.labelSoup.TabIndex = 14;
            this.labelSoup.Text = "Супы";
            // 
            // pbSoup
            // 
            this.pbSoup.BackgroundImage = global::CookBook.Properties.Resources.soup;
            this.pbSoup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSoup.Location = new System.Drawing.Point(253, 279);
            this.pbSoup.Name = "pbSoup";
            this.pbSoup.Size = new System.Drawing.Size(70, 70);
            this.pbSoup.TabIndex = 19;
            this.pbSoup.TabStop = false;
            this.pbSoup.Click += new System.EventHandler(this.pbSoup_Click);
            // 
            // pbSalad
            // 
            this.pbSalad.BackgroundImage = global::CookBook.Properties.Resources.salad;
            this.pbSalad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSalad.Location = new System.Drawing.Point(145, 162);
            this.pbSalad.Name = "pbSalad";
            this.pbSalad.Size = new System.Drawing.Size(70, 70);
            this.pbSalad.TabIndex = 18;
            this.pbSalad.TabStop = false;
            this.pbSalad.Click += new System.EventHandler(this.pbSalad_Click);
            // 
            // pbBakery
            // 
            this.pbBakery.BackgroundImage = global::CookBook.Properties.Resources.bakery;
            this.pbBakery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBakery.Location = new System.Drawing.Point(33, 279);
            this.pbBakery.Name = "pbBakery";
            this.pbBakery.Size = new System.Drawing.Size(70, 70);
            this.pbBakery.TabIndex = 17;
            this.pbBakery.TabStop = false;
            this.pbBakery.Click += new System.EventHandler(this.pbBakery_Click);
            // 
            // pbBreakfast
            // 
            this.pbBreakfast.BackgroundImage = global::CookBook.Properties.Resources.breakfast;
            this.pbBreakfast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBreakfast.Location = new System.Drawing.Point(33, 52);
            this.pbBreakfast.Name = "pbBreakfast";
            this.pbBreakfast.Size = new System.Drawing.Size(70, 70);
            this.pbBreakfast.TabIndex = 16;
            this.pbBreakfast.TabStop = false;
            this.pbBreakfast.Click += new System.EventHandler(this.pbBreakfast_Click);
            // 
            // pbMainMeal
            // 
            this.pbMainMeal.BackgroundImage = global::CookBook.Properties.Resources.mainmeal;
            this.pbMainMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMainMeal.Location = new System.Drawing.Point(253, 52);
            this.pbMainMeal.Name = "pbMainMeal";
            this.pbMainMeal.Size = new System.Drawing.Size(70, 70);
            this.pbMainMeal.TabIndex = 15;
            this.pbMainMeal.TabStop = false;
            this.pbMainMeal.Click += new System.EventHandler(this.pbMainMeal_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(12, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(340, 64);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CategoryGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbSoup);
            this.Controls.Add(this.pbSalad);
            this.Controls.Add(this.pbBakery);
            this.Controls.Add(this.pbBreakfast);
            this.Controls.Add(this.pbMainMeal);
            this.Controls.Add(this.labelSoup);
            this.Controls.Add(this.labelSalad);
            this.Controls.Add(this.labelBakery);
            this.Controls.Add(this.labelMainMeal);
            this.Controls.Add(this.labelBreakfast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CategoryGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра по категориям";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryGameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbSoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBakery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMeal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBreakfast;
        private System.Windows.Forms.Label labelMainMeal;
        private System.Windows.Forms.Label labelBakery;
        private System.Windows.Forms.Label labelSalad;
        private System.Windows.Forms.Label labelSoup;
        private System.Windows.Forms.PictureBox pbMainMeal;
        private System.Windows.Forms.PictureBox pbBreakfast;
        private System.Windows.Forms.PictureBox pbBakery;
        private System.Windows.Forms.PictureBox pbSalad;
        private System.Windows.Forms.PictureBox pbSoup;
        private System.Windows.Forms.Button btnClose;
    }
}