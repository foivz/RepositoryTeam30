using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Drawing;

namespace GizmoApp
{
    /// <summary>
    /// GizmoApp predstavlja aplikaciju za evidenciju i upravljanje poslovanjem poduzeća Katarina Zrinski d.o.o.
    /// </summary>
    public static class NamespaceDoc
    {
    }

    static class Program
    {
        public static bool prijava;
        public static string korime;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            prijava = false;

            Application.Run(new frmLogin());

            if (prijava)
            {
                
                Application.Run(new frmGlavna());
            }

        }
      
    }
}
