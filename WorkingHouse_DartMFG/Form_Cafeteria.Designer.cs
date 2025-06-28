using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    partial class Form_Cafeteria
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
            button_Cafeteria1 = new Button();
            button_Cafeteria2 = new Button();
            button_Cafeteria3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button_Cafeteria1
            // 
            button_Cafeteria1.Font = new Font("Times New Roman", 14F);
            button_Cafeteria1.Location = new Point(30, 720);
            button_Cafeteria1.Name = "button_Cafeteria1";
            button_Cafeteria1.Size = new Size(200, 30);
            button_Cafeteria1.TabIndex = 8;
            button_Cafeteria1.Text = "ВЫЙТИ ВО ДВОР";
            button_Cafeteria1.UseVisualStyleBackColor = true;
            button_Cafeteria1.Click += button_Cafeteria1_Click;
            // 
            // button_Cafeteria2
            // 
            button_Cafeteria2.Font = new Font("Times New Roman", 14F);
            button_Cafeteria2.Location = new Point(236, 720);
            button_Cafeteria2.Name = "button_Cafeteria2";
            button_Cafeteria2.Size = new Size(200, 30);
            button_Cafeteria2.TabIndex = 9;
            button_Cafeteria2.Text = "ПОЙТИ В КОРИДОР";
            button_Cafeteria2.UseVisualStyleBackColor = true;
            button_Cafeteria2.Click += button_Cafeteria2_Click;
            // 
            // button_Cafeteria3
            // 
            button_Cafeteria3.Font = new Font("Times New Roman", 14F);
            button_Cafeteria3.Location = new Point(442, 720);
            button_Cafeteria3.Name = "button_Cafeteria3";
            button_Cafeteria3.Size = new Size(200, 30);
            button_Cafeteria3.TabIndex = 10;
            button_Cafeteria3.Text = "ПОЙТИ В ФОЙЕ";
            button_Cafeteria3.UseVisualStyleBackColor = true;
            button_Cafeteria3.Click += button_Cafeteria3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(325, 375);
            label1.Name = "label1";
            label1.Size = new Size(163, 291);
            label1.TabIndex = 11;
            label1.Text = "Shop";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(494, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 116);
            this.label2.TabIndex = 12;
            this.label2.Text = "Portrait";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 550);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 13;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(191, 434);
            label4.Name = "label4";
            label4.Size = new Size(68, 232);
            label4.TabIndex = 14;
            label4.Text = "Агата Харрисон";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(82, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 188);
            this.label5.TabIndex = 15;
            this.label5.Text = "Джон Грэй";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(2, 494);
            label6.Name = "label6";
            label6.Size = new Size(46, 188);
            label6.TabIndex = 16;
            label6.Text = "Майкл Смит";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(580, 415);
            label7.Name = "label7";
            label7.Size = new Size(101, 302);
            label7.TabIndex = 17;
            label7.Text = "Диалог с Калебом Крайем";
            label7.Click += label7_Click;
            // 
            // Form_Cafeteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_5397697899141395521_x__1_;
            ClientSize = new Size(804, 781);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Cafeteria3);
            Controls.Add(button_Cafeteria2);
            Controls.Add(button_Cafeteria1);
            Name = "Form_Cafeteria";
            Text = "Form_Cafeteria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Cafeteria1;
        private Button button_Cafeteria2;
        private Button button_Cafeteria3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}