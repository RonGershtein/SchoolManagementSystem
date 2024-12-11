using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using FinalProjectC_.Resources;

namespace FinalProjectC_
{
    internal static class Program
    {
        public static school myschool = new school("Ron and Lihi School","Lihi K","Ron Ger");


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
          static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            Application.Run(new FormLoadingScreen());

        }

    }
}
