using System;
using System.Windows.Forms;

namespace proiect
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(Form1.Instance);
        }
    }
}

