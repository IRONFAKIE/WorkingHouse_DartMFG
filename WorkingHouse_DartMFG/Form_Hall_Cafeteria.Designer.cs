namespace WorkingHouse_DartMFG
{
    partial class Form_Hall_Cafeteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hall_Cafeteria));
            button_Hall_Cafeteria1 = new Button();
            button_Hall_Cafeteria2 = new Button();
            button_Hall_Cafeteria3 = new Button();
            SuspendLayout();
            // 
            // button_Hall_Cafeteria1
            // 
            button_Hall_Cafeteria1.Font = new Font("Times New Roman", 14F);
            button_Hall_Cafeteria1.Location = new Point(30, 720);
            button_Hall_Cafeteria1.Name = "button_Hall_Cafeteria1";
            button_Hall_Cafeteria1.Size = new Size(240, 30);
            button_Hall_Cafeteria1.TabIndex = 10;
            button_Hall_Cafeteria1.Text = "ПРОЙТИ В СТОЛОВУЮ";
            button_Hall_Cafeteria1.UseVisualStyleBackColor = true;
            button_Hall_Cafeteria1.Click += button_Hall_Cafeteria1_Click;
            // 
            // button_Hall_Cafeteria2
            // 
            button_Hall_Cafeteria2.Font = new Font("Times New Roman", 14F);
            button_Hall_Cafeteria2.Location = new Point(276, 720);
            button_Hall_Cafeteria2.Name = "button_Hall_Cafeteria2";
            button_Hall_Cafeteria2.Size = new Size(200, 30);
            button_Hall_Cafeteria2.TabIndex = 11;
            button_Hall_Cafeteria2.Text = "ЗАЙТИ НА КУХНЮ";
            button_Hall_Cafeteria2.UseVisualStyleBackColor = true;
            button_Hall_Cafeteria2.Click += button_Hall_Cafeteria2_Click;
            // 
            // button_Hall_Cafeteria3
            // 
            button_Hall_Cafeteria3.Font = new Font("Times New Roman", 14F);
            button_Hall_Cafeteria3.Location = new Point(482, 720);
            button_Hall_Cafeteria3.Name = "button_Hall_Cafeteria3";
            button_Hall_Cafeteria3.Size = new Size(200, 30);
            button_Hall_Cafeteria3.TabIndex = 12;
            button_Hall_Cafeteria3.Text = "ЗАЙТИ В КОМНАТЫ";
            button_Hall_Cafeteria3.UseVisualStyleBackColor = true;
            button_Hall_Cafeteria3.Click += button_Hall_Cafeteria3_Click;
            // 
            // Form_Hall_Cafeteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 781);
            Controls.Add(button_Hall_Cafeteria3);
            Controls.Add(button_Hall_Cafeteria2);
            Controls.Add(button_Hall_Cafeteria1);
            Name = "Form_Hall_Cafeteria";
            Text = "Form_Hall_Cafeteria";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Hall_Cafeteria1;
        private Button button_Hall_Cafeteria2;
        private Button button_Hall_Cafeteria3;
    }
}