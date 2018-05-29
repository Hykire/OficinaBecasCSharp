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
    public class TutorAD
    {
        public BindingList<Tutor> listarTutorDeBecado(int idBec)
        {
            BindingList<Tutor> lista = new BindingList<Tutor>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_DEVOLVER_IDTUTOR";
            comando.Connection = con;
            comando.Parameters.AddWithValue("idBec", idBec);
            comando.Parameters.Add("idtutor", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            MySqlDataReader reader = comando.ExecuteReader();
            int idTutor = Int32.Parse(comando.Parameters["idtutor"].Value.ToString());
            con.Close();

            con = new MySqlConnection(cadena);
            con.Open();
            comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_LISTAR_TUTOR_DE_BECADO";

            comando.Connection = con;
            comando.Parameters.AddWithValue("paramBecadot", idTutor);
            reader = comando.ExecuteReader();
            Tutor per;
            per = new Tutor();
            while (reader.Read())
            {
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.IdTutor = reader.GetInt32("ID_TUTOR");
                per.Apellidos = reader.GetString("APELLIDOS");
                lista.Add(per);

            }
            //MessageBox.Show(per.CodigoPUCP.ToString());
            con.Close();
            return lista;
        }
    }
}
