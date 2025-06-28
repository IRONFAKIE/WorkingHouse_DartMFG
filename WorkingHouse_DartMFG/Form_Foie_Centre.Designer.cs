namespace WorkingHouse_DartMFG
{
    partial class Form_Foie_Centre
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
            button_FoieC_1 = new Button();
            button_FoieC_2 = new Button();
            button_FoieC_3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_FoieC_1
            // 
            button_FoieC_1.Font = new Font("Times New Roman", 14F);
            button_FoieC_1.Location = new Point(30, 720);
            button_FoieC_1.Name = "button_FoieC_1";
            button_FoieC_1.Size = new Size(220, 30);
            button_FoieC_1.TabIndex = 2;
            button_FoieC_1.Text = "ПОЙТИ К СТОЛОВОЙ";
            button_FoieC_1.UseVisualStyleBackColor = true;
            button_FoieC_1.Click += button_FoieC_1_Click;
            // 
            // button_FoieC_2
            // 
            button_FoieC_2.Font = new Font("Times New Roman", 14F);
            button_FoieC_2.Location = new Point(256, 720);
            button_FoieC_2.Name = "button_FoieC_2";
            button_FoieC_2.Size = new Size(220, 30);
            button_FoieC_2.TabIndex = 3;
            button_FoieC_2.Text = "ПРОЙТИ К БАШНЕ";
            button_FoieC_2.UseVisualStyleBackColor = true;
            button_FoieC_2.Click += button_FoieC_2_Click;
            // 
            // button_FoieC_3
            // 
            button_FoieC_3.Font = new Font("Times New Roman", 14F);
            button_FoieC_3.Location = new Point(482, 720);
            button_FoieC_3.Name = "button_FoieC_3";
            button_FoieC_3.Size = new Size(220, 30);
            button_FoieC_3.TabIndex = 4;
            button_FoieC_3.Text = "ПОЙТИ К СКЛАДУ";
            button_FoieC_3.UseVisualStyleBackColor = true;
            button_FoieC_3.Click += button_FoieC_3_Click;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(502, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 275);
            this.label1.TabIndex = 12;
            this.label1.Text = "Джек Вортинг";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Foie_Centre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395527_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label1);
            Controls.Add(button_FoieC_3);
            Controls.Add(button_FoieC_2);
            Controls.Add(button_FoieC_1);
            Name = "Form_Foie_Centre";
            Text = "Form_Foie_Centre";
            ResumeLayout(false);
        }

        #endregion

        private Button button_FoieC_1;
        private Button button_FoieC_2;
        private Button button_FoieC_3;
        private Label label1;
    }
}