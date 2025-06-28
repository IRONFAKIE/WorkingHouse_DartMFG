namespace WorkingHouse_DartMFG
{
    partial class Form_BedRoom
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
            button_BedRoom_1 = new Button();
            SuspendLayout();
            // 
            // button_BedRoom_1
            // 
            button_BedRoom_1.Font = new Font("Times", 14F);
            button_BedRoom_1.Location = new Point(30, 720);
            button_BedRoom_1.Name = "button_BedRoom_1";
            button_BedRoom_1.Size = new Size(200, 30);
            button_BedRoom_1.TabIndex = 13;
            button_BedRoom_1.Text = "ВЫЙТИ";
            button_BedRoom_1.UseVisualStyleBackColor = true;
            button_BedRoom_1.Click += button_BedRoom_1_Click;
            // 
            // Form_BedRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 781);
            Controls.Add(button_BedRoom_1);
            Name = "Form_BedRoom";
            Text = "Form_BedRoom";
            ResumeLayout(false);
        }

        #endregion

        private Button button_BedRoom_1;
    }
}