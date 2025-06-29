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
    public partial class Form_Store : Form
    {
        private Form_Inventory mainForm;
        private Form_Cafeteria cafeteriaForm;

        public Form_Store(Form_Inventory form, Form_Cafeteria cafeteria)
        {
            InitializeComponent();
            this.mainForm = form;
            this.cafeteriaForm = cafeteria;
            this.MouseWheel += Form_Store_MouseWheel;
            this.FormClosed += Form_Store_FormClosed;
        }

        private void Form_Store_FormClosed(object sender, FormClosedEventArgs e)
        {
            cafeteriaForm?.Show();
        }

        private void Form_Store_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                mainForm.ShowForm_Inventory();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 0.25)
            {
                mainForm.minusPound(0.25);
                mainForm.addItem("БАЛАНДА");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 0.10)
            {
                mainForm.minusPound(0.10);
                mainForm.addItem("ПЫЛЬНЫЙ ХЛЕБ");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 0.45)
            {
                mainForm.minusPound(0.45);
                mainForm.addItem("РЖАННАЯ БУЛОЧКА");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 0.05)
            {
                mainForm.minusPound(0.05);
                mainForm.addItem("ЯБЛОКО");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 1.00)
            {
                mainForm.minusPound(1.00);
                mainForm.addItem("ШВЕЙНЫЙ НАБОР");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 5.00)
            {
                mainForm.minusPound(5.00);
                mainForm.addItem("ИГРУШКА");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 1.50)
            {
                mainForm.minusPound(1.50);
                mainForm.addItem("ШАЛЬ");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 2.75)
            {
                mainForm.minusPound(2.75);
                mainForm.addItem("ВИСКИ \"BOGATOE\"");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mainForm.GetPounds() >= 2.00)
            {
                mainForm.minusPound(2.00);
                mainForm.addItem("ВИСКИ \"NIZCHIE\"");
            }
            else
            {
                MessageBox.Show("Недостаточно фунтов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}