﻿using System;
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
            //string nombre = ventanaLogin.obtenerNombreUsuario();
            if (ventanaLogin.ShowDialog() == DialogResult.OK) {
                //Application.Run(new Principal(nombre));
                Application.Run(new Principal());
            }
            else {
                Application.Exit();
            }
        }
    }
}
