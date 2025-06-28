using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Hall_A1 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Hall_A1(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_A1_1_Click(object sender, EventArgs e)
        {
            Form_Foie_Centre FoieCentre = new Form_Foie_Centre(inventory, menu);
            FoieCentre.Show();
            Close();
        }

        private void button_Hall_A1_2_Click(object sender, EventArgs e)
        {
            Form_MainTower1 MainTower1 = new Form_MainTower1(inventory, menu);
            MainTower1.Show();
            Close();
        }
    }
}