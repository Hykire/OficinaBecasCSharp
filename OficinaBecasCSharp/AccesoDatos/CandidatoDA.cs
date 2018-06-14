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
                candidato.Id_persona = reader.GetInt32("ID_PERSONA");
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

        public BindingList<Candidato> listarCandidatosAnteriores(int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_LISTAR_CANDIDATOS_ANTERIORES";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Connection = con;
            con.Open();

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Candidato candidato = new Candidato();
                candidato.IdCandidato = reader.GetInt32("ID_CANDIDATO");
                candidato.Id_persona = reader.GetInt32("ID_PERSONA");
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
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
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

        public void insertarCandidatoAntiguo(Candidato candidato, int idConvocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_INSERTAR_CANDIDATO_ANTIGUO";
            comando.Parameters.Add("_ESTADO_POSTULACION", MySqlDbType.VarChar).Value = candidato.EstadoPostulacion;
            comando.Parameters.Add("_ESTADO_SELECCION", MySqlDbType.VarChar).Value = candidato.EstadoSeleccion;
            comando.Parameters.Add("_ID_CANDIDATO", MySqlDbType.Int32).Value = candidato.IdCandidato;
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;

            comando.Connection = con;
            con.Open();

            comando.ExecuteNonQuery();
        }

        public BindingList<Candidato> filtrarNombre(string nombres, string postulante, string seleccionado, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_NOMBRE";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = nombres;
            comando.Parameters.Add("_POSTULANTE", MySqlDbType.VarChar).Value = postulante;
            comando.Parameters.Add("_SELECCIONADO", MySqlDbType.VarChar).Value = seleccionado;
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

        public BindingList<Candidato> filtrarApellidos(string apellidos, string postulante, string seleccionado, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_APELLIDOS";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_APELLIDOS", MySqlDbType.VarChar).Value = apellidos;
            comando.Parameters.Add("_POSTULANTE", MySqlDbType.VarChar).Value = postulante;
            comando.Parameters.Add("_SELECCIONADO", MySqlDbType.VarChar).Value = seleccionado;
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

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, string postulante, string seleccionado, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_CODIGOPUCP";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_CODIGOPUCP", MySqlDbType.Int32).Value = codigoPUCP;
            comando.Parameters.Add("_POSTULANTE", MySqlDbType.VarChar).Value = postulante;
            comando.Parameters.Add("_SELECCIONADO", MySqlDbType.VarChar).Value = seleccionado;
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

        public BindingList<Candidato> filtrarDNI(int DNI, string postulante, string seleccionado, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_DNI";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_DNI", MySqlDbType.Int32).Value = DNI;
            comando.Parameters.Add("_POSTULANTE", MySqlDbType.VarChar).Value = postulante;
            comando.Parameters.Add("_SELECCIONADO", MySqlDbType.VarChar).Value = seleccionado;
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

        public BindingList<Candidato> filtrarNombre(string nombres, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_NOMBRE_ANTIGUO";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_NOMBRES", MySqlDbType.VarChar).Value = nombres;
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

        public BindingList<Candidato> filtrarApellidos(string apellidos, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_APELLIDOS_ANTIGUO";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_APELLIDOS", MySqlDbType.VarChar).Value = apellidos;
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

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_CODIGOPUCP_ANTIGUO";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_CODIGOPUCP", MySqlDbType.Int32).Value = codigoPUCP;
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

        public BindingList<Candidato> filtrarDNI(int DNI, int idConvocatoria)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_CANDIDATO_FILTRAR_DNI_ANTIGUO";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_DNI", MySqlDbType.Int32).Value = DNI;
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
        public void actualizarCandidatoAntiguo(Candidato candidato, int idConvocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_ACTUALIZAR_CANDIDATO_ANTIGUO";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = candidato.Id_persona;
            comando.Parameters.Add("_ESTADO_POSTULACION", MySqlDbType.VarChar).Value = candidato.EstadoPostulacion;
            comando.Parameters.Add("_ESTADO_SELECCION", MySqlDbType.VarChar).Value = candidato.EstadoSeleccion;
            comando.Parameters.Add("_ID_CANDIDATO", MySqlDbType.Int32).Value = candidato.IdCandidato;
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizarCandidatoActual(Candidato persona, int idConvocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_ACTUALIZAR_CANDIDATO_ACTUAL";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = idConvocatoria;
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
            comando.Parameters.Add("_ID_PERSONA", MySqlDbType.Int32).Value = persona.Id_persona;
            comando.Parameters.Add("_POSTULANTE", MySqlDbType.VarChar).Value = persona.EstadoPostulacion;
            comando.Parameters.Add("_SELECCIONADO", MySqlDbType.VarChar).Value = persona.EstadoSeleccion;
            comando.Parameters.Add("_ID_CANDIDATO", MySqlDbType.VarChar).Value = persona.IdCandidato;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizarContadores(Convocatoria convocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_ACTUALIZAR_CONTADORES";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = convocatoria.IdConvocatoria;
            comando.Parameters.Add("_CANDIDATOS", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Parameters.Add("_POSTULANTES", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Parameters.Add("_SELECCIONADOS", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();

            convocatoria.CantidadCandidatosPrevistos = Int32.Parse(comando.Parameters["_CANDIDATOS"].Value.ToString());
            convocatoria.CantidadPostulantes = Int32.Parse(comando.Parameters["_POSTULANTES"].Value.ToString());
            convocatoria.CantidadSeleccionados = Int32.Parse(comando.Parameters["_SELECCIONADOS"].Value.ToString());

            con.Close();
        }
    }
}