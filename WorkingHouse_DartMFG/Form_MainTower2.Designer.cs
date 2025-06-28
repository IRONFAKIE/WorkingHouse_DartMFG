namespace WorkingHouse_DartMFG
{
    partial class Form_MainTower2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainTower2));
            button_MainTower2_1 = new Button();
            button_MainTower2_2 = new Button();
            button_MainTower2_3 = new Button();
            button_MainTower2_4 = new Button();
            SuspendLayout();
            // 
            // button_MainTower2_1
            // 
            button_MainTower2_1.Font = new Font("Times New Roman", 14F);
            button_MainTower2_1.Location = new Point(30, 684);
            button_MainTower2_1.Name = "button_MainTower2_1";
            button_MainTower2_1.Size = new Size(240, 30);
            button_MainTower2_1.TabIndex = 17;
            button_MainTower2_1.Text = "К КОМНАТАМ";
            button_MainTower2_1.UseVisualStyleBackColor = true;
            button_MainTower2_1.Click += button_MainTower2_1_Click;
            // 
            // button_MainTower2_2
            // 
            button_MainTower2_2.Font = new Font("Times New Roman", 14F);
            button_MainTower2_2.Location = new Point(276, 684);
            button_MainTower2_2.Name = "button_MainTower2_2";
            button_MainTower2_2.Size = new Size(200, 30);
            button_MainTower2_2.TabIndex = 18;
            button_MainTower2_2.Text = "В ЦЕХ";
            button_MainTower2_2.UseVisualStyleBackColor = true;
            button_MainTower2_2.Click += button_MainTower2_2_Click;
            // 
            // button_MainTower2_3
            // 
            button_MainTower2_3.Font = new Font("Times New Roman", 14F);
            button_MainTower2_3.Location = new Point(482, 684);
            button_MainTower2_3.Name = "button_MainTower2_3";
            button_MainTower2_3.Size = new Size(200, 30);
            button_MainTower2_3.TabIndex = 19;
            button_MainTower2_3.Text = "СПУСТИТЬСЯ";
            button_MainTower2_3.UseVisualStyleBackColor = true;
            button_MainTower2_3.Click += button_MainTower2_3_Click;
            // 
            // button_MainTower2_4
            // 
            button_MainTower2_4.Font = new Font("Times New Roman", 14F);
            button_MainTower2_4.Location = new Point(30, 720);
            button_MainTower2_4.Name = "button_MainTower2_4";
            button_MainTower2_4.Size = new Size(240, 30);
            button_MainTower2_4.TabIndex = 20;
            button_MainTower2_4.Text = "К АДМИНИСТРАЦИИ";
            button_MainTower2_4.UseVisualStyleBackColor = true;
            button_MainTower2_4.Click += button_MainTower2_4_Click;
            // 
            // Form_MainTower2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 781);
            Controls.Add(button_MainTower2_4);
            Controls.Add(button_MainTower2_3);
            Controls.Add(button_MainTower2_2);
            Controls.Add(button_MainTower2_1);
            Name = "Form_MainTower2";
            Text = "Form_MainTower2";
            ResumeLayout(false);
        }

        #endregion

        private Button button_MainTower2_1;
        private Button button_MainTower2_2;
        private Button button_MainTower2_3;
        private Button button_MainTower2_4;
    }
}