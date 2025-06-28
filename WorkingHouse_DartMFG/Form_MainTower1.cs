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
    public partial class Form_MainTower1 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_MainTower1(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_MainTower1_1_Click(object sender, EventArgs e) // К ФОЙЕ
        {
            Form_Hall_A1 Hall = new Form_Hall_A1(inventory, menu);
            Hall.Show();
            Close();
        }

        private void button_MainTower1_2_Click(object sender, EventArgs e) // В ЦЕХ
        {
            Form_WorkingSpace WorkingSpace = new Form_WorkingSpace(inventory, menu);
            WorkingSpace.Show();
            Close();
        }

        private void button_MainTower1_3_Click(object sender, EventArgs e) // ЛЕСТНИЦА
        {
            Form_MainTower1 mainTower1 = new Form_MainTower1(inventory, menu);
            mainTower1.Show();
            Close();
        }
    }
}
