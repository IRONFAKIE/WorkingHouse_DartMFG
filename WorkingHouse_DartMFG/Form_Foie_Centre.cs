using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Foie_Centre : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Foie_Centre(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_FoieC_1_Click(object sender, EventArgs e)
        {
            Form_Foie_Left FoieLeft = new Form_Foie_Left(inventory, menu);
            FoieLeft.Show();
            Close();
        }

        private void button_FoieC_2_Click(object sender, EventArgs e)
        {
            Form_Hall_A1 HallA1 = new Form_Hall_A1(inventory, menu);
            HallA1.Show();
            Close();
        }

        private void button_FoieC_3_Click(object sender, EventArgs e)
        {
            Form_Foie_Right FoieRight = new Form_Foie_Right(inventory, menu);
            FoieRight.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormDarkShop darkShop = new FormDarkShop(inventory);
            darkShop.FormClosed += (s, args) => this.Show();
            darkShop.Show();
            this.Hide();
        }
    }
}