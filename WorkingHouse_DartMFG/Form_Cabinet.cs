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
    public partial class Form_Cabinet : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Cabinet(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Cabinet_1_Click(object sender, EventArgs e)
        {
            Form_Hall_ADM2 Hall_ADM2 = new Form_Hall_ADM2(inventory, menu);
            Hall_ADM2.Show();
            Close();
        }
    }
}
