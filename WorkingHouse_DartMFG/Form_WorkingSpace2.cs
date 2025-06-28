using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_WorkingSpace2 : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_WorkingSpace2(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;

            // Добавляем обработчик клика по label1
            label1.Click += Label1_Click;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form_WorkingProcess workProcess = new Form_WorkingProcess();
            workProcess.FormClosed += (s, args) => this.Show(); // Показываем эту форму при закрытии рабочего процесса
            workProcess.Show();
            this.Hide();
        }

        private void button_WorkingSpace2_1_Click(object sender, EventArgs e)
        {
            Form_MainTower2 MainTower2 = new Form_MainTower2(inventory, menu);
            MainTower2.Show();
            Close();
        }

        private void button_WorkingSpace2_2_Click(object sender, EventArgs e)
        {
            Form_WorkingSpace workingSpace = new Form_WorkingSpace(inventory, menu);
            workingSpace.Show();
            Close();
        }
    }
}