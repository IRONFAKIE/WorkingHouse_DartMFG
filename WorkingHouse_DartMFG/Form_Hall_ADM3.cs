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
    public partial class Form_Hall_ADM3 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_Hall_ADM3(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Hall_ADM3_1_Click(object sender, EventArgs e) // В КВАРТИРУ
        {
            FormLivingRoom Livingroom = new FormLivingRoom(inventory, menu);
            Livingroom.Show();
            Close();
        }

        private void button_Hall_ADM3_2_Click(object sender, EventArgs e) // НА ЛЕСТНИЦУ
        {
            Form_StairWay_ADM1 StairWay = new Form_StairWay_ADM1(inventory, menu);
            StairWay.Show();
            Close();
        }
    }
}
