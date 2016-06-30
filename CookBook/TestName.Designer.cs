namespace CookBook
{
    partial class TestName
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
            this.cbVars = new System.Windows.Forms.ComboBox();
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
            this.labelInstruction.Size = new System.Drawing.Size(406, 20);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Выберите правильное название блюда на картинке";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(113, 36);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // cbVars
            // 
            this.cbVars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVars.FormattingEnabled = true;
            this.cbVars.Location = new System.Drawing.Point(12, 252);
            this.cbVars.Name = "cbVars";
            this.cbVars.Size = new System.Drawing.Size(409, 28);
            this.cbVars.TabIndex = 2;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(159, 297);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(119, 47);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 356);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.cbVars);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.labelInstruction);
            this.Name = "TestName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cbVars;
        private System.Windows.Forms.Button btnAnswer;
    }
}