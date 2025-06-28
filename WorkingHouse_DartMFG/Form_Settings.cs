using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Settings : Form
    {
        private Form_Inventory inventory;

        public Form_Settings(Form_Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void hScrollBar_Loud_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar_Loud.Value != 0)
            {
                MessageBox.Show("Разговор только во время перерыва!", "[TERMINAL-79.02]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hScrollBar_Loud.Value = 0;
            }
        }

        private void hScrollBar_MouseSensetive_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBar_MouseSensetive.Value < 75)
            {
                MessageBox.Show("Скорость рук повышает производительность!", "[TERMINAL-79.02]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hScrollBar_MouseSensetive.Value = 75;
            }
        }

        private void numericUpDown_DifficultMode_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_DifficultMode.Value != 4)
            {
                MessageBox.Show("Господин не даст испытаний больше, чем ты выдежишь!", "[TERMINAL-79.02]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown_DifficultMode.Value = 4;
            }
        }

        private void checkBox_Podskazki_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Podskazki.Checked == true)
            {
                MessageBox.Show("Господин не даст испытаний больше, чем ты выдежишь!", "[TERMINAL-79.02]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox_Podskazki.Checked = false;
            }
        }

        private void checkBox_ActorVoice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ActorVoice.Checked == true)
            {
                MessageBox.Show("Болтать - не мешки ворочить!", "[TERMINAL-79.02]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox_ActorVoice.Checked = false;
            }
        }

        private void checkBox_BloodExist_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_BloodExist.Checked == false)
            {
                MessageBox.Show("Пролитая кровь, напоминает чернии о её положении в обществе!", "[TERMINAL-79.02]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox_BloodExist.Checked = true;
            }
        }

        private void button_Settings_ToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
