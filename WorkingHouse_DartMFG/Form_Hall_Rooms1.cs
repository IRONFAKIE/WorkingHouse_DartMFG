using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Hall_Rooms1 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Hall_Rooms1(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_Rooms1_1_Click(object sender, EventArgs e)
        {
            Form_Hall_Cafeteria Hall = new Form_Hall_Cafeteria(inventory, menu);
            Hall.Show();
            Close();
        }

        private void button_Hall_Rooms1_2_Click(object sender, EventArgs e)
        {
            Form_Room1 Room1 = new Form_Room1(inventory, menu);
            Room1.Show();
            Close();
        }

        private void button_Hall_Rooms1_3_Click(object sender, EventArgs e)
        {
            Form_Room2 Room2 = new Form_Room2(inventory, menu);
            Room2.Show();
            Close();
        }

        private void button_Hall_Rooms1_4_Click(object sender, EventArgs e)
        {
            Form_Garden Garden = new Form_Garden(inventory, menu);
            Garden.Show();
            Close();
        }
    }
}