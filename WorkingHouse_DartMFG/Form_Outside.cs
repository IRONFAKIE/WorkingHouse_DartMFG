using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Outside : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Outside(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Outside1_Click(object sender, EventArgs e) // НА СКЛАД
        {
            MessageBox.Show("Закрыто", "[TERMINAL-79]", MessageBoxButtons.OK);
            /*
            if (menu.IsDay)
            {
                Form_Storage Storage = new Form_Storage(inventory, menu);
                Storage.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Закрыто", "[TERMINAL-79]", MessageBoxButtons.OK);
            }
            */
        }

        private void button_Outside2_Click(object sender, EventArgs e) // В ЦЕХ
        {
            Form_WorkingSpace WorkingSpace = new Form_WorkingSpace(inventory, menu);
            WorkingSpace.Show();
            Close();
        }
    }
}