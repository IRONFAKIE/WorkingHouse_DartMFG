using System.Windows.Forms;
using System.Xml.Linq;

namespace WorkingHouse_DartMFG
{
    partial class FormDarkShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDarkShop));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 196);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(526, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 196);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(12, 278);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(347, 160);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(374, 278);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(333, 160);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(255, 19);
            label1.Name = "label1";
            label1.Size = new Size(215, 29);
            label1.TabIndex = 4;
            label1.Text = "ЧЁРНЫЙ РЫНОК";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(199, 60);
            button1.Name = "button1";
            button1.Size = new Size(321, 34);
            button1.TabIndex = 5;
            button1.Text = "ШВЕЙНЫЙ НАБОР - 150 ОА";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(199, 100);
            button2.Name = "button2";
            button2.Size = new Size(321, 35);
            button2.TabIndex = 6;
            button2.Text = "ГНУТАЯ ПРОВОЛКА - 500 ОА";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(199, 141);
            button3.Name = "button3";
            button3.Size = new Size(321, 34);
            button3.TabIndex = 7;
            button3.Text = "РЕЗАК - 3000 ОА";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Arial", 11F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(199, 181);
            button4.Name = "button4";
            button4.Size = new Size(321, 34);
            button4.TabIndex = 8;
            button4.Text = "ТАЛОН НА УСИЛЕННЫЙ ПАЁК\" - 5000 ОА";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Arial", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(199, 221);
            button5.Name = "button5";
            button5.Size = new Size(321, 35);
            button5.TabIndex = 9;
            button5.Text = "ВИСКИ \"NIZCHIE\" - 300 ОА";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(719, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "ЧЁРНЫЙ РЫНОК";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}