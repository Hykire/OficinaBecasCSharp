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
        //Hecho por Yoluana
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

        //Hecho por Yoluana
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

        //Hecho por Yoluana
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

        //Hecho por Yoluana
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

        //hecho por Francisco, se usa en frmBuscarPersona_F
        public BindingList<Persona> listar_Persona_F()
        {
            BindingList<Persona> lista = new BindingList<Persona>();

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM PERSONA";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Persona p = new Persona();
                p.Id_persona = rs.GetInt32("ID_PERSONA");
                p.Id_usuario = rs.GetInt32("ID_USUARIO");
                p.CodigoPUCP = rs.GetInt32("CODIGO_PUCP");
                p.Nombres = rs.GetString("NOMBRES");
                p.Apellidos = rs.GetString("APELLIDOS");
                p.Sexo = rs.GetChar("SEXO");
                p.Dni = rs.GetInt32("DNI");
                p.Fecha_nacimiento = rs.GetDateTime("FECHA_NACIMIENTO");
                p.CorreoPUCP = rs.GetString("CORREO_PUCP");
                p.CorreoAlternativo = rs.GetString("CORREO_ALTERNATIVO");
                p.TelfMovil = rs.GetString("TELF_MOVIL");
                p.TelfFijo = rs.GetString("TELF_FIJO");
                p.Estado = rs.GetString("ESTADO");
                lista.Add(p);
            }
            con.Close();
            return lista;
        }
        //hecho por Francisco
        public int insertar_persona(Persona p, int id_usuario)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_PERSONA";
            comando.Parameters.Add("_codigo_pucp", MySqlDbType.Int32).Value = p.CodigoPUCP;
            comando.Parameters.Add("_nombres", MySqlDbType.VarChar).Value = p.Nombres;
            comando.Parameters.Add("_apellidos", MySqlDbType.VarChar).Value = p.Apellidos;
            comando.Parameters.Add("_sexo", MySqlDbType.VarChar).Value = p.Sexo;
            comando.Parameters.Add("_dni", MySqlDbType.Int32).Value = p.Dni;
            comando.Parameters.Add("_edad", MySqlDbType.Int32).Value = p.Edad;
            comando.Parameters.Add("_fecha_nacimiento", MySqlDbType.Date).Value = p.Fecha_nacimiento;
            comando.Parameters.Add("_correo_pucp", MySqlDbType.VarChar).Value = p.CorreoPUCP;
            comando.Parameters.Add("_correo_alternativo", MySqlDbType.VarChar).Value = p.CorreoAlternativo;
            comando.Parameters.Add("_telf_movil", MySqlDbType.VarChar).Value = p.TelfMovil;
            comando.Parameters.Add("_telf_fijo", MySqlDbType.VarChar).Value = p.TelfFijo;
            comando.Parameters.Add("_estado", MySqlDbType.VarChar).Value = p.Estado;
            comando.Parameters.Add("_id_usuario", MySqlDbType.Int32).Value = id_usuario;

            comando.Parameters.Add("_id", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            int id = Int32.Parse(comando.Parameters["_id"].Value.ToString());
            con.Close();
            return id;
        }
        //hecho por Francisco inserta una persona que es tipo coordinador tutoria en su propia tabla
        public void insertar_personaEnTCoordinadorTuto(int id_persona)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO COORDINADOR_TUTORIA(ID_PERSONA) VALUES(" + id_persona.ToString() +");";

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void insertar_personaEnAsistenteCom(int id_persona)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO ASISTENTE_COMUNICACIONES(ID_PERSONA) VALUES(" + id_persona.ToString() + ");";

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        //hecho por Francisco actualiza persona
        public void actualizar_persona(Persona a)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_ACTUALIZAR_PERSONA";
            comando.Parameters.Add("_id_persona", MySqlDbType.Int32).Value = a.Id_persona;
            comando.Parameters.Add("_codigo_pucp", MySqlDbType.Int32).Value = a.CodigoPUCP;
            comando.Parameters.Add("_nombres", MySqlDbType.VarChar).Value = a.Nombres;
            comando.Parameters.Add("_apellidos", MySqlDbType.VarChar).Value = a.Apellidos;
            comando.Parameters.Add("_sexo", MySqlDbType.VarChar).Value = a.Sexo;
            comando.Parameters.Add("_dni", MySqlDbType.Int32).Value = a.Dni;
            comando.Parameters.Add("_edad", MySqlDbType.Int32).Value = a.Edad;
            comando.Parameters.Add("_fecha_nacimiento", MySqlDbType.Date).Value = a.Fecha_nacimiento;
            comando.Parameters.Add("_correo_pucp", MySqlDbType.VarChar).Value = a.CorreoPUCP;
            comando.Parameters.Add("_correo_alternativo", MySqlDbType.VarChar).Value = a.CorreoAlternativo;
            comando.Parameters.Add("_telf_movil", MySqlDbType.VarChar).Value = a.TelfMovil;
            comando.Parameters.Add("_telf_fijo", MySqlDbType.VarChar).Value = a.TelfFijo;
            comando.Parameters.Add("_estado", MySqlDbType.VarChar).Value = a.Estado;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        //hecho por Francisco para validacion de codigo
        public bool existe_cod(int codigo)
        {
            bool flag = false;

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM PERSONA WHERE CODIGO_PUCP = " + codigo.ToString()+";";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            if (rs.Read()) { flag = true; }
            con.Close();
            return flag;
        }

    }
}
