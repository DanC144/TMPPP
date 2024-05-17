using System;
using System.Windows.Forms;

namespace proiect
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Use the Singleton instance of Form1.
            Application.Run(Form1.Instance);
        }
    }
}
