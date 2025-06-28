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
    public partial class Form_Hall_ADM2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Hall_ADM2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_ADM2_1_Click(object sender, EventArgs e) // Лестница
        {
            Form_StairWay_ADM1 Stairway = new Form_StairWay_ADM1(inventory, menu);
            Stairway.Show();
            Close();
        }

        private void button_Hall_ADM2_2_Click(object sender, EventArgs e) // Кабинет
        {
            Form_Cabinet cabinet = new Form_Cabinet(inventory, menu);
            cabinet.Show();
            Close();
        }

        private void button_Hall_ADM2_3_Click(object sender, EventArgs e) // Архив
        {
            Form_Archive Archive = new Form_Archive(inventory, menu);
            Archive.Show();
            Close();
        }

        private void button_Hall_ADM2_4_Click(object sender, EventArgs e) // Медблок
        {
            Form_Hall_B2 Hall_B2 = new Form_Hall_B2(inventory, menu);
            Hall_B2.Show();
            Close();
        }

        private void button_Hall_ADM2_5_Click(object sender, EventArgs e) // К ТУПИКУ
        {
            Form_HallA2 Hall_A2 = new Form_HallA2(inventory, menu);
            Hall_A2.Show();
            Close();
        }
    }
}
