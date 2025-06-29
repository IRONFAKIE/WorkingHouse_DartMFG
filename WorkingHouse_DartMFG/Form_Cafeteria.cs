using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_Cafeteria : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_Cafeteria(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;
        }

        private void button_Cafeteria1_Click(object sender, EventArgs e)
        {
            Form_Garden Garden = new Form_Garden(inventory, menu);
            Garden.Show();
            Close();
        }

        private void button_Cafeteria2_Click(object sender, EventArgs e)
        {
            Form_Hall_Cafeteria HallCafeteria = new Form_Hall_Cafeteria(inventory, menu);
            HallCafeteria.Show();
            Close();
        }

        private void button_Cafeteria3_Click(object sender, EventArgs e)
        {
            Form_Foie_Left FoieL = new Form_Foie_Left(inventory, menu);
            FoieL.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form_Store Shop = new Form_Store(inventory, this);
            Shop.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) 
        {
            FormPaint portraitForm = new FormPaint();
            portraitForm.FormClosed += (s, args) => this.Show();
            portraitForm.Show();
            this.Hide();
        }
        private void label7_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e)
        {
            Form_JohnGray johnGrayForm = new Form_JohnGray(inventory);
            johnGrayForm.Show();
            this.Hide();
            johnGrayForm.FormClosed += (s, args) => this.Show();
        }
        private void label6_Click(object sender, EventArgs e) { }
    }
}