namespace WorkingHouse_DartMFG
{
    partial class Form_Storage
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
            button_Storage1 = new Button();
            button_Storage2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Storage1
            // 
            button_Storage1.Font = new Font("Times New Roman", 14F);
            button_Storage1.Location = new Point(30, 720);
            button_Storage1.Name = "button_Storage1";
            button_Storage1.Size = new Size(200, 30);
            button_Storage1.TabIndex = 0;
            button_Storage1.Text = "ПОЙТИ В ФОЙЕ";
            button_Storage1.UseVisualStyleBackColor = true;
            button_Storage1.Click += button_Storage1_Click;
            // 
            // button_Storage2
            // 
            button_Storage2.Font = new Font("Times New Roman", 14F);
            button_Storage2.Location = new Point(236, 719);
            button_Storage2.Name = "button_Storage2";
            button_Storage2.Size = new Size(200, 30);
            button_Storage2.TabIndex = 1;
            button_Storage2.Text = "ВЫЙТИ ВО ДВОР";
            button_Storage2.UseVisualStyleBackColor = true;
            button_Storage2.Click += button_Storage2_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(455, 217);
            label2.Name = "label2";
            label2.Size = new Size(337, 533);
            label2.TabIndex = 13;
            label2.Text = "Обыск";
            label2.Click += label2_Click;
            // 
            // Form_Storage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395526_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label2);
            Controls.Add(button_Storage2);
            Controls.Add(button_Storage1);
            Name = "Form_Storage";
            Text = "Form_Storage";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Storage1;
        private Button button_Storage2;
        private Label label2;
    }
}