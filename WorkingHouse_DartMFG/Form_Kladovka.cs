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
    public partial class Form_Kladovka : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Kladovka(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Kladovka_1_Click(object sender, EventArgs e) // В ФОЙЕ
        {
            Form_Foie_Right FoieR = new Form_Foie_Right(inventory, menu);
            FoieR.Show();
            Close();
        }
    }
}
