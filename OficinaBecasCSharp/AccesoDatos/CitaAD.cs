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
            comando.Parameters.AddWithValue("idPer", cita.Fecha);
            comando.Parameters.AddWithValue("idCoord", cita.Lugar);
            comando.Parameters.AddWithValue("estado", cita.Observacion);
            comando.Parameters.AddWithValue("idCoord", idBec);
            comando.Parameters.AddWithValue("estado", idTut);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Cita> buscarcita(string fecha)
        {
            BindingList<Cita> lista = new BindingList<Cita>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_BUSCAR_CITA";

            comando.Connection = con;
            comando.Parameters.AddWithValue("fecha", fecha);
            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                // P.ID_PERSONA, P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.TELF_MOVIL, P.CORREO_PUCP, P.DNI FROM PERSONA P INNER JOIN
                Cita cita = new Cita();
                cita.Fecha = reader.GetDateTime("FECHA").ToString();
                cita.Lugar = reader.GetString("LUGAR");
                cita.Observacion = reader.GetString("OBSERVACION");
                lista.Add(cita);
            }
            con.Close();
            return lista;
        }

    }
}
