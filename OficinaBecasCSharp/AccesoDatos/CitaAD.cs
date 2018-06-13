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
            int idcita = cita.IdCita;
            comando.CommandText = "SELECT ID_BECADO FROM CITA WHERE ID_CITA ='" + idcita + "'";
            comando.Connection = con;
            Object aux = comando.ExecuteScalar();
            con.Close();
            if (!(aux==null))
            {
                //update
                MySqlConnection con1 = new MySqlConnection(cadena);
                con1.Open();
                MySqlCommand comando1 = new MySqlCommand();
                comando1.CommandType = System.Data.CommandType.StoredProcedure;
                comando1.CommandText = "Y_ACTUALIZAR_CITA";

                comando1.Connection = con1;
                comando1.Parameters.AddWithValue("fecha", cita.Fecha);
                comando1.Parameters.AddWithValue("hora", cita.Hora);
                comando1.Parameters.AddWithValue("lugar", cita.Lugar);
                comando1.Parameters.AddWithValue("obs", cita.Observacion);
                comando1.Parameters.AddWithValue("idBec", idBec);
                comando1.Parameters.AddWithValue("idTut", idTut);
                comando1.Parameters.AddWithValue("idcita", cita.IdCita);

                comando1.ExecuteNonQuery();
                con1.Close();
            }
            else
            {
                //insert
                MySqlConnection con2 = new MySqlConnection(cadena);
                con2.Open();
                MySqlCommand comando2 = new MySqlCommand();
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.CommandText = "Y_INSERTAR_CITA";

                comando2.Connection = con2;
                comando2.Parameters.AddWithValue("fecha", cita.Fecha);
                comando2.Parameters.AddWithValue("hora", cita.Hora);
                comando2.Parameters.AddWithValue("lugar", cita.Lugar);
                comando2.Parameters.AddWithValue("obs", cita.Observacion);
                comando2.Parameters.AddWithValue("idBec", idBec);
                comando2.Parameters.AddWithValue("idTut", idTut);

                comando2.ExecuteNonQuery();
                con2.Close();
            }
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
                cita.Hora = reader.GetString("HORA");
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
