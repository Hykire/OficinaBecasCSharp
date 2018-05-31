using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class HistoriaAcademicaDA
    {
        public void registrar_enHistoriaA(HistoriaAcademica h)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_HISTORIA";
            comando.Parameters.Add("_id_becado", MySqlDbType.Int32).Value = h.Id_becado;
            comando.Parameters.Add("_ciclo", MySqlDbType.VarChar).Value = h.Ciclo;
            comando.Parameters.Add("_id_especialidad_actual", MySqlDbType.Int32).Value = h.Id_especialidad_actual;
            comando.Parameters.Add("_id_facultad_actual", MySqlDbType.Int32).Value = h.Id_facultad_actual;
            comando.Parameters.Add("_ultimo_ciclom", MySqlDbType.VarChar).Value = h.Ultimo_ciclom;
            comando.Parameters.Add("_craest", MySqlDbType.Double).Value = h.Craest;
            comando.Parameters.Add("_orden", MySqlDbType.Double).Value = h.Orden;
            comando.Parameters.Add("_ncm", MySqlDbType.Int32).Value = h.Ncm;
            comando.Parameters.Add("_etapa", MySqlDbType.VarChar).Value = h.Etapa;
            comando.Parameters.Add("_crpe", MySqlDbType.Double).Value = h.Crpe;
            comando.Parameters.Add("_ncur_msr", MySqlDbType.Int32).Value = h.Ncur_msr;
            comando.Parameters.Add("_ncur_r", MySqlDbType.Int32).Value = h.Ncur_r;
            comando.Parameters.Add("_ncre_msr", MySqlDbType.Double).Value = h.Ncre_msr;
            comando.Parameters.Add("_ncre_mr", MySqlDbType.Double).Value = h.Ncre_mr;
            comando.Parameters.Add("_ncre_1", MySqlDbType.Double).Value = h.Ncre_1;
            comando.Parameters.Add("_ncre_2", MySqlDbType.Double).Value = h.Ncre_2;
            comando.Parameters.Add("_ncre_3", MySqlDbType.Double).Value = h.Ncre_3;
            comando.Parameters.Add("_ncre_4", MySqlDbType.Double).Value = h.Ncre_4;
            comando.Parameters.Add("_cahn", MySqlDbType.Double).Value = h.Cahn;
            comando.Parameters.Add("_tcac", MySqlDbType.Double).Value = h.Tcac;
            comando.Parameters.Add("_cdh", MySqlDbType.Double).Value = h.Cdh;
            comando.Parameters.Add("_cur", MySqlDbType.Double).Value = h.Cur;
            comando.Parameters.Add("_cac", MySqlDbType.Double).Value = h.Cac;
            comando.Parameters.Add("_cr", MySqlDbType.Double).Value = h.Cr;
            comando.Parameters.Add("_cah_exi", MySqlDbType.Double).Value = h.Cah_exi;
            comando.Parameters.Add("_cah_exo", MySqlDbType.Double).Value = h.Cah_exo;
            comando.Parameters.Add("_cah_con", MySqlDbType.Double).Value = h.Cah_con;
            comando.Parameters.Add("_ncre_rh", MySqlDbType.Double).Value = h.Ncre_rh;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void actualizar_enHistoriaA(HistoriaAcademica h)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_ACTUALIZAR_HISTORIA";
            comando.Parameters.Add("_id_historia", MySqlDbType.Int32).Value = h.Id_historia_academica;
            comando.Parameters.Add("_ciclo", MySqlDbType.VarChar).Value = h.Ciclo;
            comando.Parameters.Add("_id_especialidad_actual", MySqlDbType.Int32).Value = h.Id_especialidad_actual;
            comando.Parameters.Add("_id_facultad_actual", MySqlDbType.Int32).Value = h.Id_facultad_actual;
            comando.Parameters.Add("_ultimo_ciclom", MySqlDbType.VarChar).Value = h.Ultimo_ciclom;
            comando.Parameters.Add("_craest", MySqlDbType.Double).Value = h.Craest;
            comando.Parameters.Add("_orden", MySqlDbType.Double).Value = h.Orden;
            comando.Parameters.Add("_ncm", MySqlDbType.Int32).Value = h.Ncm;
            comando.Parameters.Add("_etapa", MySqlDbType.VarChar).Value = h.Etapa;
            comando.Parameters.Add("_crpe", MySqlDbType.Double).Value = h.Crpe;
            comando.Parameters.Add("_ncur_msr", MySqlDbType.Int32).Value = h.Ncur_msr;
            comando.Parameters.Add("_ncur_r", MySqlDbType.Int32).Value = h.Ncur_r;
            comando.Parameters.Add("_ncre_msr", MySqlDbType.Double).Value = h.Ncre_msr;
            comando.Parameters.Add("_ncre_mr", MySqlDbType.Double).Value = h.Ncre_mr;
            comando.Parameters.Add("_ncre_1", MySqlDbType.Double).Value = h.Ncre_1;
            comando.Parameters.Add("_ncre_2", MySqlDbType.Double).Value = h.Ncre_2;
            comando.Parameters.Add("_ncre_3", MySqlDbType.Double).Value = h.Ncre_3;
            comando.Parameters.Add("_ncre_4", MySqlDbType.Double).Value = h.Ncre_4;
            comando.Parameters.Add("_cahn", MySqlDbType.Double).Value = h.Cahn;
            comando.Parameters.Add("_tcac", MySqlDbType.Double).Value = h.Tcac;
            comando.Parameters.Add("_cdh", MySqlDbType.Double).Value = h.Cdh;
            comando.Parameters.Add("_cur", MySqlDbType.Double).Value = h.Cur;
            comando.Parameters.Add("_cac", MySqlDbType.Double).Value = h.Cac;
            comando.Parameters.Add("_cr", MySqlDbType.Double).Value = h.Cr;
            comando.Parameters.Add("_cah_exi", MySqlDbType.Double).Value = h.Cah_exi;
            comando.Parameters.Add("_cah_exo", MySqlDbType.Double).Value = h.Cah_exo;
            comando.Parameters.Add("_cah_con", MySqlDbType.Double).Value = h.Cah_con;
            comando.Parameters.Add("_ncre_rh", MySqlDbType.Double).Value = h.Ncre_rh;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<HistoriaAcademica> buscar_enHistoriaA(int id_becadoBUSCAR)
        {
            BindingList<HistoriaAcademica> lista = new BindingList<HistoriaAcademica>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "SELECT * FROM HISTORIA_ACADEMICA;";

            comando.Connection = con;
            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                int id_becado = rs.GetInt32("ID_BECADO");
                if (id_becado == id_becadoBUSCAR)
                {
                    HistoriaAcademica h = new HistoriaAcademica();
                    h.Id_historia_academica = rs.GetInt32("ID_HISTORIA_ACADEMICA");
                    h.Id_becado = id_becado;
                    h.Ciclo = rs.GetString("CICLO");
                    h.Id_especialidad_actual = rs.GetInt32("ID_ESPECIALIDAD_ACTUAL");
                    h.Id_facultad_actual = rs.GetInt32("ID_FACULTAD_ACTUAL");
                    h.Ultimo_ciclom = rs.GetString("ULTIMO_CICLOM");
                    h.Craest = rs.GetDouble("CRAEST");
                    h.Orden = rs.GetDouble("ORDEN");
                    h.Ncm = rs.GetInt32("NCM");
                    h.Etapa = rs.GetString("ETAPA");
                    h.Crpe = rs.GetDouble("CRPE");
                    h.Ncur_msr = rs.GetInt32("NCUR_MSR");
                    h.Ncur_r = rs.GetInt32("NCUR_R");
                    h.Ncre_msr = rs.GetDouble("NCRE_MSR");
                    h.Ncre_mr = rs.GetDouble("NCRE_MR");
                    h.Ncre_1 = rs.GetDouble("NCRE_1");
                    h.Ncre_2 = rs.GetDouble("NCRE_2");
                    h.Ncre_3 = rs.GetDouble("NCRE_3");
                    h.Ncre_4 = rs.GetDouble("NCRE_4");
                    h.Cahn = rs.GetDouble("CAHN");
                    h.Tcac = rs.GetDouble("TCAC");
                    h.Cdh = rs.GetDouble("CDH");
                    h.Cur = rs.GetDouble("CUR");
                    h.Cac = rs.GetDouble("CAC");
                    h.Cr = rs.GetDouble("CR");
                    h.Cah_exi = rs.GetDouble("CAH_EXI");
                    h.Cah_exo = rs.GetDouble("CAH_EXO");
                    h.Cah_con = rs.GetDouble("CAH_CON");
                    h.Ncre_rh = rs.GetDouble("NCRE_RH");

                    lista.Add(h);
                }
            }
            con.Close();
            return lista;
        }
    }
}
