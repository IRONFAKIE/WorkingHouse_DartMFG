namespace WorkingHouse_DartMFG
{
    partial class Form_Buro
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
            button_Buro_1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_Buro_1
            // 
            button_Buro_1.Font = new Font("Times New Roman", 14F);
            button_Buro_1.Location = new Point(30, 720);
            button_Buro_1.Name = "button_Buro_1";
            button_Buro_1.Size = new Size(200, 30);
            button_Buro_1.TabIndex = 16;
            button_Buro_1.Text = "ВЫЙТИ";
            button_Buro_1.UseVisualStyleBackColor = true;
            button_Buro_1.Click += button_Buro_1_Click;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(466, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 395);
            this.label1.TabIndex = 17;
            this.label1.Text = "Обыск";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(100, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 221);
            this.label2.TabIndex = 18;
            this.label2.Text = "Обыск";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form_Buro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395525_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Buro_1);
            Name = "Form_Buro";
            Text = "Form_Buro";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Buro_1;
        private Label label1;
        private Label label2;
    }
}