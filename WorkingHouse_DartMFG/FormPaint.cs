using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    public partial class FormPaint : Form
    {
        public FormPaint()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Click += (sender, e) => this.Close();
            Button closeButton = new Button();
            closeButton.Text = "Закрыть";
            closeButton.Dock = DockStyle.Bottom;
            closeButton.Click += (sender, e) => this.Close();
            this.Controls.Add(closeButton);
        }
    }
}