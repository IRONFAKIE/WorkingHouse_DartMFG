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

            // Создаем главные формы
            Form_Inventory inventory = new Form_Inventory();
            Form_MainMenu mainMenu = new Form_MainMenu(inventory);

            // Настраиваем позиционирование форм
            inventory.StartPosition = FormStartPosition.Manual;
            mainMenu.StartPosition = FormStartPosition.Manual;

            // Позиционируем формы рядом
            mainMenu.Load += (sender, e) =>
            {
                inventory.Location = new Point(mainMenu.Right + 10, mainMenu.Top);
                inventory.Show();
            };

            // Закрытие приложения при закрытии любой из главных форм
            mainMenu.FormClosed += (s, args) => Application.Exit();
            inventory.FormClosed += (s, args) => Application.Exit();

            // Запускаем обе формы
            mainMenu.Show();
            Application.Run(); // Без параметров для ручного управления формами
        }
    }
}