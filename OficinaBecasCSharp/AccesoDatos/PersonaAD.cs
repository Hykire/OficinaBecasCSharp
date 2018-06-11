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
       

        public void enlazarBecario(Tutor pe,int idbec,string ciclo)
        {
           // BindingList<Persona> lista = new BindingList<Persona>();
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
            comando.Parameters.AddWithValue("idBecario", idbec);
            comando.Parameters.AddWithValue("idTut", pe.IdTutor);
            comando.Parameters.AddWithValue("ciclo", ciclo);
            //eroooooor en c#
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void enlazarBecario2(Becado pe,string idAlum)
        {
            //BindingList<Persona> lista = new BindingList<Persona>();
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
            comando.Parameters.AddWithValue("idBecario", idAlum);
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
            if (cod.Length == 0)
            {
                comando.CommandText = "SELECT * FROM PERSONA";
                comando.Connection = con;

            }
            else
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "Y_LISTAR_PERSONAS";

                comando.Connection = con;
                comando.Parameters.AddWithValue("param", cod);

            }

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            { 
                Persona per = new Persona();
                per.Id_persona = reader.GetInt32("ID_PERSONA");
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                per.Sexo = reader.GetChar("SEXO");
                per.Edad = reader.GetInt32("EDAD");
                per.TelfMovil = reader.GetString("TELF_MOVIL");
                //per.Profesion = reader.GetString("profesion");
                per.Dni = reader.GetInt32("DNI");
                per.Fecha_nacimiento = reader.GetDateTime("FECHA_NACIMIENTO");
                per.CorreoAlternativo = reader.GetString("CORREO_ALTERNATIVO");
                per.TelfFijo = reader.GetString("TELF_FIJO");
                per.TelfMovil = reader.GetString("TELF_MOVIL");
                per.CorreoPUCP = reader.GetString("CORREO_PUCP");
                
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
        
    }
}
