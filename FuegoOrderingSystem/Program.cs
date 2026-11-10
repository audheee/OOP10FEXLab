using System;
using System.Windows.Forms;

namespace FuegoOrderingSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new KioskForm());
        }
    }
}
