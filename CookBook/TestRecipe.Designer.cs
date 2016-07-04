namespace CookBook
{
    partial class TestRecipe
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
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.labRecipeName = new System.Windows.Forms.Label();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstruction.Location = new System.Drawing.Point(13, 13);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(595, 26);
            this.labelInstruction.TabIndex = 0;
            this.labelInstruction.Text = "Выберите пропущенные ингредиенты из списка ключевых слов";
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.Peru;
            this.btnAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnswer.Location = new System.Drawing.Point(17, 306);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(112, 43);
            this.btnAnswer.TabIndex = 3;
            this.btnAnswer.Text = "Ответить";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lbWords
            // 
            this.lbWords.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbWords.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWords.FormattingEnabled = true;
            this.lbWords.HorizontalScrollbar = true;
            this.lbWords.ItemHeight = 23;
            this.lbWords.Location = new System.Drawing.Point(331, 85);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(287, 184);
            this.lbWords.TabIndex = 6;
            this.lbWords.SelectedIndexChanged += new System.EventHandler(this.lbIngreds_SelectedIndexChanged);
            // 
            // labRecipeName
            // 
            this.labRecipeName.AutoSize = true;
            this.labRecipeName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRecipeName.Location = new System.Drawing.Point(17, 48);
            this.labRecipeName.Name = "labRecipeName";
            this.labRecipeName.Size = new System.Drawing.Size(76, 23);
            this.labRecipeName.TabIndex = 7;
            this.labRecipeName.Text = "Блюдо: ";
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.Peru;
            this.btnExitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitGame.Location = new System.Drawing.Point(464, 306);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(154, 43);
            this.btnExitGame.TabIndex = 8;
            this.btnExitGame.Text = "Выйти из игры";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Peru;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(293, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 43);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отменить игру";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(21, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(263, 184);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Peru;
            this.btnAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgain.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAgain.Location = new System.Drawing.Point(496, 42);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(122, 37);
            this.btnAgain.TabIndex = 11;
            this.btnAgain.Text = "Сбросить";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // TestRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 361);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.labRecipeName);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.labelInstruction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestIngredients_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Label labRecipeName;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAgain;
    }
}