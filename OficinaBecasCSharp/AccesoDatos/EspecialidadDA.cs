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
    public class EspecialidadDA
    {
        public BindingList<Especialidad> lstEspecialidad()
        {
            BindingList<Especialidad> lista = new BindingList<Especialidad>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM ESPECIALIDAD";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Especialidad e = new Especialidad();
                e.Id_especialidad = rs.GetInt32("ID_ESPECIALIDAD");
                e.Nombre = rs.GetString("NOMBRE_ESPECIALIDAD");

                Facultad f = new Facultad();
                f.Id_facultad = rs.GetInt32("ID_FACULTAD");
                e.Facultad = f;

                lista.Add(e);
            }
            con.Close();
            return lista;
        }
        public void agregarFacultad(BindingList<Especialidad> lista)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM FACULTAD";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                int id_facultad = rs.GetInt32("ID_FACULTAD");
                foreach (Especialidad e in lista)
                {
                    if (id_facultad == e.Facultad.Id_facultad)
                    {
                        e.Facultad.Nombre = rs.GetString("NOMBRE_FACULTAD");
                        e.Facultad.Pabellon = rs.GetChar("PABELLON");
                    }
                }
            }
            con.Close();
        }
    }
}
