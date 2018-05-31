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
            int idTutor = Int32.Parse(comando.Parameters["idtutor"].Value.ToString()); /////////
            con.Close();
            if (idTutor != 0) { 
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
            else
            {
                Tutor per2;
                per2 = new Tutor();
                per2.CodigoPUCP = 0;
                per2.Nombres = "";
                per2.IdTutor = 0;
                per2.Apellidos = "";
                lista.Add(per2);
                return lista;
            }

        }


        public BindingList<Tutor> traerTutores()
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
            comando.CommandText = "Y_LISTAR_TUTORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Tutor per = new Tutor();
                per.IdTutor = reader.GetInt32("ID_TUTOR");
                //per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Apellidos = reader.GetString("APELLIDOS");
                // per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
        public void eliminarTutor(int idPer)
        {

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "Y_ELIMINAR_TUTOR";
            comando.Connection = con;
            comando.Parameters.AddWithValue("idPertut", idPer);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Tutor> traerTutoresCod(string codTut)
        {
            BindingList<Tutor> lista = new BindingList<Tutor>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();

            if (codTut.Length == 0)
            {
                comando.CommandText = "SELECT P.ID_PERSONA, P.CODIGO_PUCP, P.NOMBRES," +
                    " P.APELLIDOS, P.TELF_MOVIL, P.CORREO_PUCP, P.DNI, P.ESTADO, T.ID_TUTOR " +
                    "FROM PERSONA P INNER JOIN TUTOR T WHERE P.ID_PERSONA = T.ID_PERSONA ";
                comando.Connection = con;

            }
            else
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "Y_LISTAR_TUTORES_COD";

                comando.Connection = con;
                comando.Parameters.AddWithValue("codTut", codTut);

            }

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Tutor per = new Tutor();
                per.IdTutor = reader.GetInt32("ID_TUTOR");
                //per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Apellidos = reader.GetString("APELLIDOS");
                // per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
    }
}
