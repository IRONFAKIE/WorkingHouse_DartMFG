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
    public partial class Form_HallA2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_HallA2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_A2_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дверь закрыта", "[TERMINAL-79]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Hall_A2_1_Click(object sender, EventArgs e)
        {
            Form_Hall_ADM2 Hall = new Form_Hall_ADM2(inventory, menu);
            Hall.Show();
            Close();
        }
    }
}
