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
    public partial class Form_Hall_B2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Hall_B2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_B2_1_Click(object sender, EventArgs e) // В КВАРТИРУ
        {
            Form_Medic_Apartaments Apartament_M = new Form_Medic_Apartaments(inventory, menu);
            Apartament_M.Show();
            Close();
        }

        private void button_Hall_B2_2_Click(object sender, EventArgs e) // К МЕДПУНКТУ
        {
            Form_Hall_B1 Hall_B1 = new Form_Hall_B1(inventory, menu);
            Hall_B1.Show();
            Close();
        }

        private void button_Hall_B2_3_Click(object sender, EventArgs e) // В АДМИНИСТРАЦИЮ
        {
            Form_Hall_ADM2 Hall_ADM2 = new Form_Hall_ADM2(inventory, menu);
            Hall_ADM2.Show();
            Close();
        }
    }
}
