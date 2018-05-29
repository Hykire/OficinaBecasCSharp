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
            comando.CommandText = "Y_LISTAR_TUTORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                // P.ID_PERSONA, P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.TELF_MOVIL, P.CORREO_PUCP, P.DNI FROM PERSONA P INNER JOIN
                Tutor per = new Tutor();
                per.Id_persona = reader.GetInt32("ID_TUTOR");
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                per.TelfMovil = reader.GetInt32("TELF_MOVIL").ToString();
                //per.Profesion = reader.GetString("profesion");
                per.Dni = reader.GetInt32("DNI");
                per.CorreoPUCP = reader.GetString("CORREO_PUCP");
                per.Estado = reader.GetString("ESTADO");
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
            comando.CommandText = "Y_LISTAR_BECADOS_TUTOR";

            comando.Connection = con;
            comando.Parameters.AddWithValue("paramTutor", idTut);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.CORREO_PUCP FROM PERSONA P
                Persona per = new Persona();
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                per.CorreoPUCP = reader.GetString("CORREO_PUCP");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }

        public BindingList<Persona> listarBecarios(String cod)
        {//cambiar por ALUMNO
            BindingList<Persona> lista = new BindingList<Persona>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            if(cod.Length == 0)
            {
                comando.CommandText = "SELECT P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.CORREO_PUCP, B.ID_BECADO FROM PERSONA P INNER JOIN BECADO B WHERE P.ID_PERSONA = B.ID_PERSONA";
                comando.Connection = con;
                
            }
            else
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "Y_BUSCAR_BECARIO";

                comando.Connection = con;
                comando.Parameters.AddWithValue("codBec", cod);
                
            }
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.CORREO_PUCP, B.ID_BECADO FROM PERSONA P
                Persona per = new Persona();
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                //es id becario 
                per.Id_persona = reader.GetInt32("ID_BECADO");
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
            comando.CommandText = "Y_LISTAR_TUTORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("ID_PERSONA");
                //per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("NOMBRES");
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
            comando.CommandText = "Y_ENLAZAR_BECARIO_TUTOR";
            //SET ID_TUTOR = idTut WHERE ID_BECADO = idBecario
            comando.Connection = con;
            comando.Parameters.AddWithValue("idBecario", pe.Id_persona);
            comando.Parameters.AddWithValue("idTut", pe.Id_tutor);
            //eroooooor en c#
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void enlazarBecario2(Alumno pe)
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
            comando.CommandText = "Y_ENLAZAR_BECARIO_TUTOR2";
            //SET ID_TUTOR = idTut WHERE ID_BECADO = idBecario
            comando.Connection = con;
            comando.Parameters.AddWithValue("idBecario", pe.Id_persona);
            comando.Parameters.AddWithValue("idTut", pe.Id_tutor);
            
            comando.ExecuteNonQuery();
            con.Close(); //update desde workb sii
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
            comando.CommandText = "Y_LISTAR_PERSONAS";

            comando.Connection = con;
            comando.Parameters.AddWithValue("param", cod);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            { 
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("ID_PERSONA");
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                per.TelfMovil = reader.GetInt32("TELF_MOVIL").ToString();
                //per.Profesion = reader.GetString("profesion");
                per.Dni = reader.GetInt32("DNI");
                per.CorreoPUCP = reader.GetString("CORREO_PUCP");
                
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
            comando.CommandText = "Y_SELECCIONAR_COORDINADORES";

            comando.Connection = con;

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {//P.NOMBRES, P.APELLIDOS, P.ID_PERSONA from PERSONA P
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("ID_PERSONA");
                // per.CodigoPUCP = reader.GetInt32("codigoPUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
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
            comando.CommandText = "Y_INSERTAR_NUEVO_TUTOR";

            comando.Connection = con;
            comando.Parameters.AddWithValue("idPer", idPer);
            comando.Parameters.AddWithValue("idCoord", idcoord);
            comando.Parameters.AddWithValue("estado", est);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
