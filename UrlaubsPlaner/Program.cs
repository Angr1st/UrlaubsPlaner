using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlaubsPlaner.Controller;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner
{
    internal static class Program
    {
        private static Main_FormController Main_FormController;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Main_FormController = new Main_FormController();
        }
    }
}