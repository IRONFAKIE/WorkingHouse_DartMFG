using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Hall_Cafeteria : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Hall_Cafeteria(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_Cafeteria1_Click(object sender, EventArgs e) // СТОЛОВАЯ
        {
            Form_Cafeteria Cafeteria = new Form_Cafeteria(inventory, menu);
            Cafeteria.Show();
            Close();
        }

        private void button_Hall_Cafeteria2_Click(object sender, EventArgs e) // КУХНЯ
        {
            Form_Kitchen Kitchen = new Form_Kitchen(inventory, menu);
            Kitchen.Show();
            Close();
        }

        private void button_Hall_Cafeteria3_Click(object sender, EventArgs e) // КОМНАТЫ
        {
            Form_Hall_Rooms1 Hall = new Form_Hall_Rooms1(inventory, menu);
            Hall.Show();
            Close();
        }
    }
}