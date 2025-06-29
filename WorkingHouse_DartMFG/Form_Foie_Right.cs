using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Foie_Right : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Foie_Right(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_FoieR_1_Click(object sender, EventArgs e)
        {
            Form_Foie_Centre FoieCentre = new Form_Foie_Centre(inventory, menu);
            FoieCentre.Show();
            Close();
        }

        private void button_FoieR_2_Click(object sender, EventArgs e)
        {
            Form_StairWay_ADM1 stairWay_ADM1 = new Form_StairWay_ADM1(inventory, menu);
            stairWay_ADM1.Show();
            Close();
        }

        private void button_FoieR_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Закрыто", "[TERMINAL-79]", MessageBoxButtons.OK);
        }

        private void button_FoieR_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Закрыто", "[TERMINAL-79]", MessageBoxButtons.OK);
        }
    }
}