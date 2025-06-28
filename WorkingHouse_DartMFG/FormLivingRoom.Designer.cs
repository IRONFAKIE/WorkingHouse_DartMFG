namespace WorkingHouse_DartMFG
{
    partial class FormLivingRoom
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
            button_LivingRoom_1 = new Button();
            button_LivingRoom_2 = new Button();
            SuspendLayout();
            // 
            // button_LivingRoom_1
            // 
            button_LivingRoom_1.Font = new Font("Times", 14F);
            button_LivingRoom_1.Location = new Point(30, 720);
            button_LivingRoom_1.Name = "button_LivingRoom_1";
            button_LivingRoom_1.Size = new Size(200, 30);
            button_LivingRoom_1.TabIndex = 13;
            button_LivingRoom_1.Text = "ВЫЙТИ";
            button_LivingRoom_1.UseVisualStyleBackColor = true;
            button_LivingRoom_1.Click += button_LivingRoom_1_Click;
            // 
            // button_LivingRoom_2
            // 
            button_LivingRoom_2.Font = new Font("Times", 14F);
            button_LivingRoom_2.Location = new Point(236, 720);
            button_LivingRoom_2.Name = "button_LivingRoom_2";
            button_LivingRoom_2.Size = new Size(200, 30);
            button_LivingRoom_2.TabIndex = 14;
            button_LivingRoom_2.Text = "ВОЙТИ В СПАЛЬНЮ";
            button_LivingRoom_2.UseVisualStyleBackColor = true;
            button_LivingRoom_2.Click += button_LivingRoom_2_Click;
            // 
            // FormLivingRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 781);
            Controls.Add(button_LivingRoom_2);
            Controls.Add(button_LivingRoom_1);
            Name = "FormLivingRoom";
            Text = "FormLivingRoom";
            ResumeLayout(false);
        }

        #endregion

        private Button button_LivingRoom_1;
        private Button button_LivingRoom_2;
    }
}