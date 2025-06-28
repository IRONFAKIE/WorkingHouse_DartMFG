using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Storage : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Storage(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Storage1_Click(object sender, EventArgs e)
        {
            Form_Foie_Right FoieR = new Form_Foie_Right(inventory, menu);
            FoieR.Show();
            Close();
        }

        private void button_Storage2_Click(object sender, EventArgs e)
        {
            Form_Outside Outside = new Form_Outside(inventory, menu);
            Outside.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}