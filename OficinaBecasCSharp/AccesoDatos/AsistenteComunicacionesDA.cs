using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AsistenteComunicacionesDA
    {
        public AsistenteComunicaciones buscarAsistente(int idUsuario)
        {
            AsistenteComunicaciones asistenteComunicaciones = new AsistenteComunicaciones();

            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "BUSCAR_ASISTENTE";
            comando.Parameters.Add("_ID_USUARIO", MySqlDbType.Int32).Value = idUsuario;
            comando.Connection = con;
            con.Open();

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                asistenteComunicaciones.Nombres = reader.GetString("NOMBRES");
                asistenteComunicaciones.Apellidos = reader.GetString("APELLIDOS");
                asistenteComunicaciones.IdAsistente = reader.GetInt32("ID_ASISTENTECOMUNICACIONES");
            }

            return asistenteComunicaciones;
        }
            
    }
}