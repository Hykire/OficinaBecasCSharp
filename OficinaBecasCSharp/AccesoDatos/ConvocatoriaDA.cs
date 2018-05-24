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
        public BindingList<Convocatoria> listarConvocatorias()
        {
            BindingList<Convocatoria> convocatorias = new BindingList<Convocatoria>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_CONVOCATORIAS";
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Convocatoria convocatoria = new Convocatoria();
                convocatoria.IdConvocatoria = reader.GetInt32("idConvocatorias");
                convocatoria.NombreConvocatoria = reader.GetString("NombreConvocatoria");
                convocatoria.DescripcionConvocatoria = reader.GetString("DescripcionConvocatoria");
                convocatoria.FechaInicio = reader.GetDateTime("FechaInicio");
                convocatoria.FechaFin = reader.GetDateTime("FechaFin");
                convocatoria.FechaCreacion = reader.GetDateTime("FechaCreacion");
                convocatoria.CantidadPersonasPrevistas = reader.GetInt32("CantidadPersonasPrevistas");
                convocatoria.CantidadPersonasConvocadas = reader.GetInt32("CantidadPersonasConvocadas");
                convocatoria.CantidadRespuestas = reader.GetInt32("CantidadRespuestas");
                convocatoria.CicloConvocatoria = reader.GetString("CicloConvocatoria");

                AsistenteComunicaciones persona = new AsistenteComunicaciones();
                persona.Id_persona = reader.GetInt32("id_Persona");
                persona.Nombres = reader.GetString("nombre");
                persona.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                persona.IdAsistente = reader.GetInt32("id_AsistenteComunicaciones");

                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("id_beca");
                beca.Nombre_beca = reader.GetString("nombre_beca");

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
            comando.CommandText = "INSERTAR_CONVOCATORIA";
            comando.Parameters.Add("_NombreConvocatoria", MySqlDbType.VarChar).Value = convocatoria.NombreConvocatoria;
            comando.Parameters.Add("_DescripcionConvocatoria", MySqlDbType.VarChar).Value = convocatoria.DescripcionConvocatoria;
            comando.Parameters.Add("_FechaInicio", MySqlDbType.Date).Value = convocatoria.FechaInicio;
            comando.Parameters.Add("_FechaFin", MySqlDbType.Date).Value = convocatoria.FechaFin;
            comando.Parameters.Add("_FechaCreacion", MySqlDbType.Date).Value = convocatoria.FechaCreacion;
            comando.Parameters.Add("_CantidadPersonasPrevistas", MySqlDbType.Int32).Value = convocatoria.CantidadPersonasPrevistas;
            comando.Parameters.Add("_CantidadPersonasConvocadas", MySqlDbType.Int32).Value = convocatoria.CantidadPersonasConvocadas;
            comando.Parameters.Add("_CantidadRespuestas", MySqlDbType.Int32).Value = convocatoria.CantidadRespuestas;
            comando.Parameters.Add("_CicloConvocatoria", MySqlDbType.VarChar).Value = convocatoria.CicloConvocatoria;
            comando.Parameters.Add("_Beca_id_beca", MySqlDbType.Int32).Value = convocatoria.BecaAsociada.Id_beca;
            comando.Parameters.Add("_AsistenteComunicaciones_id_AsistenteComunicaciones", MySqlDbType.Int32).Value = convocatoria.CreadorConvocatoria.IdAsistente;
            comando.Parameters.Add("_ID", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            int id = Int32.Parse(comando.Parameters["_ID"].Value.ToString());
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
            comando.CommandText = "FILTRAR_CONVOCATORIA_NOMBRE";
            comando.Parameters.Add("_Nombre", MySqlDbType.VarChar).Value = nombre;
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Convocatoria convocatoria = new Convocatoria();
                convocatoria.IdConvocatoria = reader.GetInt32("idConvocatorias");
                convocatoria.NombreConvocatoria = reader.GetString("NombreConvocatoria");
                convocatoria.DescripcionConvocatoria = reader.GetString("DescripcionConvocatoria");
                convocatoria.FechaInicio = reader.GetDateTime("FechaInicio");
                convocatoria.FechaFin = reader.GetDateTime("FechaFin");
                convocatoria.FechaCreacion = reader.GetDateTime("FechaCreacion");
                convocatoria.CantidadPersonasPrevistas = reader.GetInt32("CantidadPersonasPrevistas");
                convocatoria.CantidadPersonasConvocadas = reader.GetInt32("CantidadPersonasConvocadas");
                convocatoria.CantidadRespuestas = reader.GetInt32("CantidadRespuestas");
                convocatoria.CicloConvocatoria = reader.GetString("CicloConvocatoria");

                AsistenteComunicaciones persona = new AsistenteComunicaciones();
                persona.Id_persona = reader.GetInt32("id_Persona");
                persona.Nombres = reader.GetString("nombre");
                persona.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                persona.IdAsistente = reader.GetInt32("id_AsistenteComunicaciones");

                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("id_beca");
                beca.Nombre_beca = reader.GetString("nombre_beca");

                convocatoria.BecaAsociada = beca;
                convocatoria.CreadorConvocatoria = persona;

                convocatorias.Add(convocatoria);
            }
            con.Close();
            return convocatorias;
        }

        public BindingList<Convocatoria> listarFiltroCiclo(string ciclo)
        {
            BindingList<Convocatoria> convocatorias = new BindingList<Convocatoria>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_CONVOCATORIAS";
            comando.Parameters.Add("_Ciclo", MySqlDbType.VarChar).Value = ciclo;
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Convocatoria convocatoria = new Convocatoria();
                convocatoria.IdConvocatoria = reader.GetInt32("idConvocatorias");
                convocatoria.NombreConvocatoria = reader.GetString("NombreConvocatoria");
                convocatoria.DescripcionConvocatoria = reader.GetString("DescripcionConvocatoria");
                convocatoria.FechaInicio = reader.GetDateTime("FechaInicio");
                convocatoria.FechaFin = reader.GetDateTime("FechaFin");
                convocatoria.FechaCreacion = reader.GetDateTime("FechaCreacion");
                convocatoria.CantidadPersonasPrevistas = reader.GetInt32("CantidadPersonasPrevistas");
                convocatoria.CantidadPersonasConvocadas = reader.GetInt32("CantidadPersonasConvocadas");
                convocatoria.CantidadRespuestas = reader.GetInt32("CantidadRespuestas");
                convocatoria.CicloConvocatoria = reader.GetString("CicloConvocatoria");

                AsistenteComunicaciones persona = new AsistenteComunicaciones();
                persona.Id_persona = reader.GetInt32("id_Persona");
                persona.Nombres = reader.GetString("nombre");
                persona.Apellidos = reader.GetString("ape_pa") + " " + reader.GetString("ape_ma");
                persona.IdAsistente = reader.GetInt32("id_AsistenteComunicaciones");

                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("id_beca");
                beca.Nombre_beca = reader.GetString("nombre_beca");

                convocatoria.BecaAsociada = beca;
                convocatoria.CreadorConvocatoria = persona;

                convocatorias.Add(convocatoria);
            }
            con.Close();
            return convocatorias;
        }
    }
}
