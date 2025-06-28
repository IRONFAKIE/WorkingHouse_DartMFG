namespace WorkingHouse_DartMFG
{
    partial class Form_Room4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Room4));
            button_Room4_1 = new Button();
            SuspendLayout();
            // 
            // button_Room4_1
            // 
            button_Room4_1.Font = new Font("Times New Roman", 14F);
            button_Room4_1.Location = new Point(30, 720);
            button_Room4_1.Name = "button_Room4_1";
            button_Room4_1.Size = new Size(200, 30);
            button_Room4_1.TabIndex = 17;
            button_Room4_1.Text = "ВЫЙТИ";
            button_Room4_1.UseVisualStyleBackColor = true;
            button_Room4_1.Click += button_Room4_1_Click;
            // 
            // Form_Room4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 781);
            Controls.Add(button_Room4_1);
            Name = "Form_Room4";
            Text = "Form_Room4";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Room4_1;
    }
}