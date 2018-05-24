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
    public class Alumno_x_BecaDA
    {
        public void Registrar_enAlumno_x_Beca(Alumno_x_Beca axb, int id_alumno)
        {
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO _F_ALUMNO_x_BECA(ID_ALUMNO,ID_BECA,CICLO,ESCALA_PAGO,NIVEL_CREDITOS,NCREDITOS_CUBIERTOS," +
                "NCREDITOS_UTILIZADOS,NCREDITOS_RESTANTES,NSEMESTRES_REGULAR,NSEMESTRES_VERANO,NSEMESTRES_RESTANTES,RENOVACION," +
                "SUSPENCION,AMPLIACION,CICLO_SOLICITADO,RESPUESTA,NCARTA,REDENCION_MATERIALES," +
                "REDENCION_ALOJAMIENTO, SANSION_TIPO, SANSION_INI, SANSION_FIN, INTERCAMBIO_TIPO," +
                "INTERCAMBIO_INI,INTERCAMBIO_FIN,ADELANTO, INTERCAMBIO, SANSION) VALUES" +
                "(" + id_alumno + "," + axb.Id_beca + ",'" + axb.Ciclo + "'," + axb.Escala_pago + ",'" + axb.Nivel_creditos + "'," +
                axb.Ncreditos_cubiertos + "," + axb.Ncreditos_utilizados + "," + axb.Ncreditos_restantes + "," +
                axb.Nsemestres_regular + "," + axb.Nsemestres_verano + "," + axb.Nsemestres_restantes + "," +
                axb.Renovacion + ",'" + axb.Suspencion + "'," + axb.Ampliacion + ",'" + axb.Ciclo_solicitado + "','" +
                axb.Respuesta + "','" + axb.Ncarta + "'," + axb.Redencion_materiales + "," + axb.Redencion_alojamiento + ",'" +
                axb.Sansion_tipo + "','" + axb.Sansion_ini + "','" + axb.Sansion_fin + "','" + axb.Intercambio_tipo + "','" +
                axb.Intercambio_ini + "','" + axb.Intercambio_fin + "'," + axb.Adelanto + "," + axb.Intercambio + "," + axb.Sansion + ");";
            System.Console.WriteLine(comando.CommandText);
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }
        public BindingList<Alumno_x_Beca> Buscar_BecasxAlumno(int id_alumno)
        {
            BindingList<Alumno_x_Beca> lista = new BindingList<Alumno_x_Beca>();
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM _F_ALUMNO_x_BECA";
            comando.Connection = con;
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                int id_alumnno_axb = rs.GetInt32("ID_ALUMNO");
                if (id_alumnno_axb == id_alumno)
                {
                    Alumno_x_Beca axb = new Alumno_x_Beca();

                    axb.Id_alumno_x_beca = rs.GetInt32("ID_ALUMNO_X_BECA");
                    axb.Id_beca = rs.GetInt32("ID_BECA");
                    axb.Ciclo = rs.GetString("CICLO");
                    axb.Escala_pago = Int32.Parse(rs.GetString("ESCALA_PAGO"));
                    axb.Nivel_creditos = rs.GetString("NIVEL_CREDITOS");
                    axb.Ncreditos_cubiertos = Double.Parse(rs.GetString("NCREDITOS_CUBIERTOS"));
                    axb.Ncreditos_restantes = Double.Parse(rs.GetString("NCREDITOS_RESTANTES"));
                    axb.Ncreditos_utilizados = Double.Parse(rs.GetString("NCREDITOS_UTILIZADOS"));
                    axb.Nsemestres_regular = Int32.Parse(rs.GetString("NSEMESTRES_REGULAR"));
                    axb.Nsemestres_verano = Int32.Parse(rs.GetString("NSEMESTRES_VERANO"));
                    axb.Nsemestres_restantes = Int32.Parse(rs.GetString("NSEMESTRES_RESTANTES"));
                    axb.Renovacion = Int32.Parse(rs.GetString("RENOVACION"));
                    axb.Suspencion = rs.GetString("SUSPENCION");
                    axb.Ampliacion = Int32.Parse(rs.GetString("AMPLIACION"));
                    axb.Ciclo_solicitado = rs.GetString("CICLO_SOLICITADO");
                    axb.Respuesta = rs.GetString("RESPUESTA");
                    axb.Ncarta = rs.GetString("NCARTA");
                    axb.Redencion_materiales = Int32.Parse(rs.GetString("REDENCION_MATERIALES"));
                    axb.Redencion_alojamiento = Int32.Parse(rs.GetString("REDENCION_ALOJAMIENTO"));
                    axb.Sansion = Int32.Parse(rs.GetString("SANSION"));
                    axb.Sansion_tipo = rs.GetString("SANSION_TIPO");
                    axb.Sansion_ini = rs.GetString("SANSION_INI");
                    axb.Sansion_fin = rs.GetString("SANSION_FIN");
                    axb.Intercambio = Int32.Parse(rs.GetString("INTERCAMBIO"));
                    axb.Intercambio_ini = rs.GetString("INTERCAMBIO_INI");
                    axb.Intercambio_fin = rs.GetString("INTERCAMBIO_FIN");
                    axb.Intercambio_tipo = rs.GetString("INTERCAMBIO_TIPO");
                    axb.Adelanto = Int32.Parse(rs.GetString("ADELANTO"));

                    lista.Add(axb);
                }
            }
            con.Close();
            return lista;
        }
    }
}