namespace WorkingHouse_DartMFG
{
    partial class Form_Outside
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Outside));
            button_Outside1 = new Button();
            button_Outside2 = new Button();
            SuspendLayout();
            // 
            // button_Outside1
            // 
            button_Outside1.Font = new Font("Times New Roman", 14F);
            button_Outside1.Location = new Point(30, 720);
            button_Outside1.Name = "button_Outside1";
            button_Outside1.Size = new Size(200, 30);
            button_Outside1.TabIndex = 6;
            button_Outside1.Text = "ВОЙТИ НА СКЛАД";
            button_Outside1.UseVisualStyleBackColor = true;
            button_Outside1.Click += button_Outside1_Click;
            // 
            // button_Outside2
            // 
            button_Outside2.Font = new Font("Times New Roman", 14F);
            button_Outside2.Location = new Point(236, 720);
            button_Outside2.Name = "button_Outside2";
            button_Outside2.Size = new Size(200, 30);
            button_Outside2.TabIndex = 7;
            button_Outside2.Text = "ВОЙТИ В ЦЕХ";
            button_Outside2.UseVisualStyleBackColor = true;
            button_Outside2.Click += button_Outside2_Click;
            // 
            // Form_Outside
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 781);
            Controls.Add(button_Outside2);
            Controls.Add(button_Outside1);
            Name = "Form_Outside";
            Text = "Form_Outside";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Outside1;
        private Button button_Outside2;
    }
}