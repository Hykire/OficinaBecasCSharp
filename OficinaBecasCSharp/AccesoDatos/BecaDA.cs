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
            comando.CommandText = "SELECT * FROM BECA";
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

        public BindingList<Beca> listarBecas()
        {
            BindingList<Beca> becas = new BindingList<Beca>();
            string cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_BECAS";
            comando.Connection = con;
            con.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("id_beca");
                beca.Nombre_beca = reader.GetString("nombre_beca");
                beca.Descripcion = reader.GetString("descrip_beca");
                beca.FechaConvocatoria = reader.GetDateTime("fechaConvocatoria");
                beca.Financiador = reader.GetString("Financiador");

                becas.Add(beca);
            }
            con.Close();
            return becas;
        }






        public BindingList<Beca> listarBecaSolicitada(string name)
        {
            BindingList<Beca> becas = new BindingList<Beca>();

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                           "user=inf282g6;database=inf282g6;" +
                           "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM BECA where NOMBRE_BECA LIKE '" + name + "%'";
            comando.Connection = con;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Beca beca = new Beca();
                beca.Id_beca = reader.GetInt32("ID_BECA");
                beca.Nombre_beca = reader.GetString("NOMBRE_BECA");
                beca.Descripcion = reader.GetString("DESCRIPCION");
                //beca.FechaConvocatoria = reader.GetDateTime("fechaConvocatoria");
                beca.Financiador = reader.GetString("FINANCIADOR");

                becas.Add(beca);
            }
            con.Close();
            return becas;
        }
    }
}
