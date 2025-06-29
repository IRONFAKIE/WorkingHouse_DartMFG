using System;
using System;
using System.Windows.Forms;

namespace WorkingHouse_DartMFG
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_Inventory inventory = new Form_Inventory();
            Form_MainMenu mainMenu = new Form_MainMenu(inventory);
            inventory.StartPosition = FormStartPosition.Manual;
            mainMenu.StartPosition = FormStartPosition.Manual;
            mainMenu.Load += (sender, e) =>
            {
                inventory.Location = new Point(mainMenu.Right + 10, mainMenu.Top);
                inventory.Show();
            };
            mainMenu.FormClosed += (s, args) => Application.Exit();
            inventory.FormClosed += (s, args) => Application.Exit();
            mainMenu.Show();
            Application.Run();
        }
    }
}