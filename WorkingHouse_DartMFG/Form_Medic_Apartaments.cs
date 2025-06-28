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
    public partial class Form_Medic_Apartaments : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Medic_Apartaments(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Medic_Apartaments_1_Click(object sender, EventArgs e) // В КОРИДОР
        {
            Form_Hall_B2 Hall_B2 = new Form_Hall_B2(inventory, menu);
            Hall_B2.Show();
            Close();
        }
    }
}
