﻿namespace WorkingHouse_DartMFG
{
    partial class Form_Extra
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(307, 19);
            label1.TabIndex = 0;
            label1.Text = "ДОСТУПНО ПОСЛЕ ПЕРВОГО ПРОХРЖДЕНИЯ";
            // 
            // Form_Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 35);
            Controls.Add(label1);
            Name = "Form_Extra";
            Text = "Form_Extra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}