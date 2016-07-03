namespace CookBook
{
    partial class AdminForm
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
            this.tables = new System.Windows.Forms.DataGridView();
            this.rbtnUser = new System.Windows.Forms.RadioButton();
            this.rbtnCategory = new System.Windows.Forms.RadioButton();
            this.rbtnRecipe = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbtnIngreds = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tables)).BeginInit();
            this.SuspendLayout();
            // 
            // tables
            // 
            this.tables.AllowUserToAddRows = false;
            this.tables.AllowUserToDeleteRows = false;
            this.tables.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tables.Location = new System.Drawing.Point(13, 13);
            this.tables.Name = "tables";
            this.tables.ReadOnly = true;
            this.tables.RowHeadersVisible = false;
            this.tables.Size = new System.Drawing.Size(518, 266);
            this.tables.TabIndex = 0;
            // 
            // rbtnUser
            // 
            this.rbtnUser.AutoSize = true;
            this.rbtnUser.FlatAppearance.BorderSize = 0;
            this.rbtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnUser.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnUser.Location = new System.Drawing.Point(538, 13);
            this.rbtnUser.Name = "rbtnUser";
            this.rbtnUser.Size = new System.Drawing.Size(156, 30);
            this.rbtnUser.TabIndex = 1;
            this.rbtnUser.TabStop = true;
            this.rbtnUser.Text = "Пользователи";
            this.rbtnUser.UseVisualStyleBackColor = true;
            this.rbtnUser.CheckedChanged += new System.EventHandler(this.rbtnUser_CheckedChanged);
            // 
            // rbtnCategory
            // 
            this.rbtnCategory.AutoSize = true;
            this.rbtnCategory.FlatAppearance.BorderSize = 0;
            this.rbtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCategory.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCategory.Location = new System.Drawing.Point(538, 49);
            this.rbtnCategory.Name = "rbtnCategory";
            this.rbtnCategory.Size = new System.Drawing.Size(126, 30);
            this.rbtnCategory.TabIndex = 2;
            this.rbtnCategory.TabStop = true;
            this.rbtnCategory.Text = "Категории";
            this.rbtnCategory.UseVisualStyleBackColor = true;
            this.rbtnCategory.CheckedChanged += new System.EventHandler(this.rbtnCategory_CheckedChanged);
            // 
            // rbtnRecipe
            // 
            this.rbtnRecipe.AutoSize = true;
            this.rbtnRecipe.FlatAppearance.BorderSize = 0;
            this.rbtnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRecipe.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnRecipe.Location = new System.Drawing.Point(537, 85);
            this.rbtnRecipe.Name = "rbtnRecipe";
            this.rbtnRecipe.Size = new System.Drawing.Size(81, 27);
            this.rbtnRecipe.TabIndex = 3;
            this.rbtnRecipe.TabStop = true;
            this.rbtnRecipe.Text = "Блюда";
            this.rbtnRecipe.UseVisualStyleBackColor = true;
            this.rbtnRecipe.CheckedChanged += new System.EventHandler(this.rbtnRecipe_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(13, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(176, 285);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(192, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Peru;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(374, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbtnIngreds
            // 
            this.rbtnIngreds.AutoSize = true;
            this.rbtnIngreds.FlatAppearance.BorderSize = 0;
            this.rbtnIngreds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnIngreds.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnIngreds.Location = new System.Drawing.Point(537, 118);
            this.rbtnIngreds.Name = "rbtnIngreds";
            this.rbtnIngreds.Size = new System.Drawing.Size(152, 30);
            this.rbtnIngreds.TabIndex = 7;
            this.rbtnIngreds.TabStop = true;
            this.rbtnIngreds.Text = "Ингредиенты";
            this.rbtnIngreds.UseVisualStyleBackColor = true;
            this.rbtnIngreds.CheckedChanged += new System.EventHandler(this.rbtnIngreds_CheckedChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CookBook.Properties.Resources.background11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 333);
            this.Controls.Add(this.rbtnIngreds);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rbtnRecipe);
            this.Controls.Add(this.rbtnCategory);
            this.Controls.Add(this.rbtnUser);
            this.Controls.Add(this.tables);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование базы данных";
            ((System.ComponentModel.ISupportInitialize)(this.tables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tables;
        private System.Windows.Forms.RadioButton rbtnUser;
        private System.Windows.Forms.RadioButton rbtnCategory;
        private System.Windows.Forms.RadioButton rbtnRecipe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtnIngreds;
    }
}