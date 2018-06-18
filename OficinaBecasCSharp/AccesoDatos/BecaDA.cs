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
        //hecho por Francisco
        public BindingList<Beca> listarBeca()
        {
            BindingList<Beca> lista = new BindingList<Beca>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "SELECT * FROM BECA";
            comando.Connection = con;
            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Beca b = new Beca();
                b.Id_beca = rs.GetInt32("ID_BECA");
                b.Nombre_beca = rs.GetString("NOMBRE_BECA");
                b.Descripcion = rs.GetString("DESCRIPCION");
                b.Financiador = rs.GetString("FINANCIADOR");
                b.Estado = rs.GetString("ESTADO");
                lista.Add(b);
            }
            con.Close();
            return lista;
        }
        //hecho por Francisco
        public void registrarBeca(Beca b)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_BECA";
            comando.Parameters.Add("_nombre_beca", MySqlDbType.VarChar).Value = b.Nombre_beca;
            comando.Parameters.Add("_descripcion", MySqlDbType.VarChar).Value = b.Descripcion;
            comando.Parameters.Add("_financiador", MySqlDbType.VarChar).Value = b.Financiador;
            comando.Parameters.Add("_estado", MySqlDbType.VarChar).Value = b.Estado;
            comando.Parameters.Add("_id", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            b.Id_beca = Int32.Parse(comando.Parameters["_id"].Value.ToString());
            con.Close();
        }
        //hecho por Francisco
        public void editarBeca(Beca b)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            string aux = "UPDATE BECA SET ";
            string nombre = "NOMBRE_BECA='" + b.Nombre_beca + "',";
            string descrip = "DESCRIPCION='" + b.Descripcion + "',";
            string financiador = "FINANCIADOR='" + b.Financiador + "',";
            string estado = "ESTADO='" + b.Estado + "' ";
            string _where = "WHERE ID_BECA=" + b.Id_beca.ToString() + ";";
            comando.CommandText = aux + nombre + descrip + financiador + estado + _where;
            System.Console.WriteLine(comando.CommandText);

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
        //hechor por Francisco
        public BindingList<Beca> listarBecaPorEspecialidad(int id_especialidad)
        {
            BindingList<Beca> lista = new BindingList<Beca>();

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();

            string aux_1 = "SELECT B.ID_BECA, B.NOMBRE_BECA, B.DESCRIPCION, B.FINANCIADOR, B.ESTADO FROM BECA B INNER JOIN BECA_X_ESPECIALIDAD E ";
            string aux_2 = "WHERE E.ID_BECA = B.ID_BECA AND B.ESTADO = 'ACTIVO' AND E.ID_ESPECIALIDAD = " + id_especialidad.ToString()+ ";";
            comando.CommandText = aux_1 + aux_2;

            comando.Connection = con;
            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();

            while (rs.Read())
            {
                Beca b = new Beca();
                b.Id_beca = rs.GetInt32("ID_BECA");
                b.Nombre_beca = rs.GetString("NOMBRE_BECA");
                b.Descripcion = rs.GetString("DESCRIPCION");
                b.Financiador = rs.GetString("FINANCIADOR");
                b.Estado = rs.GetString("ESTADO");
                lista.Add(b);
            }
            con.Close();
            return lista;
        }




        //----?
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
                beca.Descripcion = reader.GetString("descripcion");
                //beca.FechaConvocatoria = reader.GetDateTime("fechaConvocatoria");
                beca.Financiador = reader.GetString("Financiador");

                becas.Add(beca);
            }
            con.Close();
            return becas;
        }
        //---?
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
