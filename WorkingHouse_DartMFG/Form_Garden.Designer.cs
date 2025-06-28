namespace WorkingHouse_DartMFG
{
    partial class Form_Garden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Garden));
            button_Garden1 = new Button();
            button_Garden2 = new Button();
            SuspendLayout();
            // 
            // button_Garden1
            // 
            button_Garden1.Font = new Font("Times New Roman", 14F);
            button_Garden1.Location = new Point(30, 720);
            button_Garden1.Name = "button_Garden1";
            button_Garden1.Size = new Size(240, 30);
            button_Garden1.TabIndex = 7;
            button_Garden1.Text = "ВОЙТИ В СТОЛОВУЮ";
            button_Garden1.UseVisualStyleBackColor = true;
            button_Garden1.Click += button_Garden1_Click;
            // 
            // button_Garden2
            // 
            button_Garden2.Font = new Font("Times New Roman", 14F);
            button_Garden2.Location = new Point(276, 720);
            button_Garden2.Name = "button_Garden2";
            button_Garden2.Size = new Size(200, 30);
            button_Garden2.TabIndex = 8;
            button_Garden2.Text = "ВОЙТИ В КОМНАТЫ";
            button_Garden2.UseVisualStyleBackColor = true;
            button_Garden2.Click += button_Garden2_Click;
            // 
            // Form_Garden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 781);
            Controls.Add(button_Garden2);
            Controls.Add(button_Garden1);
            Name = "Form_Garden";
            Text = "Form_Garden";
            Load += Form_Garden_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_Garden1;
        private Button button_Garden2;
    }
}