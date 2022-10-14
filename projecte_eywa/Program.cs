using System;
using System.Collections.Generic;
using System.Linq;

using System.Security.Cryptography;


using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte_eywa
{
    public static class Program
    {
        public static bool running = true;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            var formLogin = new FormCharacters();
            formLogin.Show();
            Application.Run();
            if (!running)
            {
                Application.Exit();
            }
            
            

        }
    }
}
