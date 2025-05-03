using System;
using System.Windows.Forms;
using TpSouls.Forms;

namespace TpSouls
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            TpSoulsLogic.mainForm = mainForm;
            Application.Run(mainForm);
        }
    }
}
