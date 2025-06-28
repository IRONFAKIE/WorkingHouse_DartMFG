namespace WorkingHouse_DartMFG
{
    partial class Form_Buro
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
            button_Buro_1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Buro_1
            // 
            button_Buro_1.Font = new Font("Times New Roman", 14F);
            button_Buro_1.Location = new Point(30, 720);
            button_Buro_1.Name = "button_Buro_1";
            button_Buro_1.Size = new Size(200, 30);
            button_Buro_1.TabIndex = 16;
            button_Buro_1.Text = "ВЫЙТИ";
            button_Buro_1.UseVisualStyleBackColor = true;
            button_Buro_1.Click += button_Buro_1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(466, 356);
            label1.Name = "label1";
            label1.Size = new Size(145, 357);
            label1.TabIndex = 17;
            label1.Text = "Обыск";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(100, 473);
            label2.Name = "label2";
            label2.Size = new Size(338, 197);
            label2.TabIndex = 18;
            label2.Text = "Обыск";
            // 
            // Form_Buro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395525_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Buro_1);
            Name = "Form_Buro";
            Text = "Form_Buro";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Buro_1;
        private Label label1;
        private Label label2;
    }
}