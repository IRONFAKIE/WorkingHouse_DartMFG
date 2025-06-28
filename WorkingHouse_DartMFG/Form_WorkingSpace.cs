using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class Form_WorkingSpace : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;

        public Form_WorkingSpace(Form_Inventory inventory, Form_MainMenu menu)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.menu = menu;

 
            label1.Click += Label1_Click;
            label2.Click += Label1_Click;
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form_WorkingProcess workProcess = new Form_WorkingProcess();
            workProcess.FormClosed += (s, args) => this.Show(); // Показываем эту форму при закрытии рабочего процесса
            workProcess.Show();
            this.Hide();
        }

        private void button_WorkingSpace_1_Click(object sender, EventArgs e)
        {
            Form_Outside Outside = new Form_Outside(inventory, menu);
            Outside.Show();
            Close();
        }

        private void button_WorkingSpace_2_Click(object sender, EventArgs e)
        {
            Form_MainTower1 MainTower1 = new Form_MainTower1(inventory, menu);
            MainTower1.Show();
            Close();
        }

        private void button_WorkingSpace_3_Click(object sender, EventArgs e)
        {
            Form_WorkingSpace2 workingSpace2 = new Form_WorkingSpace2(inventory, menu);
            workingSpace2.Show();
            Close();
        }
    }
}