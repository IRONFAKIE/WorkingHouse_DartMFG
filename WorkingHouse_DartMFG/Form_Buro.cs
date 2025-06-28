using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Buro : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Buro(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Buro_1_Click(object sender, EventArgs e)
        {
            Form_TehnicalRoom TehnicalRoom = new Form_TehnicalRoom(inventory, menu);
            TehnicalRoom.Show();
            Close();
        }
    }
}