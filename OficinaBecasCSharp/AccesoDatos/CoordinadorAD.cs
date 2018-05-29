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
    public class CoordinadorAD
    {


        public BindingList<CoordinadorTutoria> traerCoordinadores()
        {
            BindingList<CoordinadorTutoria> lista = new BindingList<CoordinadorTutoria>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_SELECCIONAR_COORDINADORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {//P.NOMBRES, P.APELLIDOS, P.ID_PERSONA from PERSONA P
                CoordinadorTutoria per = new CoordinadorTutoria();
                per.Id_persona = reader.GetInt32("ID_PERSONA");
                per.Id_coordinador = reader.GetInt32("ID_COORDINADOR_TUTORIA");
                // per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
    }
}
