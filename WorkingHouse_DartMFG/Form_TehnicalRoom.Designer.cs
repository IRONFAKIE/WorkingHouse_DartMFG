namespace WorkingHouse_DartMFG
{
    partial class Form_TehnicalRoom
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
            button_TehnicalRoom_1 = new Button();
            button_TehnicalRoom_2 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_TehnicalRoom_1
            // 
            button_TehnicalRoom_1.Font = new Font("Times New Roman", 14F);
            button_TehnicalRoom_1.Location = new Point(30, 720);
            button_TehnicalRoom_1.Name = "button_TehnicalRoom_1";
            button_TehnicalRoom_1.Size = new Size(200, 30);
            button_TehnicalRoom_1.TabIndex = 16;
            button_TehnicalRoom_1.Text = "ВЫЙТИ";
            button_TehnicalRoom_1.UseVisualStyleBackColor = true;
            button_TehnicalRoom_1.Click += button_TehnicalRoom_1_Click;
            // 
            // button_TehnicalRoom_2
            // 
            button_TehnicalRoom_2.Font = new Font("Times New Roman", 14F);
            button_TehnicalRoom_2.Location = new Point(236, 720);
            button_TehnicalRoom_2.Name = "button_TehnicalRoom_2";
            button_TehnicalRoom_2.Size = new Size(200, 30);
            button_TehnicalRoom_2.TabIndex = 17;
            button_TehnicalRoom_2.Text = "ЗАЙТИ К ВАХТЁРУ";
            button_TehnicalRoom_2.UseVisualStyleBackColor = true;
            button_TehnicalRoom_2.Click += button_TehnicalRoom_2_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(495, 313);
            label2.Name = "label2";
            label2.Size = new Size(192, 148);
            label2.TabIndex = 18;
            label2.Text = "Обыск";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(316, 267);
            label1.Name = "label1";
            label1.Size = new Size(136, 389);
            label1.TabIndex = 19;
            label1.Text = "Обыск?";
            label1.Click += label1_Click;
            // 
            // Form_TehnicalRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395524_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button_TehnicalRoom_2);
            Controls.Add(button_TehnicalRoom_1);
            Name = "Form_TehnicalRoom";
            Text = "Form_TehnicalRoom";
            ResumeLayout(false);
        }

        #endregion

        private Button button_TehnicalRoom_1;
        private Button button_TehnicalRoom_2;
        private Label label2;
        private Label label1;
    }
}