using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Kitchen : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Kitchen(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Kitchen1_Click(object sender, EventArgs e)
        {
            Form_Hall_Cafeteria Hall = new Form_Hall_Cafeteria(inventory, menu);
            Hall.Show();
            Close();
        }
    }
}