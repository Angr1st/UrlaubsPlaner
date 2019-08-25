using System;
using System.Windows.Forms;
using UrlaubsPlaner.Controller;

namespace UrlaubsPlaner
{
    internal static class Program
    {
        private static Main_FormController Main_FormController;
        private static AbsenceType_FormController AbsenceType_FormController;
        private static Employee_FormController Employee_FormController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main_FormController = new Main_FormController();
            (AbsenceType_FormController, Employee_FormController) = Main_FormController.Initialize();

            Main_FormController.Run();
        }
    }
}