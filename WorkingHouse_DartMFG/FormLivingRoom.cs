using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class FormLivingRoom : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public FormLivingRoom(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_LivingRoom_1_Click(object sender, EventArgs e) // ВЫЙТИ
        {
            Form_Hall_ADM3 Hall3 = new Form_Hall_ADM3(inventory, menu);
            Hall3.Show();
            Close();
        }

        private void button_LivingRoom_2_Click(object sender, EventArgs e) // В спальню
        {
            Form_BedRoom Bedroom = new Form_BedRoom(inventory);
            Bedroom.Show(); Close();
        }
    }
}
