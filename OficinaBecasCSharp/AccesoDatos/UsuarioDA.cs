using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos {
    public class UsuarioDA {
        private string url = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;" +
                "database=inf282g6;" +
                "port=3306;" +
                "password=Nk2ewy;" +
                "SslMode=none;";

        public bool validarUsuario(string nombreUsuario, string contraUsuario) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NOMBRE_USUARIO FROM USUARIO WHERE NOMBRE_USUARIO = '" + nombreUsuario + "'";
            Object aux = cmd.ExecuteScalar();
            if (aux == null) return false;
            string nombreObt = aux.ToString();
            conn.Close();

            /* Buscas constrasena del usuario */
            conn = new MySqlConnection(url);
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CONTRASENIA FROM USUARIO WHERE NOMBRE_USUARIO = '" + contraUsuario + "'";
            //string contrasenaObt = cmd.ExecuteScalar().ToString();
            aux = cmd.ExecuteScalar();
            if (aux == null) return false;
            string contrasenaObt = aux.ToString();
            conn.Close();
            
            if (contrasenaObt == contraUsuario) return true;
            else return false;
        }
    }
}
