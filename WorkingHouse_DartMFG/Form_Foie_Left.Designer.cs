namespace WorkingHouse_DartMFG
{
    partial class Form_Foie_Left
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
            button_FoieL_1 = new Button();
            button_FoieL_2 = new Button();
            button_FoieL_3 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_FoieL_1
            // 
            button_FoieL_1.Font = new Font("Times New Roman", 14F);
            button_FoieL_1.Location = new Point(30, 720);
            button_FoieL_1.Name = "button_FoieL_1";
            button_FoieL_1.Size = new Size(200, 30);
            button_FoieL_1.TabIndex = 4;
            button_FoieL_1.Text = "ПРОЙТИ В ЦЕНТР";
            button_FoieL_1.UseVisualStyleBackColor = true;
            button_FoieL_1.Click += button_FoieC_2_Click;
            // 
            // button_FoieL_2
            // 
            button_FoieL_2.Font = new Font("Times New Roman", 14F);
            button_FoieL_2.Location = new Point(236, 720);
            button_FoieL_2.Name = "button_FoieL_2";
            button_FoieL_2.Size = new Size(240, 30);
            button_FoieL_2.TabIndex = 5;
            button_FoieL_2.Text = "ЗАЙТИ В СТОЛОВУЮ";
            button_FoieL_2.UseVisualStyleBackColor = true;
            button_FoieL_2.Click += button_FoieL_2_Click;
            // 
            // button_FoieL_3
            // 
            button_FoieL_3.Font = new Font("Times New Roman", 14F);
            button_FoieL_3.Location = new Point(482, 720);
            button_FoieL_3.Name = "button_FoieL_3";
            button_FoieL_3.Size = new Size(240, 30);
            button_FoieL_3.TabIndex = 6;
            button_FoieL_3.Text = "ЗАЙТИ В ВАХТОВУЮ";
            button_FoieL_3.UseVisualStyleBackColor = true;
            button_FoieL_3.Click += button_FoieL_3_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(537, 294);
            label2.Name = "label2";
            label2.Size = new Size(96, 411);
            label2.TabIndex = 13;
            label2.Text = "Генри Хамер";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(445, 355);
            label1.Name = "label1";
            label1.Size = new Size(86, 350);
            label1.TabIndex = 14;
            label1.Text = "Мэдэллин";
            // 
            // Form_Foie_Left
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395529_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button_FoieL_3);
            Controls.Add(button_FoieL_2);
            Controls.Add(button_FoieL_1);
            Name = "Form_Foie_Left";
            Text = "Form_Foie_Left";
            ResumeLayout(false);
        }

        #endregion

        private Button button_FoieL_1;
        private Button button_FoieL_2;
        private Button button_FoieL_3;
        private Label label2;
        private Label label1;
    }
}