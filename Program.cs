using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Libreria
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyContext());
        }
    }
    public class MyContext : ApplicationContext
    {
        public MyContext()
        {
            Application.Idle += new EventHandler(Application_Idle);
            Splash Splash = new Splash();
            Splash.Show();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }

}
