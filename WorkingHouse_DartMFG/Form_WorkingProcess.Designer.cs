namespace WorkingHouse_DartMFG
{
    partial class Form_WorkingProcess
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
            components = new System.ComponentModel.Container();
            progressBar_WorkInProcess = new ProgressBar();
            label_Request = new Label();
            trackBar_Parametr1 = new TrackBar();
            trackBar_Parametr2 = new TrackBar();
            trackBar_Parametr3 = new TrackBar();
            button_Working = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar_Parametr1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Parametr2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Parametr3).BeginInit();
            SuspendLayout();
            // 
            // progressBar_WorkInProcess
            // 
            progressBar_WorkInProcess.Location = new Point(12, 219);
            progressBar_WorkInProcess.Name = "progressBar_WorkInProcess";
            progressBar_WorkInProcess.Size = new Size(400, 30);
            progressBar_WorkInProcess.TabIndex = 11;
            progressBar_WorkInProcess.Click += progressBar_WorkInProcess_Click;
            // 
            // label_Request
            // 
            label_Request.Font = new Font("Times New Roman", 14F);
            label_Request.Location = new Point(418, 20);
            label_Request.Name = "label_Request";
            label_Request.Size = new Size(370, 126);
            label_Request.TabIndex = 14;
            label_Request.Text = "Текущий заказ:";
            // 
            // trackBar_Parametr1
            // 
            trackBar_Parametr1.Location = new Point(12, 20);
            trackBar_Parametr1.Name = "trackBar_Parametr1";
            trackBar_Parametr1.Size = new Size(400, 45);
            trackBar_Parametr1.TabIndex = 8;
            // 
            // trackBar_Parametr2
            // 
            trackBar_Parametr2.Location = new Point(12, 82);
            trackBar_Parametr2.Name = "trackBar_Parametr2";
            trackBar_Parametr2.Size = new Size(400, 45);
            trackBar_Parametr2.TabIndex = 9;
            trackBar_Parametr2.Scroll += trackBar1_Scroll;
            // 
            // trackBar_Parametr3
            // 
            trackBar_Parametr3.Location = new Point(12, 146);
            trackBar_Parametr3.Name = "trackBar_Parametr3";
            trackBar_Parametr3.Size = new Size(400, 45);
            trackBar_Parametr3.TabIndex = 10;
            // 
            // button_Working
            // 
            button_Working.Font = new Font("Times New Roman", 12F);
            button_Working.Location = new Point(418, 219);
            button_Working.Name = "button_Working";
            button_Working.Size = new Size(370, 30);
            button_Working.TabIndex = 12;
            button_Working.Text = "РАБОТАТЬ";
            button_Working.UseVisualStyleBackColor = true;
            button_Working.Click += button_Working_Click;
            button_Working.MouseDown += Button_Working_MouseDown;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_WorkingProcess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 261);
            Controls.Add(button_Working);
            Controls.Add(label_Request);
            Controls.Add(progressBar_WorkInProcess);
            Controls.Add(trackBar_Parametr3);
            Controls.Add(trackBar_Parametr2);
            Controls.Add(trackBar_Parametr1);
            Name = "Form_WorkingProcess";
            Text = "Рабочий процесс";
            ((System.ComponentModel.ISupportInitialize)trackBar_Parametr1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Parametr2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar_Parametr3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_WorkInProcess;
        private System.Windows.Forms.Label label_Request;
        private System.Windows.Forms.TrackBar trackBar_Parametr1;
        private System.Windows.Forms.TrackBar trackBar_Parametr2;
        private System.Windows.Forms.TrackBar trackBar_Parametr3;
        private System.Windows.Forms.Button button_Working;
        private System.Windows.Forms.Timer timer1;
    }
}