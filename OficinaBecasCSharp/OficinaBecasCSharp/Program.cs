using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
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

            //Application.Run(new Principal());
            Login ventanaLogin = new Login();
            int idUsuario = ventanaLogin.obtenerIdUsuario();
            int tipoUsuario = ventanaLogin.obtenerTipoUsuario(idUsuario);
            if (ventanaLogin.ShowDialog() == DialogResult.OK) {
                Application.Run(new Principal(idUsuario, tipoUsuario));
            }
            else {
                Application.Exit();
            }
        }
    }
}
