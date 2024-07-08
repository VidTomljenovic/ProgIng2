using System;
using System.Windows.Forms;
using DBLayer;

namespace PI_zadaca3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("PI2324_vtomljeno_DB", "PI2324_vtomljeno_User", "lfrJZvR=");// Konfiguriram povezivanje s bazom podataka
            Application.Run(new PocetniOdabir());
        }
    }
}