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
    public class ConvocatoriaDA
    {
        public BindingList<Convocatoria> listarConvocatoriasActuales(string ciclo)
        {
            BindingList<Convocatoria> convocatorias = new BindingList<Convocatoria>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_FILTRO_CONVOCATORIAS";
            comando.Parameters.Add("_CICLO", MySqlDbType.VarChar).Value = ciclo;
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Convocatoria convocatoria = new Convocatoria();
                convocatoria.IdConvocatoria = reader.GetInt32("ID_CONVOCIDATORIA");
                convocatoria.NombreConvocatoria = reader.GetString("NOMBRE_CONVOCATORIA");
                convocatoria.DescripcionConvocatoria = reader.GetString("DESCRIPCION_CONVOCATORIA");
                convocatoria.FechaInicio = reader.GetDateTime("FECHA_INICIO");
                convocatoria.FechaFin = reader.GetDateTime("FECHA_FIN");
                convocatoria.FechaCreacion = reader.GetDateTime("FECHA_CREACION");
                convocatoria.CantidadCandidatosPrevistos = reader.GetInt32("CANTIDAD_CANDIDATOSPREVISTOS");
                convocatoria.CantidadTotalCandidatos = reader.GetInt32("CANTIDAD_TOTALCANDIDATOS");
                convocatoria.CantidadPostulantes = reader.GetInt32("CANTIDAD_POSTULANTES");
                convocatoria.CantidadSeleccionados = reader.GetInt32("CANTIDAD_SELECCIONADOS");
                convocatoria.CicloConvocatoria = reader.GetString("CICLO_CONVOCATORIA");

                AsistenteComunicaciones persona = new AsistenteComunicaciones();
                persona.Id_persona = reader.GetInt32("ID_PERSONA");
                persona.Nombres = reader.GetString("NOMBRES");
                persona.Apellidos = reader.GetString("APELLIDOS");
                persona.IdAsistente = reader.GetInt32("ID_ASISTENTECOMUNICACIONES");

                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("ID_BECA");
                beca.Nombre_beca = reader.GetString("NOMBRE_BECA");

                convocatoria.BecaAsociada = beca;
                convocatoria.CreadorConvocatoria = persona;

                convocatorias.Add(convocatoria);
            }
            con.Close();
            return convocatorias;
        }

        public int agregarConvocatoria(Convocatoria convocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_INSERTAR_CONVOCATORIA";
            comando.Parameters.Add("_NOMBRE_CONVOCATORIA", MySqlDbType.VarChar).Value = convocatoria.NombreConvocatoria;
            comando.Parameters.Add("_DESCRIPCION_CONVOCATORIA", MySqlDbType.VarChar).Value = convocatoria.DescripcionConvocatoria;
            comando.Parameters.Add("_FECHA_INICIO", MySqlDbType.Date).Value = convocatoria.FechaInicio;
            comando.Parameters.Add("_FECHA_FIN", MySqlDbType.Date).Value = convocatoria.FechaFin;
            comando.Parameters.Add("_FECHA_CREACION", MySqlDbType.Date).Value = convocatoria.FechaCreacion;
            comando.Parameters.Add("_CANTIDAD_CANDIDATOSPREVISTOS", MySqlDbType.Int32).Value = convocatoria.CantidadCandidatosPrevistos;
            comando.Parameters.Add("_CANTIDAD_TOTALCANDIDATOS", MySqlDbType.Int32).Value = convocatoria.CantidadTotalCandidatos;
            comando.Parameters.Add("_CANTIDAD_POSTULANTES", MySqlDbType.Int32).Value = convocatoria.CantidadPostulantes;
            comando.Parameters.Add("_CANTIDAD_SELECCIONADOS", MySqlDbType.Int32).Value = convocatoria.CantidadSeleccionados;
            comando.Parameters.Add("_CICLO_CONVOCATORIA", MySqlDbType.VarChar).Value = convocatoria.CicloConvocatoria;
            comando.Parameters.Add("_ID_BECA", MySqlDbType.Int32).Value = convocatoria.BecaAsociada.Id_beca;
            comando.Parameters.Add("_ID_ASISTENTECOMUNICACIONES", MySqlDbType.Int32).Value = convocatoria.CreadorConvocatoria.IdAsistente;
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            int id = Int32.Parse(comando.Parameters["_ID_CONVOCATORIA"].Value.ToString());
            con.Close();
            return id;
        }

        public BindingList<Convocatoria> listarFiltroNombre(string nombre)
        {
            BindingList<Convocatoria> convocatorias = new BindingList<Convocatoria>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_FILTRO_NOMBRES";
            comando.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = nombre;
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Convocatoria convocatoria = new Convocatoria();
                convocatoria.IdConvocatoria = reader.GetInt32("ID_CONVOCIDATORIA");
                convocatoria.NombreConvocatoria = reader.GetString("NOMBRE_CONVOCATORIA");
                convocatoria.DescripcionConvocatoria = reader.GetString("DESCRIPCION_CONVOCATORIA");
                convocatoria.FechaInicio = reader.GetDateTime("FECHA_INICIO");
                convocatoria.FechaFin = reader.GetDateTime("FECHA_FIN");
                convocatoria.FechaCreacion = reader.GetDateTime("FECHA_CREACION");
                convocatoria.CantidadCandidatosPrevistos = reader.GetInt32("CANTIDAD_CANDIDATOSPREVISTOS");
                convocatoria.CantidadTotalCandidatos = reader.GetInt32("CANTIDAD_TOTALCANDIDATOS");
                convocatoria.CantidadPostulantes = reader.GetInt32("CANTIDAD_POSTULANTES");
                convocatoria.CantidadSeleccionados = reader.GetInt32("CANTIDAD_SELECCIONADOS");
                convocatoria.CicloConvocatoria = reader.GetString("CICLO_CONVOCATORIA");

                AsistenteComunicaciones persona = new AsistenteComunicaciones();
                persona.Id_persona = reader.GetInt32("ID_PERSONA");
                persona.Nombres = reader.GetString("NOMBRES");
                persona.Apellidos = reader.GetString("APELLIDOS");
                persona.IdAsistente = reader.GetInt32("ID_ASISTENTECOMUNICACIONES");

                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("ID_BECA");
                beca.Nombre_beca = reader.GetString("NOMBRE_BECA");

                convocatoria.BecaAsociada = beca;
                convocatoria.CreadorConvocatoria = persona;

                convocatorias.Add(convocatoria);
            }
            con.Close();
            return convocatorias;
        }

        public BindingList<Convocatoria> listarConvocatoriasAnteriores(string ciclo)
        {
            BindingList<Convocatoria> convocatorias = new BindingList<Convocatoria>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_LISTAR_CONVOCATORIAS_ANTERIORES";
            comando.Parameters.Add("_CICLO", MySqlDbType.VarChar).Value = ciclo;
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Convocatoria convocatoria = new Convocatoria();
                convocatoria.IdConvocatoria = reader.GetInt32("ID_CONVOCIDATORIA");
                convocatoria.NombreConvocatoria = reader.GetString("NOMBRE_CONVOCATORIA");
                convocatoria.DescripcionConvocatoria = reader.GetString("DESCRIPCION_CONVOCATORIA");
                convocatoria.FechaInicio = reader.GetDateTime("FECHA_INICIO");
                convocatoria.FechaFin = reader.GetDateTime("FECHA_FIN");
                convocatoria.FechaCreacion = reader.GetDateTime("FECHA_CREACION");
                convocatoria.CantidadCandidatosPrevistos = reader.GetInt32("CANTIDAD_CANDIDATOSPREVISTOS");
                convocatoria.CantidadTotalCandidatos = reader.GetInt32("CANTIDAD_TOTALCANDIDATOS");
                convocatoria.CantidadPostulantes = reader.GetInt32("CANTIDAD_POSTULANTES");
                convocatoria.CantidadSeleccionados = reader.GetInt32("CANTIDAD_SELECCIONADOS");
                convocatoria.CicloConvocatoria = reader.GetString("CICLO_CONVOCATORIA");

                AsistenteComunicaciones persona = new AsistenteComunicaciones();
                persona.Id_persona = reader.GetInt32("ID_PERSONA");
                persona.Nombres = reader.GetString("NOMBRES");
                persona.Apellidos = reader.GetString("APELLIDOS");
                persona.IdAsistente = reader.GetInt32("ID_ASISTENTECOMUNICACIONES");

                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("ID_BECA");
                beca.Nombre_beca = reader.GetString("NOMBRE_BECA");

                convocatoria.BecaAsociada = beca;
                convocatoria.CreadorConvocatoria = persona;

                convocatorias.Add(convocatoria);
            }
            con.Close();
            return convocatorias;
        }
        public void actualizarConvocatoria(Convocatoria convocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_ACTUALIZAR_CONVOCATORIA";
            comando.Parameters.Add("_NOMBRE_CONVOCATORIA", MySqlDbType.VarChar).Value = convocatoria.NombreConvocatoria;
            comando.Parameters.Add("_DESCRIPCION_CONVOCATORIA", MySqlDbType.VarChar).Value = convocatoria.DescripcionConvocatoria;
            comando.Parameters.Add("_FECHA_INICIO", MySqlDbType.Date).Value = convocatoria.FechaInicio;
            comando.Parameters.Add("_FECHA_FIN", MySqlDbType.Date).Value = convocatoria.FechaFin;
            comando.Parameters.Add("_FECHA_CREACION", MySqlDbType.Date).Value = convocatoria.FechaCreacion;
            comando.Parameters.Add("_CANTIDAD_CANDIDATOSPREVISTOS", MySqlDbType.Int32).Value = convocatoria.CantidadCandidatosPrevistos;
            comando.Parameters.Add("_CANTIDAD_TOTALCANDIDATOS", MySqlDbType.Int32).Value = convocatoria.CantidadTotalCandidatos;
            comando.Parameters.Add("_CANTIDAD_POSTULANTES", MySqlDbType.Int32).Value = convocatoria.CantidadPostulantes;
            comando.Parameters.Add("_CANTIDAD_SELECCIONADOS", MySqlDbType.Int32).Value = convocatoria.CantidadSeleccionados;
            comando.Parameters.Add("_CICLO_CONVOCATORIA", MySqlDbType.VarChar).Value = convocatoria.CicloConvocatoria;
            comando.Parameters.Add("_ID_BECA", MySqlDbType.Int32).Value = convocatoria.BecaAsociada.Id_beca;
            comando.Parameters.Add("_ID_ASISTENTECOMUNICACIONES", MySqlDbType.Int32).Value = convocatoria.CreadorConvocatoria.IdAsistente;
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = convocatoria.IdConvocatoria;
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void eliminarConvocatoria(Convocatoria convocatoria)
        {
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "A_ELIMINAR_CONVOCATORIA";
            comando.Parameters.Add("_ID_CONVOCATORIA", MySqlDbType.Int32).Value = convocatoria.IdConvocatoria;
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
