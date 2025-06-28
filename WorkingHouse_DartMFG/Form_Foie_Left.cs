using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Foie_Left : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Foie_Left(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_FoieC_2_Click(object sender, EventArgs e) // ЦЕНТР ФОЙЕ
        {
            Form_Foie_Centre FoieCentre = new Form_Foie_Centre(inventory, menu);
            FoieCentre.Show();
            Close();
        }

        private void button_FoieL_2_Click(object sender, EventArgs e) // СТОЛОВАЯ
        {
            Form_Cafeteria Cafeteria = new Form_Cafeteria(inventory, menu);
            Cafeteria.Show();
            Close();
        }

        private void button_FoieL_3_Click(object sender, EventArgs e) // В ТЕХКОМНАТУ
        {
            Form_TehnicalRoom TehnicalRoom = new Form_TehnicalRoom(inventory, menu);
            TehnicalRoom.Show();
            Close();
        }
    }
}