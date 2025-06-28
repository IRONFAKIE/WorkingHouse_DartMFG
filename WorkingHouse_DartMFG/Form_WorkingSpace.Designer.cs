namespace WorkingHouse_DartMFG
{
    partial class Form_WorkingSpace
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
            button_WorkingSpace_1 = new Button();
            button_WorkingSpace_2 = new Button();
            button_WorkingSpace_3 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_WorkingSpace_1
            // 
            button_WorkingSpace_1.Font = new Font("Times New Roman", 14F);
            button_WorkingSpace_1.Location = new Point(30, 720);
            button_WorkingSpace_1.Name = "button_WorkingSpace_1";
            button_WorkingSpace_1.Size = new Size(200, 30);
            button_WorkingSpace_1.TabIndex = 14;
            button_WorkingSpace_1.Text = "ВЫЙТИ ВО ДВОР";
            button_WorkingSpace_1.UseVisualStyleBackColor = true;
            button_WorkingSpace_1.Click += button_WorkingSpace_1_Click;
            // 
            // button_WorkingSpace_2
            // 
            button_WorkingSpace_2.Font = new Font("Times New Roman", 14F);
            button_WorkingSpace_2.Location = new Point(236, 720);
            button_WorkingSpace_2.Name = "button_WorkingSpace_2";
            button_WorkingSpace_2.Size = new Size(200, 30);
            button_WorkingSpace_2.TabIndex = 15;
            button_WorkingSpace_2.Text = "ПОЙТИ В БАШНЮ";
            button_WorkingSpace_2.UseVisualStyleBackColor = true;
            button_WorkingSpace_2.Click += button_WorkingSpace_2_Click;
            // 
            // button_WorkingSpace_3
            // 
            button_WorkingSpace_3.Font = new Font("Times New Roman", 14F);
            button_WorkingSpace_3.Location = new Point(442, 720);
            button_WorkingSpace_3.Name = "button_WorkingSpace_3";
            button_WorkingSpace_3.Size = new Size(200, 30);
            button_WorkingSpace_3.TabIndex = 16;
            button_WorkingSpace_3.Text = "ПОДНЯТЬСЯ";
            button_WorkingSpace_3.UseVisualStyleBackColor = true;
            button_WorkingSpace_3.Click += button_WorkingSpace_3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 535);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;


            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(170, 442);
            label2.Name = "label2";
            label2.Size = new Size(407, 203);
            label2.TabIndex = 20;
            label2.Text = "Работать";
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // Form_WorkingSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395523_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_WorkingSpace_3);
            Controls.Add(button_WorkingSpace_2);
            Controls.Add(button_WorkingSpace_1);
            Name = "Form_WorkingSpace";
            Text = "Form_WorkingSpace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_WorkingSpace_1;
        private Button button_WorkingSpace_2;
        private Button button_WorkingSpace_3;
        private Label label1;
        private Label label2;
    }
}