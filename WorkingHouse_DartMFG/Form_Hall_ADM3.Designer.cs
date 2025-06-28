namespace WorkingHouse_DartMFG
{
    partial class Form_Hall_ADM3
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
            button_Hall_ADM3_1 = new Button();
            button_Hall_ADM3_2 = new Button();
            SuspendLayout();
            // 
            // button_Hall_ADM3_1
            // 
            button_Hall_ADM3_1.Font = new Font("Times", 14F);
            button_Hall_ADM3_1.Location = new Point(30, 720);
            button_Hall_ADM3_1.Name = "button_Hall_ADM3_1";
            button_Hall_ADM3_1.Size = new Size(200, 30);
            button_Hall_ADM3_1.TabIndex = 13;
            button_Hall_ADM3_1.Text = "ЗАЙТИ В КВАРТИРУ";
            button_Hall_ADM3_1.UseVisualStyleBackColor = true;
            button_Hall_ADM3_1.Click += button_Hall_ADM3_1_Click;
            // 
            // button_Hall_ADM3_2
            // 
            button_Hall_ADM3_2.Font = new Font("Times", 14F);
            button_Hall_ADM3_2.Location = new Point(236, 720);
            button_Hall_ADM3_2.Name = "button_Hall_ADM3_2";
            button_Hall_ADM3_2.Size = new Size(200, 30);
            button_Hall_ADM3_2.TabIndex = 14;
            button_Hall_ADM3_2.Text = "НА ЛЕСТНИЦУ";
            button_Hall_ADM3_2.UseVisualStyleBackColor = true;
            button_Hall_ADM3_2.Click += button_Hall_ADM3_2_Click;
            // 
            // Form_Hall_ADM3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 781);
            Controls.Add(button_Hall_ADM3_2);
            Controls.Add(button_Hall_ADM3_1);
            Name = "Form_Hall_ADM3";
            Text = "Form_Hall_ADM3";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Hall_ADM3_1;
        private Button button_Hall_ADM3_2;
    }
}