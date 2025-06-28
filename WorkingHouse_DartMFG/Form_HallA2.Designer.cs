namespace WorkingHouse_DartMFG
{
    partial class Form_HallA2
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
            button_Hall_A2_1 = new Button();
            button_Hall_A2_2 = new Button();
            SuspendLayout();
            // 
            // button_Hall_A2_1
            // 
            button_Hall_A2_1.Font = new Font("Times", 14F);
            button_Hall_A2_1.Location = new Point(30, 720);
            button_Hall_A2_1.Name = "button_Hall_A2_1";
            button_Hall_A2_1.Size = new Size(200, 30);
            button_Hall_A2_1.TabIndex = 17;
            button_Hall_A2_1.Text = "ВЕРНУТЬСЯ";
            button_Hall_A2_1.UseVisualStyleBackColor = true;
            button_Hall_A2_1.Click += button_Hall_A2_1_Click;
            // 
            // button_Hall_A2_2
            // 
            button_Hall_A2_2.Font = new Font("Times", 14F);
            button_Hall_A2_2.Location = new Point(236, 720);
            button_Hall_A2_2.Name = "button_Hall_A2_2";
            button_Hall_A2_2.Size = new Size(200, 30);
            button_Hall_A2_2.TabIndex = 18;
            button_Hall_A2_2.Text = "В БАШНЮ";
            button_Hall_A2_2.UseVisualStyleBackColor = true;
            button_Hall_A2_2.Click += button_Hall_A2_2_Click;
            // 
            // Form_HallA2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 781);
            Controls.Add(button_Hall_A2_2);
            Controls.Add(button_Hall_A2_1);
            Name = "Form_HallA2";
            Text = "Form_HallA2";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Hall_A2_1;
        private Button button_Hall_A2_2;
    }
}