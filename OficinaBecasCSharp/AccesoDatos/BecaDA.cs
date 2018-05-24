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
    public class BecaDA
    {
        public BindingList<Beca> lstEspecialidad()
        {
            BindingList<Beca> lista = new BindingList<Beca>();
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM _F_BECA";
            comando.Connection = con;
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Beca b = new Beca();
                b.Id_beca = rs.GetInt32("ID_BECA");
                b.Nombre_beca = rs.GetString("NOMBRE_BECA");
                b.Descripcion = rs.GetString("DESCRIPCION");
                lista.Add(b);
            }
            con.Close();
            return lista;
        }
    }
}
