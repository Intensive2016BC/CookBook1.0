namespace CookBook
{
    partial class TestIngredients
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
            this.labelInstruction = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.rtbIngr = new System.Windows.Forms.RichTextBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(13, 13);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(492, 20);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Выберите пропущенные ингредиенты из списка ключевых слов";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(17, 37);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // rtbIngr
            // 
            this.rtbIngr.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbIngr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbIngr.Location = new System.Drawing.Point(224, 37);
            this.rtbIngr.Name = "rtbIngr";
            this.rtbIngr.Size = new System.Drawing.Size(100, 96);
            this.rtbIngr.TabIndex = 2;
            this.rtbIngr.Text = "";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(17, 293);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(112, 43);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // TestIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 348);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.rtbIngr);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.labelInstruction);
            this.Name = "TestIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.RichTextBox rtbIngr;
        private System.Windows.Forms.Button btnAnswer;
    }
}