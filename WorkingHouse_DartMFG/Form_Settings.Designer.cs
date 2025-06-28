namespace WorkingHouse_DartMFG
{
    partial class Form_Settings
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
            button_Settings_ToMainMenu = new Button();
            label4label_Settings_Options = new Label();
            checkBox_BloodExist = new CheckBox();
            checkBox_ActorVoice = new CheckBox();
            checkBox_Podskazki = new CheckBox();
            label_Settings_Difficult = new Label();
            numericUpDown_DifficultMode = new NumericUpDown();
            label_Settings_Sensetive = new Label();
            hScrollBar_MouseSensetive = new HScrollBar();
            label_Settings_Sound = new Label();
            hScrollBar_Loud = new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DifficultMode).BeginInit();
            SuspendLayout();
            // 
            // button_Settings_ToMainMenu
            // 
            button_Settings_ToMainMenu.Font = new Font("Times", 12F);
            button_Settings_ToMainMenu.Location = new Point(80, 340);
            button_Settings_ToMainMenu.Name = "button_Settings_ToMainMenu";
            button_Settings_ToMainMenu.Size = new Size(200, 30);
            button_Settings_ToMainMenu.TabIndex = 21;
            button_Settings_ToMainMenu.Text = "В ГЛАВНОЕ МЕНЮ";
            button_Settings_ToMainMenu.UseVisualStyleBackColor = true;
            button_Settings_ToMainMenu.Click += button_Settings_ToMainMenu_Click;
            // 
            // label4label_Settings_Options
            // 
            label4label_Settings_Options.Font = new Font("Times", 14F);
            label4label_Settings_Options.Location = new Point(30, 242);
            label4label_Settings_Options.Name = "label4label_Settings_Options";
            label4label_Settings_Options.Size = new Size(229, 30);
            label4label_Settings_Options.TabIndex = 20;
            label4label_Settings_Options.Text = "ОПЦИОНАЛЬНО";
            // 
            // checkBox_BloodExist
            // 
            checkBox_BloodExist.AutoSize = true;
            checkBox_BloodExist.Checked = true;
            checkBox_BloodExist.CheckState = CheckState.Checked;
            checkBox_BloodExist.Font = new Font("Segoe UI", 12F);
            checkBox_BloodExist.Location = new Point(261, 275);
            checkBox_BloodExist.Name = "checkBox_BloodExist";
            checkBox_BloodExist.Size = new Size(77, 25);
            checkBox_BloodExist.TabIndex = 19;
            checkBox_BloodExist.Text = "КРОВЬ";
            checkBox_BloodExist.UseVisualStyleBackColor = true;
            checkBox_BloodExist.CheckedChanged += checkBox_BloodExist_CheckedChanged;
            // 
            // checkBox_ActorVoice
            // 
            checkBox_ActorVoice.AutoSize = true;
            checkBox_ActorVoice.Font = new Font("Segoe UI", 12F);
            checkBox_ActorVoice.Location = new Point(157, 275);
            checkBox_ActorVoice.Name = "checkBox_ActorVoice";
            checkBox_ActorVoice.Size = new Size(98, 25);
            checkBox_ActorVoice.TabIndex = 18;
            checkBox_ActorVoice.Text = "ОЗВУЧКА";
            checkBox_ActorVoice.UseVisualStyleBackColor = true;
            checkBox_ActorVoice.CheckedChanged += checkBox_ActorVoice_CheckedChanged;
            // 
            // checkBox_Podskazki
            // 
            checkBox_Podskazki.AutoSize = true;
            checkBox_Podskazki.Font = new Font("Segoe UI", 12F);
            checkBox_Podskazki.Location = new Point(30, 275);
            checkBox_Podskazki.Name = "checkBox_Podskazki";
            checkBox_Podskazki.Size = new Size(122, 25);
            checkBox_Podskazki.TabIndex = 17;
            checkBox_Podskazki.Text = "ПОДСКАЗКИ";
            checkBox_Podskazki.UseVisualStyleBackColor = true;
            checkBox_Podskazki.CheckedChanged += checkBox_Podskazki_CheckedChanged;
            // 
            // label_Settings_Difficult
            // 
            label_Settings_Difficult.Font = new Font("Times", 14F);
            label_Settings_Difficult.Location = new Point(30, 196);
            label_Settings_Difficult.Name = "label_Settings_Difficult";
            label_Settings_Difficult.Size = new Size(229, 30);
            label_Settings_Difficult.TabIndex = 16;
            label_Settings_Difficult.Text = "УРОВЕНЬ СЛОЖНОСТИ";
            // 
            // numericUpDown_DifficultMode
            // 
            numericUpDown_DifficultMode.Font = new Font("Times", 12F);
            numericUpDown_DifficultMode.Location = new Point(283, 195);
            numericUpDown_DifficultMode.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown_DifficultMode.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_DifficultMode.Name = "numericUpDown_DifficultMode";
            numericUpDown_DifficultMode.Size = new Size(34, 26);
            numericUpDown_DifficultMode.TabIndex = 15;
            numericUpDown_DifficultMode.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown_DifficultMode.ValueChanged += numericUpDown_DifficultMode_ValueChanged;
            // 
            // label_Settings_Sensetive
            // 
            label_Settings_Sensetive.Font = new Font("Times", 14F);
            label_Settings_Sensetive.Location = new Point(30, 111);
            label_Settings_Sensetive.Name = "label_Settings_Sensetive";
            label_Settings_Sensetive.Size = new Size(287, 30);
            label_Settings_Sensetive.TabIndex = 14;
            label_Settings_Sensetive.Text = "ЧУВСТВИТЕЛЬНОСТЬ МЫШИ";
            // 
            // hScrollBar_MouseSensetive
            // 
            hScrollBar_MouseSensetive.Location = new Point(30, 141);
            hScrollBar_MouseSensetive.Name = "hScrollBar_MouseSensetive";
            hScrollBar_MouseSensetive.Size = new Size(287, 30);
            hScrollBar_MouseSensetive.TabIndex = 13;
            hScrollBar_MouseSensetive.Value = 90;
            hScrollBar_MouseSensetive.Scroll += hScrollBar_MouseSensetive_Scroll;
            // 
            // label_Settings_Sound
            // 
            label_Settings_Sound.Font = new Font("Times", 14F);
            label_Settings_Sound.Location = new Point(30, 30);
            label_Settings_Sound.Name = "label_Settings_Sound";
            label_Settings_Sound.Size = new Size(150, 30);
            label_Settings_Sound.TabIndex = 12;
            label_Settings_Sound.Text = "ЗВУК";
            // 
            // hScrollBar_Loud
            // 
            hScrollBar_Loud.Location = new Point(30, 60);
            hScrollBar_Loud.Name = "hScrollBar_Loud";
            hScrollBar_Loud.Size = new Size(287, 30);
            hScrollBar_Loud.TabIndex = 11;
            hScrollBar_Loud.Scroll += hScrollBar_Loud_Scroll;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 431);
            Controls.Add(button_Settings_ToMainMenu);
            Controls.Add(label4label_Settings_Options);
            Controls.Add(checkBox_BloodExist);
            Controls.Add(checkBox_ActorVoice);
            Controls.Add(checkBox_Podskazki);
            Controls.Add(label_Settings_Difficult);
            Controls.Add(numericUpDown_DifficultMode);
            Controls.Add(label_Settings_Sensetive);
            Controls.Add(hScrollBar_MouseSensetive);
            Controls.Add(label_Settings_Sound);
            Controls.Add(hScrollBar_Loud);
            Name = "Form_Settings";
            Text = "Form_Settings";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_DifficultMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Settings_ToMainMenu;
        private Label label4label_Settings_Options;
        private CheckBox checkBox_BloodExist;
        private CheckBox checkBox_ActorVoice;
        private CheckBox checkBox_Podskazki;
        private Label label_Settings_Difficult;
        private NumericUpDown numericUpDown_DifficultMode;
        private Label label_Settings_Sensetive;
        private HScrollBar hScrollBar_MouseSensetive;
        private Label label_Settings_Sound;
        private HScrollBar hScrollBar_Loud;
    }
}