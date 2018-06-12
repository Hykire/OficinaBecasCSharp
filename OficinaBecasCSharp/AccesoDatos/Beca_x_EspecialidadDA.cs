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
    public class Beca_x_EspecialidadDA
    {
        public void eliminarBeca_x_Especialidad(Beca b)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "DELETE FROM BECA_X_ESPECIALIDAD WHERE ID_BECA=" + b.Id_beca.ToString();
            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<int> obtenerEspecialidades_BxE(Beca b)
        {
            BindingList<int> lista = new BindingList<int>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "SELECT * FROM BECA_X_ESPECIALIDAD WHERE ID_BECA=" + b.Id_beca.ToString() ;
            comando.Connection = con;
            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                lista.Add(rs.GetInt32("ID_ESPECIALIDAD"));
            }
            con.Close();
            return lista;
        }

        public void agregarEspecialidades_BxE(Beca b, BindingList<int> espe)
        {
            BindingList<int> lista = new BindingList<int>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = con;
            con.Open();
            foreach(int i in espe)
            {
                comando.CommandText = "INSERT INTO BECA_X_ESPECIALIDAD(ID_BECA, ID_ESPECIALIDAD) VALUES(" + b.Id_beca.ToString() + "," + i.ToString() + ");";
                comando.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
