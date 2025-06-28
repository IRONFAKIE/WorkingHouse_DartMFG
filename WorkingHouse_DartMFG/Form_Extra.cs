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
    public partial class Form_Extra : Form
    {
        private Form_Inventory inventory;

        public Form_Extra(Form_Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }
    }
}
