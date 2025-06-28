using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{

    public partial class Form_Inventory : Form
    {
        private Form_Cafeteria cafeteriaForm;
        private double pounds = 0;
        private int authorityPoints = 0;
        private Form_Store form2;
        private FormDarkShop form3;

        public Form_Inventory()
        {
            InitializeComponent();
        }

        public void SetForms(Form_Store f2, FormDarkShop f3)
        {
            form2 = f2;
            form3 = f3;
        }

        public int GetAuthorityPoints()
        {
            return authorityPoints;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new FormDarkShop(this);
            }
            form3.Show();
            this.Hide();
        }

        public void ShowForm_Inventory()
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form_Store(this, cafeteriaForm);
            }
            form2.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                return;
            }
            base.OnFormClosing(e);
        }

        private void Form_Inventory_Load(object sender, EventArgs e)
        {
            addItem("БАЛАНДА");
            addItem("БАЛАНДА");
            addItem("РЕЗАК");
            addItem("ШАЛЬ");
            addItem("КНИГА");
            removeItem("БАЛАНДА");
            plusOA(8);
            plusPound(42);
            minusOA(2);
            minusPound(2.5);
        }

        public double GetPounds()
        {
            return pounds;
        }

        public void SetPounds(double value)
        {
            pounds = value;
            if (pounds < 0) pounds = 0;
            UpdateCurrencyLabels();
        }

        public void addItem(string itemName)
        {
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                listBox1.Items.Add(itemName);
            }
        }

        public void removeItem(string itemName)
        {
            if (!string.IsNullOrWhiteSpace(itemName))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == itemName)
                    {
                        listBox1.Items.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        public void plusPound(double amount = 1)
        {
            pounds += amount;
            UpdateCurrencyLabels();
        }

        public void minusPound(double amount = 1)
        {
            pounds -= amount;
            if (pounds < 0) pounds = 0;
            UpdateCurrencyLabels();
        }

        public void plusOA(int amount = 1)
        {
            authorityPoints += amount;
            UpdateCurrencyLabels();
        }

        public void minusOA(int amount = 1)
        {
            authorityPoints -= amount;
            if (authorityPoints < 0) authorityPoints = 0;
            UpdateCurrencyLabels();
        }

        private void UpdateCurrencyLabels()
        {
            label2.Text = pounds.ToString();
            label4.Text = authorityPoints.ToString();
        }
    }
}