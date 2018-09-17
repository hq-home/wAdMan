using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wAdMan
{
    static class Program
    {
        private static mainForm theForm = null;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            theForm = new mainForm();
            Application.Run(theForm);

            Application.ApplicationExit += Application_ApplicationExit;
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Config.SaveCurrent();
        }
    }
}
