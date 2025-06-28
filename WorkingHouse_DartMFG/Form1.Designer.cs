namespace WorkingHouse_DartMFG
{
    partial class Form_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainMenu));
            button_Start = new Button();
            button_Settings = new Button();
            button_Exit = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Start
            // 
            button_Start.BackColor = Color.Red;
            button_Start.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_Start.ForeColor = Color.White;
            button_Start.Location = new Point(40, 470);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(150, 40);
            button_Start.TabIndex = 0;
            button_Start.Text = "НАЧАТЬ";
            button_Start.UseVisualStyleBackColor = false;
            button_Start.Click += button_Start_Click;
            // 
            // button_Settings
            // 
            button_Settings.BackColor = SystemColors.ActiveBorder;
            button_Settings.Font = new Font("Segoe UI", 14F);
            button_Settings.Location = new Point(40, 530);
            button_Settings.Name = "button_Settings";
            button_Settings.Size = new Size(150, 40);
            button_Settings.TabIndex = 1;
            button_Settings.Text = "НАСТРОЙКИ";
            button_Settings.UseVisualStyleBackColor = false;
            button_Settings.Click += button_Settings_Click;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = SystemColors.ActiveBorder;
            button_Exit.Font = new Font("Segoe UI", 14F);
            button_Exit.Location = new Point(40, 590);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(150, 40);
            button_Exit.TabIndex = 2;
            button_Exit.Text = "ВЫХОД";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(40, 650);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 3;
            button1.Text = "СВЕДЕНИЯ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 4;
            label1.Text = "Alpha Test 1.0.1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(589, 703);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 66);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 781);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button_Exit);
            Controls.Add(button_Settings);
            Controls.Add(button_Start);
            Name = "Form_MainMenu";
            Text = "[TRMINAL-79]";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Start;
        private Button button_Settings;
        private Button button_Exit;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
