using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using bd8.Models;
using bd8.Views;
using bd8.Presenters;
using bd8._Repositories;

// Zvit = kod bazu danyh
// Skrinu robotu - main window, add, delete, edit
namespace bd8
{
    internal static class main
    {
        [STAThread]
        static void Main()
        {
            // Фіксить низьке розширення шрифтів і картинок
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Стрічка для з'єднання з базою даних
            string PostgreSQLConnectionString = 
            "Server=localhost;" +
            "User Id=postgres;" +
            "Password=postgres;" +
            "Database=postgres;";

            IMainView view = new MainView();
            
            new MainPresenter(view, PostgreSQLConnectionString);

            Application.Run((Form)view);
        }

        // Фіксить низьке розширення шрифтів і картинок
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
