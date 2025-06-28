using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_MainMenu : Form
    {
        public bool SoldatySpyat = false;
        public bool IsDay = true;
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_MainMenu(Form_Inventory inventory)
        {
            InitializeComponent();
            MessageBox.Show("Внимание!\nВ игре присутствует контент для лиц старше 16 лет! Игра не рекомендована беременным, впечетлительным, лицам страдающим эпилепсией и трипофобией и пр.!",
                          "[TERMINAL-79]",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Hand);
            this.inventory = inventory;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_WorkingSpace WorkingSpace = new Form_WorkingSpace(inventory, menu);
            WorkingSpace.ShowDialog();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            Form_Settings SETTINGS = new Form_Settings(inventory);
            SETTINGS.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Extra Extras = new Form_Extra(inventory);
            Extras.ShowDialog();
        }
    }
}