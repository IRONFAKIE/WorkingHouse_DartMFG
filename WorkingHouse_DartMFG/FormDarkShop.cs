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
    public partial class FormDarkShop : Form
    {
        private Form_Inventory mainForm;

        public FormDarkShop(Form_Inventory form)
        {
            InitializeComponent();
            this.mainForm = form;
            this.MouseWheel += FormDarkShop_MouseWheel;
        }

        private void FormDarkShop_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                mainForm.ShowForm_Inventory();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm.GetAuthorityPoints() >= 150)
            {
                mainForm.minusOA(150);
                mainForm.addItem("ШВЕЙНЫЙ НАБОР");
            }
            else
            {
                MessageBox.Show("Недостаточно очков авторитета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainForm.GetAuthorityPoints() >= 500)
            {
                mainForm.minusOA(500);
                mainForm.addItem("ГНУТАЯ ПРОВОЛКА");
            }
            else
            {
                MessageBox.Show("Недостаточно очков авторитета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainForm.GetAuthorityPoints() >= 3000)
            {
                mainForm.minusOA(3000);
                mainForm.addItem("РЕЗАК");
            }
            else
            {
                MessageBox.Show("Недостаточно очков авторитета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainForm.GetAuthorityPoints() >= 5000)
            {
                mainForm.minusOA(5000);
                mainForm.addItem("ТАЛОН НА УСИЛЕННЫЙ ПАЁК");
            }
            else
            {
                MessageBox.Show("Недостаточно очков авторитета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mainForm.GetAuthorityPoints() >= 300)
            {
                mainForm.minusOA(300);
                mainForm.addItem("ВИСКИ \"NIZCHIE\"");
            }
            else
            {
                MessageBox.Show("Недостаточно очков авторитета!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}