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
    public class Becado_x_BecaDA
    {
        public void Registrar_enAlumno_x_Beca(Becado_x_Beca axb)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_BECADO_X_BECA";
            comando.Parameters.Add("_id_becado", MySqlDbType.Int32).Value = axb.Id_becado;
            comando.Parameters.Add("_id_beca", MySqlDbType.Int32).Value = axb.Id_beca;
            comando.Parameters.Add("_ciclo", MySqlDbType.VarChar).Value = axb.Ciclo;
            comando.Parameters.Add("_tipo_escala_pago", MySqlDbType.VarChar).Value = axb.Tipo_escala_pago;
            comando.Parameters.Add("_escala_pago", MySqlDbType.Int32).Value = axb.Escala_pago;
            comando.Parameters.Add("_nivel_creditos", MySqlDbType.Int32).Value = axb.Nivel_creditos;
            comando.Parameters.Add("_ncreditos_cubiertos", MySqlDbType.Double).Value = axb.Ncreditos_cubiertos;
            comando.Parameters.Add("_ncreditos_utilizados", MySqlDbType.Double).Value = axb.Ncreditos_utilizados;
            comando.Parameters.Add("_ncreditos_restantes", MySqlDbType.Double).Value = axb.Ncreditos_restantes;
            comando.Parameters.Add("_nsemestres_regular", MySqlDbType.Int32).Value = axb.Nsemestres_regular;
            comando.Parameters.Add("_nsemestres_verano", MySqlDbType.Int32).Value = axb.Nsemestres_verano;
            comando.Parameters.Add("_nsemestres_restantes", MySqlDbType.Int32).Value = axb.Nsemestres_restantes;
            comando.Parameters.Add("_renovacion", MySqlDbType.Int32).Value = axb.Renovacion;
            comando.Parameters.Add("_suspencion", MySqlDbType.Int32).Value = axb.Suspencion;
            comando.Parameters.Add("_ampliacion", MySqlDbType.Int32).Value = axb.Ampliacion;
            comando.Parameters.Add("_ciclo_solicitado", MySqlDbType.VarChar).Value = axb.Ciclo_solicitado;
            comando.Parameters.Add("_respuesta", MySqlDbType.VarChar).Value = axb.Respuesta;
            comando.Parameters.Add("_ncarta", MySqlDbType.VarChar).Value = axb.Ncarta;
            comando.Parameters.Add("_redencion_materiales", MySqlDbType.Int32).Value = axb.Redencion_materiales;
            comando.Parameters.Add("_redencion_alojamiento", MySqlDbType.Int32).Value = axb.Redencion_alojamiento;
            comando.Parameters.Add("_sansion", MySqlDbType.Int32).Value = axb.Sansion;
            comando.Parameters.Add("_sansion_tipo", MySqlDbType.VarChar).Value = axb.Sansion_tipo;
            comando.Parameters.Add("_sansion_ini", MySqlDbType.Date).Value = axb.Sansion_ini;
            comando.Parameters.Add("_sansion_fin", MySqlDbType.Date).Value = axb.Sansion_fin;
            comando.Parameters.Add("_intercambio", MySqlDbType.Int32).Value = axb.Intercambio;
            comando.Parameters.Add("_intercambio_tipo", MySqlDbType.VarChar).Value = axb.Intercambio_tipo;
            comando.Parameters.Add("_intercambio_ini", MySqlDbType.Date).Value = axb.Intercambio_ini;
            comando.Parameters.Add("_intercambio_fin", MySqlDbType.Date).Value = axb.Intercambio_fin;
            comando.Parameters.Add("_adelanto", MySqlDbType.Int32).Value = axb.Adelanto;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void actualizarAlumno_x_Beca(Becado_x_Beca axb)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_ACTUALIZAR_BECADO_X_BECA";
            comando.Parameters.Add("_id_becado_x_beca", MySqlDbType.Int32).Value = axb.Id_becado_x_beca;
            comando.Parameters.Add("_id_beca", MySqlDbType.Int32).Value = axb.Id_beca;
            comando.Parameters.Add("_ciclo", MySqlDbType.VarChar).Value = axb.Ciclo;
            comando.Parameters.Add("_tipo_escala_pago", MySqlDbType.VarChar).Value = axb.Tipo_escala_pago;
            comando.Parameters.Add("_escala_pago", MySqlDbType.Int32).Value = axb.Escala_pago;
            comando.Parameters.Add("_nivel_creditos", MySqlDbType.Int32).Value = axb.Nivel_creditos;
            comando.Parameters.Add("_ncreditos_cubiertos", MySqlDbType.Double).Value = axb.Ncreditos_cubiertos;
            comando.Parameters.Add("_ncreditos_utilizados", MySqlDbType.Double).Value = axb.Ncreditos_utilizados;
            comando.Parameters.Add("_ncreditos_restantes", MySqlDbType.Double).Value = axb.Ncreditos_restantes;
            comando.Parameters.Add("_nsemestres_regular", MySqlDbType.Int32).Value = axb.Nsemestres_regular;
            comando.Parameters.Add("_nsemestres_verano", MySqlDbType.Int32).Value = axb.Nsemestres_verano;
            comando.Parameters.Add("_nsemestres_restantes", MySqlDbType.Int32).Value = axb.Nsemestres_restantes;
            comando.Parameters.Add("_renovacion", MySqlDbType.Int32).Value = axb.Renovacion;
            comando.Parameters.Add("_suspencion", MySqlDbType.Int32).Value = axb.Suspencion;
            comando.Parameters.Add("_ampliacion", MySqlDbType.Int32).Value = axb.Ampliacion;
            comando.Parameters.Add("_ciclo_solicitado", MySqlDbType.VarChar).Value = axb.Ciclo_solicitado;
            comando.Parameters.Add("_respuesta", MySqlDbType.VarChar).Value = axb.Respuesta;
            comando.Parameters.Add("_ncarta", MySqlDbType.VarChar).Value = axb.Ncarta;
            comando.Parameters.Add("_redencion_materiales", MySqlDbType.Int32).Value = axb.Redencion_materiales;
            comando.Parameters.Add("_redencion_alojamiento", MySqlDbType.Int32).Value = axb.Redencion_alojamiento;
            comando.Parameters.Add("_sansion", MySqlDbType.Int32).Value = axb.Sansion;
            comando.Parameters.Add("_sansion_tipo", MySqlDbType.VarChar).Value = axb.Sansion_tipo;
            comando.Parameters.Add("_sansion_ini", MySqlDbType.Date).Value = axb.Sansion_ini;
            comando.Parameters.Add("_sansion_fin", MySqlDbType.Date).Value = axb.Sansion_fin;
            comando.Parameters.Add("_intercambio", MySqlDbType.Int32).Value = axb.Intercambio;
            comando.Parameters.Add("_intercambio_tipo", MySqlDbType.VarChar).Value = axb.Intercambio_tipo;
            comando.Parameters.Add("_intercambio_ini", MySqlDbType.Date).Value = axb.Intercambio_ini;
            comando.Parameters.Add("_intercambio_fin", MySqlDbType.Date).Value = axb.Intercambio_fin;
            comando.Parameters.Add("_adelanto", MySqlDbType.Int32).Value = axb.Adelanto;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        public BindingList<Becado_x_Beca> Buscar_BecasxAlumno(int id_becadoBUSCAR)
        {
            BindingList<Becado_x_Beca> lista = new BindingList<Becado_x_Beca>();
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM BECADO_X_BECA";
            comando.Connection = con;
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                int id_becado = rs.GetInt32("ID_BECADO");
                if (id_becado == id_becadoBUSCAR)
                {
                    Becado_x_Beca axb = new Becado_x_Beca();
                    axb.Id_becado = id_becado;
                    axb.Id_becado_x_beca = rs.GetInt32("ID_BECADO_X_BECA");
                    axb.Id_beca = rs.GetInt32("ID_BECA");
                    axb.Ciclo = rs.GetString("CICLO");
                    axb.Tipo_escala_pago = rs.GetString("TIPO_ESCALA_PAGO");
                    axb.Escala_pago = rs.GetInt32("ESCALA_PAGO");
                    axb.Nivel_creditos = rs.GetInt32("NIVEL_CREDITOS");
                    axb.Ncreditos_cubiertos = rs.GetDouble("NCREDITOS_CUBIERTOS");
                    axb.Ncreditos_restantes = rs.GetDouble("NCREDITOS_RESTANTES");
                    axb.Ncreditos_utilizados = rs.GetDouble("NCREDITOS_UTILIZADOS");
                    axb.Nsemestres_regular = rs.GetInt32("NSEMESTRES_REGULAR");
                    axb.Nsemestres_verano = rs.GetInt32("NSEMESTRES_VERANO");
                    axb.Nsemestres_restantes = rs.GetInt32("NSEMESTRES_RESTANTES");
                    axb.Renovacion = rs.GetInt32("RENOVACION");
                    axb.Suspencion = rs.GetInt32("SUSPENCION");
                    axb.Ampliacion = rs.GetInt32("AMPLIACION");
                    axb.Ciclo_solicitado = rs.GetString("CICLO_SOLICITADO");
                    axb.Respuesta = rs.GetString("RESPUESTA");
                    axb.Ncarta = rs.GetString("NCARTA");
                    axb.Redencion_materiales = rs.GetInt32("REDENCION_MATERIALES");
                    axb.Redencion_alojamiento = rs.GetInt32("REDENCION_ALOJAMIENTO");
                    axb.Sansion = rs.GetInt32("SANSION");
                    axb.Sansion_tipo = rs.GetString("SANSION_TIPO");
                    axb.Sansion_ini = rs.GetDateTime("SANSION_INI");
                    axb.Sansion_fin = rs.GetDateTime("SANSION_FIN");
                    axb.Intercambio = rs.GetInt32("INTERCAMBIO");
                    axb.Intercambio_ini = rs.GetDateTime("INTERCAMBIO_INI");
                    axb.Intercambio_fin = rs.GetDateTime("INTERCAMBIO_FIN");
                    axb.Intercambio_tipo = rs.GetString("INTERCAMBIO_TIPO");
                    axb.Adelanto = rs.GetInt32("ADELANTO");

                    lista.Add(axb);
                }
            }
            con.Close();
            return lista;
        }

        public BindingList<Becado_x_Beca> BuscarIdBecas(string idBec)
        {
            BindingList<Becado_x_Beca> lista = new BindingList<Becado_x_Beca>();
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM BECADO_X_BECA WHERE ID_BECADO ='" + Convert.ToInt32(idBec) + "'";
            comando.Connection = con;
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                int id_becado = rs.GetInt32("ID_BECADO");
                if (id_becado == Convert.ToInt32(idBec))
                {
                    Becado_x_Beca axb = new Becado_x_Beca();
                    axb.Id_becado = id_becado;
                    axb.Id_beca = rs.GetInt32("ID_BECA");
                    axb.Ciclo = rs.GetString("CICLO");

                    lista.Add(axb);
                }
            }
            con.Close();
            return lista;
        }
    }
}