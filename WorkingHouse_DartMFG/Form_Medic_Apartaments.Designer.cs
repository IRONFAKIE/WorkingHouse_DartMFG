namespace WorkingHouse_DartMFG
{
    partial class Form_Medic_Apartaments
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
            button_Medic_Apartaments_1 = new Button();
            SuspendLayout();
            // 
            // button_Medic_Apartaments_1
            // 
            button_Medic_Apartaments_1.Font = new Font("Times", 14F);
            button_Medic_Apartaments_1.Location = new Point(30, 720);
            button_Medic_Apartaments_1.Name = "button_Medic_Apartaments_1";
            button_Medic_Apartaments_1.Size = new Size(200, 30);
            button_Medic_Apartaments_1.TabIndex = 17;
            button_Medic_Apartaments_1.Text = "ВЫЙТИ";
            button_Medic_Apartaments_1.UseVisualStyleBackColor = true;
            button_Medic_Apartaments_1.Click += button_Medic_Apartaments_1_Click;
            // 
            // Form_Medic_Apartaments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 781);
            Controls.Add(button_Medic_Apartaments_1);
            Name = "Form_Medic_Apartaments";
            Text = "Form_Medic_Apartaments";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Medic_Apartaments_1;
    }
}