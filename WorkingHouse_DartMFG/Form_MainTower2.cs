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
    public partial class Form_MainTower2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_MainTower2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_MainTower2_1_Click(object sender, EventArgs e) // К КОМНАТАМ
        {
            Form_Hall_Rooms2 Hall_Rooms2 = new Form_Hall_Rooms2(inventory, menu);
            Hall_Rooms2.Show();
            Close();
        }

        private void button_MainTower2_2_Click(object sender, EventArgs e) // В ЦЕХ
        {
            Form_WorkingSpace2 WorkingSpace2 = new Form_WorkingSpace2(inventory, menu);
            WorkingSpace2.Show();
            Close();
        }

        private void button_MainTower2_3_Click(object sender, EventArgs e) // СПУСТИТЬСЯ
        {
            Form_MainTower1 MainTower1 = new Form_MainTower1(inventory, menu);
            MainTower1.Show();
            Close();
        }

        private void button_MainTower2_4_Click(object sender, EventArgs e) // В ТУПИК
        {
            MessageBox.Show("Дверь закрыта","[TERMINAL-79]",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
