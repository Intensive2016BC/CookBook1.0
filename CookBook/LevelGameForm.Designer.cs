﻿namespace CookBook
{
    partial class LevelGameForm
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
            this.Level1 = new System.Windows.Forms.Button();
            this.Level2 = new System.Windows.Forms.Button();
            this.Level3 = new System.Windows.Forms.Button();
            this.Level4 = new System.Windows.Forms.Button();
            this.Level5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Level1
            // 
            this.Level1.FlatAppearance.BorderSize = 0;
            this.Level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level1.Location = new System.Drawing.Point(13, 13);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(176, 41);
            this.Level1.TabIndex = 0;
            this.Level1.Text = "Уровень 1";
            this.Level1.UseVisualStyleBackColor = true;
            this.Level1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // Level2
            // 
            this.Level2.FlatAppearance.BorderSize = 0;
            this.Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level2.Location = new System.Drawing.Point(12, 60);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(176, 41);
            this.Level2.TabIndex = 1;
            this.Level2.Text = "Уровень 2";
            this.Level2.UseVisualStyleBackColor = true;
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // Level3
            // 
            this.Level3.FlatAppearance.BorderSize = 0;
            this.Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level3.Location = new System.Drawing.Point(12, 107);
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(176, 41);
            this.Level3.TabIndex = 2;
            this.Level3.Text = "Уровень 3";
            this.Level3.UseVisualStyleBackColor = true;
            this.Level3.Click += new System.EventHandler(this.Level3_Click);
            // 
            // Level4
            // 
            this.Level4.FlatAppearance.BorderSize = 0;
            this.Level4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level4.Location = new System.Drawing.Point(12, 154);
            this.Level4.Name = "Level4";
            this.Level4.Size = new System.Drawing.Size(176, 41);
            this.Level4.TabIndex = 3;
            this.Level4.Text = "Уровень 4";
            this.Level4.UseVisualStyleBackColor = true;
            this.Level4.Click += new System.EventHandler(this.Level4_Click);
            // 
            // Level5
            // 
            this.Level5.FlatAppearance.BorderSize = 0;
            this.Level5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Level5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level5.Location = new System.Drawing.Point(12, 201);
            this.Level5.Name = "Level5";
            this.Level5.Size = new System.Drawing.Size(176, 41);
            this.Level5.TabIndex = 4;
            this.Level5.Text = "Уровень 5";
            this.Level5.UseVisualStyleBackColor = true;
            this.Level5.Click += new System.EventHandler(this.Level5_Click);
            // 
            // LevelGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.Level5);
            this.Controls.Add(this.Level4);
            this.Controls.Add(this.Level3);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.Level1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LevelGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelGameForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Level1;
        private System.Windows.Forms.Button Level2;
        private System.Windows.Forms.Button Level3;
        private System.Windows.Forms.Button Level4;
        private System.Windows.Forms.Button Level5;
    }
}