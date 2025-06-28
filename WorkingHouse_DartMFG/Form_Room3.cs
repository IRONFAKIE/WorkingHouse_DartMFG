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
    public partial class Form_Room3 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Room3(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Room3_1_Click(object sender, EventArgs e) // ВЫЙТИ
        {
            Form_Hall_Rooms2 Hall_Room2 = new Form_Hall_Rooms2(inventory, menu);
            Hall_Room2.Show();
            Close();
        }
    }
}
