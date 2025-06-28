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
    public partial class Form_Hall_B1 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Hall_B1(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_B1_1_Click(object sender, EventArgs e) // К КОМНАТАМ
        {
            Form_Hall_Rooms2 Hall_Rooms2 = new Form_Hall_Rooms2(inventory, menu);
            Hall_Rooms2.Show();
            Close();
        }

        private void button_Hall_B1_2_Click(object sender, EventArgs e) // МЕДРУНКТ
        {
            Form_Lasaret Lasaret = new Form_Lasaret(inventory, menu);
            Lasaret.Show();
            Close();
        }

        private void button_Hall_B1_3_Click(object sender, EventArgs e) // ЗА УГОЛ
        {
            Form_Hall_B2 Hall_B2 = new Form_Hall_B2(inventory, menu);
            Hall_B2.Show();
            Close();
        }
    }
}
