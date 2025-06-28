namespace WorkingHouse_DartMFG
{
    partial class Form_WorkingSpace2
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
            button_WorkingSpace2_1 = new Button();
            button_WorkingSpace2_2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_WorkingSpace2_1
            // 
            button_WorkingSpace2_1.Font = new Font("Times New Roman", 14F);
            button_WorkingSpace2_1.Location = new Point(30, 720);
            button_WorkingSpace2_1.Name = "button_WorkingSpace2_1";
            button_WorkingSpace2_1.Size = new Size(200, 30);
            button_WorkingSpace2_1.TabIndex = 17;
            button_WorkingSpace2_1.Text = "ВЫЙТИ В БАШНЮ";
            button_WorkingSpace2_1.UseVisualStyleBackColor = true;
            button_WorkingSpace2_1.Click += button_WorkingSpace2_1_Click;
            // 
            // button_WorkingSpace2_2
            // 
            button_WorkingSpace2_2.Font = new Font("Times New Roman", 14F);
            button_WorkingSpace2_2.Location = new Point(236, 720);
            button_WorkingSpace2_2.Name = "button_WorkingSpace2_2";
            button_WorkingSpace2_2.Size = new Size(200, 30);
            button_WorkingSpace2_2.TabIndex = 18;
            button_WorkingSpace2_2.Text = "СПУСТИТЬСЯ";
            button_WorkingSpace2_2.UseVisualStyleBackColor = true;
            button_WorkingSpace2_2.Click += button_WorkingSpace2_2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(164, 454);
            label1.Name = "label1";
            label1.Size = new Size(407, 203);
            label1.TabIndex = 19;
            label1.Text = "Работать";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // Form_WorkingSpace2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395523_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label1);
            Controls.Add(button_WorkingSpace2_2);
            Controls.Add(button_WorkingSpace2_1);
            Name = "Form_WorkingSpace2";
            Text = "Form_WorkingSpace2";
            ResumeLayout(false);
        }

        #endregion

        private Button button_WorkingSpace2_1;
        private Button button_WorkingSpace2_2;
        private Label label1;
    }
}