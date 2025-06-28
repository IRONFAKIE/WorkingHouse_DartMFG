namespace WorkingHouse_DartMFG
{
    partial class Form_Kitchen
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
            button_Kitchen1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Kitchen1
            // 
            button_Kitchen1.Font = new Font("Times New Roman", 14F);
            button_Kitchen1.Location = new Point(30, 720);
            button_Kitchen1.Name = "button_Kitchen1";
            button_Kitchen1.Size = new Size(200, 30);
            button_Kitchen1.TabIndex = 9;
            button_Kitchen1.Text = "ВЫЙТИ";
            button_Kitchen1.UseVisualStyleBackColor = true;
            button_Kitchen1.Click += button_Kitchen1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(399, 274);
            label2.Name = "label2";
            label2.Size = new Size(159, 239);
            label2.TabIndex = 13;
            label2.Text = "Сюда снотворное";
            // 
            // Form_Kitchen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395520_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label2);
            Controls.Add(button_Kitchen1);
            Name = "Form_Kitchen";
            Text = "Form_Kitchen";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Kitchen1;
        private Label label2;
    }
}