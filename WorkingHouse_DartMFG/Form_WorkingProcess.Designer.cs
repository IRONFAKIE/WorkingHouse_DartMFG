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
            this.components = new System.ComponentModel.Container();
            this.progressBar_WorkInProcess = new System.Windows.Forms.ProgressBar();
            this.label_Request = new System.Windows.Forms.Label();
            this.trackBar_Parametr1 = new System.Windows.Forms.TrackBar();
            this.trackBar_Parametr2 = new System.Windows.Forms.TrackBar();
            this.trackBar_Parametr3 = new System.Windows.Forms.TrackBar();
            this.button_Working = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Parametr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Parametr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Parametr3)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_WorkInProcess
            // 
            this.progressBar_WorkInProcess.Location = new System.Drawing.Point(12, 219);
            this.progressBar_WorkInProcess.Name = "progressBar_WorkInProcess";
            this.progressBar_WorkInProcess.Size = new System.Drawing.Size(400, 30);
            this.progressBar_WorkInProcess.TabIndex = 11;
            this.progressBar_WorkInProcess.Click += new System.EventHandler(this.progressBar_WorkInProcess_Click);
            // 
            // label_Request
            // 
            this.label_Request.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label_Request.Location = new System.Drawing.Point(418, 20);
            this.label_Request.Name = "label_Request";
            this.label_Request.Size = new System.Drawing.Size(370, 126);
            this.label_Request.TabIndex = 14;
            this.label_Request.Text = "Текущий заказ:";
            // 
            // trackBar_Parametr1
            // 
            this.trackBar_Parametr1.Location = new System.Drawing.Point(12, 20);
            this.trackBar_Parametr1.Name = "trackBar_Parametr1";
            this.trackBar_Parametr1.Size = new System.Drawing.Size(400, 45);
            this.trackBar_Parametr1.TabIndex = 8;
            // 
            // trackBar_Parametr2
            // 
            this.trackBar_Parametr2.Location = new System.Drawing.Point(12, 82);
            this.trackBar_Parametr2.Name = "trackBar_Parametr2";
            this.trackBar_Parametr2.Size = new System.Drawing.Size(400, 45);
            this.trackBar_Parametr2.TabIndex = 9;
            this.trackBar_Parametr2.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar_Parametr3
            // 
            this.trackBar_Parametr3.Location = new System.Drawing.Point(12, 146);
            this.trackBar_Parametr3.Name = "trackBar_Parametr3";
            this.trackBar_Parametr3.Size = new System.Drawing.Size(400, 45);
            this.trackBar_Parametr3.TabIndex = 10;
            // 
            // button_Working
            // 
            this.button_Working.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button_Working.Location = new System.Drawing.Point(418, 219);
            this.button_Working.Name = "button_Working";
            this.button_Working.Size = new System.Drawing.Size(370, 30);
            this.button_Working.TabIndex = 12;
            this.button_Working.Text = "РАБОТАТЬ";
            this.button_Working.UseVisualStyleBackColor = true;
            this.button_Working.Click += new System.EventHandler(this.button_Working_Click);
            this.button_Working.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Working_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_WorkingProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.button_Working);
            this.Controls.Add(this.label_Request);
            this.Controls.Add(this.progressBar_WorkInProcess);
            this.Controls.Add(this.trackBar_Parametr3);
            this.Controls.Add(this.trackBar_Parametr2);
            this.Controls.Add(this.trackBar_Parametr1);
            this.Name = "Form_WorkingProcess";
            this.Text = "Рабочий процесс";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Parametr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Parametr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Parametr3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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