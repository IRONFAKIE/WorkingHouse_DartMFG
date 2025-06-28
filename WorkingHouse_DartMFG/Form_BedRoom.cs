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
    public partial class Form_BedRoom : Form
    {
        private Form_Inventory inventory;
        private Form_MainMenu menu;
        public Form_BedRoom(Form_Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void button_BedRoom_1_Click(object sender, EventArgs e)
        {
            FormLivingRoom Livingroom = new FormLivingRoom(inventory, menu);
            Livingroom.Show();
            Close();
        }
    }
}
