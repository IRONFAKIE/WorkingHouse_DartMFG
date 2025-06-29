using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Buro : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        private bool bookTaken = false;
        private bool crystalsTaken = false;

        public Form_Buro(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
            label1.Cursor = Cursors.Hand;
            label2.Cursor = Cursors.Hand;
        }

        private void button_Buro_1_Click(object sender, EventArgs e)
        {
            Form_TehnicalRoom TehnicalRoom = new Form_TehnicalRoom(inventory, menu);
            TehnicalRoom.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!bookTaken)
            {
                inventory.addItem("КНИГА");
                MessageBox.Show("ВЫ ПОЛУЧИЛИ ПРЕДМЕТ \"КНИГА\"", "Находка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                bookTaken = true;
                label1.Text = "Здесь пусто";
            }
            else
            {
                MessageBox.Show("Вы уже взяли книгу отсюда", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!crystalsTaken)
            {
                inventory.addItem("СИНИЕ КРИСТАЛЛЫ");
                MessageBox.Show("ВЫ ПОЛУЧИЛИ ПРЕДМЕТ \"СИНИЕ КРИСТАЛЛЫ\"", "Находка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                crystalsTaken = true;
                label2.Text = "Здесь пусто";
            }
            else
            {
                MessageBox.Show("Вы уже взяли кристаллы отсюда", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}