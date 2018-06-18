using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

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
            cmd.CommandText = "SELECT CONTRASENIA FROM USUARIO WHERE CONTRASENIA = '" + contraUsuario + "'";
            //string contrasenaObt = cmd.ExecuteScalar().ToString();
            aux = cmd.ExecuteScalar();
            if (aux == null) return false;
            string contrasenaObt = aux.ToString();
            conn.Close();
            if (contrasenaObt == contraUsuario) return true;
            else return false;
        }

        public Usuario obtener_usuario(int id_usuario)
        {
            Usuario u = new Usuario();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "SELECT * FROM USUARIO WHERE ID_USUARIO = " + id_usuario.ToString() + ";" ;
            comando.Connection = con;
            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                u.Id_usuario = id_usuario;
                u.Id_tipo_usuario = rs.GetInt32("ID_TIPOUSUARIO");
                u.User = rs.GetString("NOMBRE_USUARIO");
                u.Password = rs.GetString("CONTRASENIA");
            }
            con.Close();
            return u;
        }

        public int insertar_usuario(Usuario u)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_USUARIO";
            comando.Parameters.Add("_id_tipousuario", MySqlDbType.Int32).Value = u.Id_tipo_usuario;
            comando.Parameters.Add("_nombre_usuario", MySqlDbType.VarChar).Value = u.User;
            comando.Parameters.Add("_contrasenia", MySqlDbType.VarChar).Value = u.Password;
            comando.Parameters.Add("_id", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
            return Int32.Parse(comando.Parameters["_id"].Value.ToString());
        }

        public void cambiarContrasena(int idUsuario, string nuevaContra) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CAMBIAR_CONTRASENA";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("id", idUsuario);
            cmd.Parameters.AddWithValue("nuevaContra", nuevaContra);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int obtenerIdUsuario(string nombreUsuario) {
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID_USUARIO FROM USUARIO WHERE NOMBRE_USUARIO = '" + nombreUsuario + "'";
            Object aux = cmd.ExecuteScalar();
            if (aux == null) return -1;
            conn.Close();

            return Int32.Parse(aux.ToString());
        }

        public string obtenerNombreUsuario(int idUsuario) {
            if (idUsuario == -1) return "";

            string nombre = "";

            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT NOMBRES FROM PERSONA WHERE ID_USUARIO = " + idUsuario;
            Object aux = cmd.ExecuteScalar();
            if (aux == null) return nombre;
            nombre = aux.ToString();
            conn.Close();

            conn = new MySqlConnection(url);
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT APELLIDOS FROM PERSONA WHERE ID_USUARIO = " + idUsuario;
            aux = cmd.ExecuteScalar();
            if (aux == null) return nombre;
            nombre = nombre + " " + aux.ToString();
            conn.Close();

            return nombre;
        }

        public bool contrasenaCoincide(int idUsuario, string contraIngresada) {
            if (idUsuario == -1) return false;
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT CONTRASENIA FROM USUARIO WHERE ID_USUARIO = " + idUsuario.ToString();
            Object aux = cmd.ExecuteScalar();
            if (aux == null) return false;
            string contraObt = aux.ToString();
            conn.Close();

            if (contraObt != contraIngresada) return false;
            else return true;
        }
        //hecho por Francisco par actualizar un usuario
        public void actualizarUsuario(Usuario u)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            string aux_1 = "UPDATE USUARIO SET ";
            string aux_2 = "NOMBRE_USUARIO ='" + u.User + "', CONTRASENIA = '" + u.Password + "' WHERE ID_USUARIO = " + u.Id_usuario.ToString() + ";";
            comando.CommandText = aux_1 + aux_2; ;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        //hecho por Francisco para validacion de nombre de usuario
        public bool existe_user(string n_usuario)
        {
            bool flag = false;

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM USUARIO WHERE NOMBRE_USUARIO = '" + n_usuario + "';";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            if (rs.Read()) { flag = true; }
            con.Close();
            return flag;
        }
    }
}
