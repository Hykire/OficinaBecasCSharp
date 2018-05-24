using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class PersonaAD
    {
        public BindingList<Persona> listarTutores()
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TUTORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Tutor per = new Tutor();
                per.Id_persona = reader.GetInt32("id_Persona");
                per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
                per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                per.TelfMovil = reader.GetInt32("telefono").ToString();
                per.Profesion = reader.GetString("profesion");
                per.Dni = reader.GetInt32("Dni");
                per.CorreoPUCP = reader.GetString("correo");
                per.EstadoT = reader.GetChar("EstadoT");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
        
        public BindingList<Persona> listarBecadosXTutor(String idTut)
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_BECADOS_TUTOR";

            comando.Connection = con;
            comando.Parameters.AddWithValue("paramTutor", idTut);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona per = new Persona();
                per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
                per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                per.CorreoPUCP = reader.GetString("correo");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }

        public BindingList<Persona> listarBecarios(String cod)
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "BUSCAR_BECARIO";

            comando.Connection = con;
            comando.Parameters.AddWithValue("codBec", cod);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona per = new Persona();
                per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
                per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                //es id becario 
                per.Id_persona = reader.GetInt32("id_Becado");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
        public BindingList<Persona> traerTutores()
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TUTORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("id_Persona");
               // per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
               // per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }

        public void enlazarBecario(Alumno pe)
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "ENLAZAR_BECARIO_TUTOR";

            comando.Connection = con;
            comando.Parameters.AddWithValue("idBecario", pe.Id_persona);
            comando.Parameters.AddWithValue("idTut", pe.Id_tutor);

            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Persona> listarTutorDeBecado(int idBec)
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TUTOR_DE_BECADO";

            comando.Connection = con;
            comando.Parameters.AddWithValue("paramBecado", idBec);
            MySqlDataReader reader = comando.ExecuteReader();
            Persona per;
            per = new Persona();
            while (reader.Read())
            {
                per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
                per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                lista.Add(per);
               
            }
             //MessageBox.Show(per.CodigoPUCP.ToString());
            con.Close();
            return lista;
        }
        public BindingList<Persona> listarPersonas(String cod)
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_PERSONAS";

            comando.Connection = con;
            comando.Parameters.AddWithValue("param", cod);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("id_Persona");
                per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
                per.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                per.TelfMovil = reader.GetInt32("telefono").ToString();
                per.Profesion = reader.GetString("profesion");
                per.Dni = reader.GetInt32("Dni");
                per.CorreoPUCP = reader.GetString("correo");
                
                lista.Add(per);
            }
            con.Close();
            return lista;
        }

        public BindingList<Persona> traerCoordinadores()
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "SELECCIONAR_COORDINADORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("id_Persona");
                // per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("nombre");
                per.Apellidos = reader.GetString("ape_pa");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }


        public void insertarNuevoTutor(String idPer, String idcoord, char est)
        {
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "INSERTAR_NUEVO_TUTOR";

            comando.Connection = con;
            comando.Parameters.AddWithValue("idPer", idPer);
            comando.Parameters.AddWithValue("idCoord", idcoord);
            comando.Parameters.AddWithValue("estado", est);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
