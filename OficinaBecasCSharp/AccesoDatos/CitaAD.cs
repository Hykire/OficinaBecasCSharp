using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CitaAD
    {
        public void agregarCita(Cita cita, int idBec, int idTut)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_INSERTAR_CITA";

            comando.Connection = con;
            comando.Parameters.AddWithValue("fecha", cita.Fecha);
            comando.Parameters.AddWithValue("lugar", cita.Lugar);
            comando.Parameters.AddWithValue("obs", cita.Observacion);
            comando.Parameters.AddWithValue("idBec", idBec);
            comando.Parameters.AddWithValue("idTut", idTut);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Cita> buscarcita(DateTime fecha)
        {
            BindingList<Cita> lista = new BindingList<Cita>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;Convert Zero DateTime=True;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_BUSCAR_CITA";
            //Convert Zero DateTime=True;
            comando.Connection = con;
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cita cita = new Cita();
                cita.Fecha = reader.GetDateTime("FECHA");
                cita.Lugar = reader.GetString("LUGAR");
                cita.Observacion = reader.GetString("OBSERVACION");
                cita.IdTutor = reader.GetInt32("ID_TUTOR");
                cita.IdBecado = reader.GetInt32("ID_BECADO");
                cita.IdCita = reader.GetInt32("ID_CITA");
                lista.Add(cita);
            }
            con.Close();
            return lista;
        }

    }
}
