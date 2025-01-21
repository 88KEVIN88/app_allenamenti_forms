using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using app_allenamenti_.Forms;

namespace app_allenamenti_
{
    internal static class Program
    {
        public static int CurrentUserId { get; set; } = -1; // -1 indica nessun utente loggato
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_register());
        }
    }
}
