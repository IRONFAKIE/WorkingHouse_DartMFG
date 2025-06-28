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
    public partial class Form_StairWay_ADM1 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_StairWay_ADM1(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button1_Click(object sender, EventArgs e) // 1 Этаж
        {
            Form_Foie_Right FoieR = new Form_Foie_Right(inventory, menu);
            FoieR.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e) // 2 Этаж
        {
            Form_Hall_ADM2 Hall_ADM2 = new Form_Hall_ADM2(inventory, menu);
            Hall_ADM2.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e) // 3 Этаж
        {

        }
    }
}
