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
    public partial class Form_Hall_Rooms2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Hall_Rooms2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_Rooms2_1_Click(object sender, EventArgs e) // в башню
        {
            Form_MainTower2 MainTower2 = new Form_MainTower2(inventory, menu);
            MainTower2.Show();
            Close();
        }

        private void button_Hall_Rooms2_2_Click(object sender, EventArgs e) // комната 3
        {
            Form_Room3 Room3 = new Form_Room3(inventory, menu);
            Room3.Show();
            Close();
        }

        private void button_Hall_Rooms2_3_Click(object sender, EventArgs e) // комната 4
        {
            Form_Room4 Room4 = new Form_Room4(inventory, menu);
            Room4.Show();
            Close();
        }

        private void button_Hall_Rooms2_4_Click(object sender, EventArgs e) // в медблок
        {
            Form_Hall_B1 Hall_B1 = new Form_Hall_B1(inventory, menu);
            Hall_B1.Show();
            Close();
        }
    }
}
