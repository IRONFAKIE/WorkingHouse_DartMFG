using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Room2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Room2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Room2_1_Click(object sender, EventArgs e)
        {
            Form_Hall_Rooms1 Hall = new Form_Hall_Rooms1(inventory, menu);
            Hall.Show();
            Close();
        }
    }
}