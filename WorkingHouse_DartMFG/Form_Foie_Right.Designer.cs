namespace WorkingHouse_DartMFG
{
    partial class Form_Foie_Right
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
            button_FoieR_1 = new Button();
            button_FoieR_2 = new Button();
            button_FoieR_3 = new Button();
            button_FoieR_4 = new Button();
            SuspendLayout();
            // 
            // button_FoieR_1
            // 
            button_FoieR_1.Font = new Font("Times", 14F);
            button_FoieR_1.Location = new Point(30, 684);
            button_FoieR_1.Name = "button_FoieR_1";
            button_FoieR_1.Size = new Size(200, 30);
            button_FoieR_1.TabIndex = 1;
            button_FoieR_1.Text = "ПРОЙТИ В ЦЕНТР";
            button_FoieR_1.UseVisualStyleBackColor = true;
            button_FoieR_1.Click += button_FoieR_1_Click;
            // 
            // button_FoieR_2
            // 
            button_FoieR_2.Font = new Font("Times", 14F);
            button_FoieR_2.Location = new Point(236, 684);
            button_FoieR_2.Name = "button_FoieR_2";
            button_FoieR_2.Size = new Size(240, 30);
            button_FoieR_2.TabIndex = 2;
            button_FoieR_2.Text = "ВЫЙТИ НА ЛЕСТНИЦУ";
            button_FoieR_2.UseVisualStyleBackColor = true;
            button_FoieR_2.Click += button_FoieR_2_Click;
            // 
            // button_FoieR_3
            // 
            button_FoieR_3.Font = new Font("Times", 14F);
            button_FoieR_3.Location = new Point(482, 684);
            button_FoieR_3.Name = "button_FoieR_3";
            button_FoieR_3.Size = new Size(240, 30);
            button_FoieR_3.TabIndex = 3;
            button_FoieR_3.Text = "ЗАЙТИ В КЛАДОВКУ";
            button_FoieR_3.UseVisualStyleBackColor = true;
            button_FoieR_3.Click += button_FoieR_3_Click;
            // 
            // button_FoieR_4
            // 
            button_FoieR_4.Font = new Font("Times", 14F);
            button_FoieR_4.Location = new Point(30, 720);
            button_FoieR_4.Name = "button_FoieR_4";
            button_FoieR_4.Size = new Size(200, 30);
            button_FoieR_4.TabIndex = 4;
            button_FoieR_4.Text = "ПОЙТИ НА СКЛАД";
            button_FoieR_4.UseVisualStyleBackColor = true;
            button_FoieR_4.Click += button_FoieR_4_Click;
            // 
            // Form_Foie_Right
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5400213525911173864_y__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(button_FoieR_4);
            Controls.Add(button_FoieR_3);
            Controls.Add(button_FoieR_2);
            Controls.Add(button_FoieR_1);
            Name = "Form_Foie_Right";
            Text = "Form_Foie_Right";
            ResumeLayout(false);
        }

        #endregion

        private Button button_FoieR_1;
        private Button button_FoieR_2;
        private Button button_FoieR_3;
        private Button button_FoieR_4;
    }
}