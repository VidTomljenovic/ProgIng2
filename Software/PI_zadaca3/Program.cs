using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace PI_zadaca3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DB.SetConfiguration("PI2324_vtomljeno_DB", "PI2324_vtomljeno_User", "lfrJZvR=");
            Application.Run(new PocetniOdabir());
        }
    }
}
