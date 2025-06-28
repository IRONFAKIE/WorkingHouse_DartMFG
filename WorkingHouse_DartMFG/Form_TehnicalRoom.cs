using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_TehnicalRoom : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_TehnicalRoom(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_TehnicalRoom_1_Click(object sender, EventArgs e)
        {
            Form_Foie_Left FoieL = new Form_Foie_Left(inventory, menu);
            FoieL.Show();
            Close();
        }

        private void button_TehnicalRoom_2_Click(object sender, EventArgs e)
        {
            Form_Buro Buro = new Form_Buro(inventory, menu);
            Buro.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}