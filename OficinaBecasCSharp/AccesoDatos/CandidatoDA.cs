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
    public class CandidatoDA
    {
        public BindingList<Candidato> listarCandidatos(int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_LISTAR_CANDIDATOS";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Connection = con;
            con.Open();

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Candidato candidato = new Candidato();
                candidato.IdCandidato = reader.GetInt32("ID_CANDIDATO");
                candidato.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                candidato.Nombres = reader.GetString("NOMBRES");
                candidato.Apellidos = reader.GetString("APELLIDOS");
                candidato.Sexo = reader.GetChar("SEXO");
                candidato.Dni = reader.GetInt32("DNI");
                candidato.Edad = reader.GetInt32("EDAD");
                candidato.Fecha_nacimiento = reader.GetDateTime("FECHA_NACIMIENTO");
                candidato.CorreoPUCP = reader.GetString("CORREO_PUCP");
                candidato.CorreoAlternativo = reader.GetString("CORREO_ALTERNATIVO");
                candidato.TelfMovil = reader.GetString("TELF_MOVIL");
                candidato.TelfFijo = reader.GetString("TELF_FIJO");
                candidato.Estado = reader.GetString("ESTADO");
                candidato.EstadoPostulacion = reader.GetString("ESTADO_POSTULACION");
                candidato.EstadoSeleccion = reader.GetString("ESTADO_SELECCION");

                candidatos.Add(candidato);
            }

            con.Close();
            return candidatos;
        }

        public int insertarPersona(Persona persona)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_INSERTAR_PERSONA";
            comando.Parameters.Add("_CODIGO_PUCP", MySqlDbType.Int32).Value = persona.CodigoPUCP;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = persona.Nombres;
            comando.Parameters.Add("_APELLIDOS", MySqlDbType.VarChar).Value = persona.Apellidos;
            comando.Parameters.Add("_SEXO", MySqlDbType.VarChar).Value = persona.Sexo;
            comando.Parameters.Add("_DNI", MySqlDbType.Int32).Value = persona.Dni;
            comando.Parameters.Add("_EDAD", MySqlDbType.Int32).Value = persona.Edad;
            comando.Parameters.Add("_FECHA_NACIMIENTO", MySqlDbType.Date).Value = persona.Fecha_nacimiento;
            comando.Parameters.Add("_CORREO_PUCP", MySqlDbType.VarChar).Value = persona.CorreoPUCP;
            comando.Parameters.Add("_CORREO_ALTERNATIVO", MySqlDbType.VarChar).Value = persona.CorreoAlternativo;
            comando.Parameters.Add("_TELF_MOVIL", MySqlDbType.VarChar).Value = persona.TelfMovil;
            comando.Parameters.Add("_TELF_FIJO", MySqlDbType.VarChar).Value = persona.TelfFijo;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();

            int idPersona = Int32.Parse(comando.Parameters["_ID_PERSONA"].Value.ToString());
            con.Close();

            return idPersona;
        }
        public int insertarCandidato(Candidato candidato, int idConvocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_INSERTAR_CANDIDATO";
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = candidato.Id_persona;
            comando.Parameters.Add("_ESTADO_POSTULACION", MySqlDbType.VarChar).Value = candidato.EstadoPostulacion;
            comando.Parameters.Add("_ESTADO_SELECCION", MySqlDbType.VarChar).Value = candidato.EstadoSeleccion;
            comando.Parameters.Add("_ID_CANDIDATO", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();

            comando.ExecuteNonQuery();

            int idCandidato = Int32.Parse(comando.Parameters["_ID_CANDIDATO"].Value.ToString());
            con.Close();

            return idCandidato;
        }

        public BindingList<Candidato> filtrarNombre(string nombres, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public BindingList<Candidato> filtrarApellidos(string apellidos, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public BindingList<Candidato> filtrarDNI(int DNI, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public void actualizarCandidato(Candidato candidato)
        {

        }

        public void actualizarContadores(Convocatoria convocatoria)
        {
            
        }
    }
}
