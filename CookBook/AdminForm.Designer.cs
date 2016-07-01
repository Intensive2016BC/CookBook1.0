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
            ((System.ComponentModel.ISupportInitialize)(this.tables)).BeginInit();
            this.SuspendLayout();
            // 
            // tables
            // 
            this.tables.AllowUserToAddRows = false;
            this.tables.AllowUserToDeleteRows = false;
            this.tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tables.Location = new System.Drawing.Point(13, 13);
            this.tables.Name = "tables";
            this.tables.ReadOnly = true;
            this.tables.Size = new System.Drawing.Size(518, 192);
            this.tables.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 291);
            this.Controls.Add(this.tables);
            this.Name = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.tables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tables;
    }
}