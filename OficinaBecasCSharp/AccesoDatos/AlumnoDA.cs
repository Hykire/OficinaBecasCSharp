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
    public class AlumnoDA
    {
        private BindingList<Especialidad> mylts_Especialidad;
        public AlumnoDA()
        {
            mylts_Especialidad = new BindingList<Especialidad>();
            EspecialidadDA E_DA = new EspecialidadDA();
            mylts_Especialidad = E_DA.lstEspecialidad();
        }
        public int ObtenerMaxId()
        {
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT MAX(ID_PERSONA) AS ID_PERSONA FROM _F_PERSONA;";
            comando.Connection = con;
            int idx = (Int32)comando.ExecuteScalar();
            con.Close();
            return idx;
        }
        public void Registrar_enPersonas(Alumno a)
        {
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO _F_PERSONA(CODIGO_PUCP,NOMBRES,APELLIDOS,SEXO,DNI,EDAD," +
                "FECHA_NACIMIENTO,CORREO_PUCP,CORREO_ALTERNATIVO,TELF_MOVIL,TELF_FIJO) VALUES" +
                "(" + a.CodigoPUCP + ",'" + a.Nombres + "','" + a.Apellidos + "','" + a.Sexo + "'," +
                a.Dni + "," + a.Edad + ",'" + a.Fecha_nacimiento + "','" + a.CorreoPUCP + "','" +
                a.CorreoAlternativo + "','" + a.TelfMovil + "','" + a.TelfFijo + "');";
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }
        public void Registrar_enAlumno(Alumno a, int id_especialidad, int id_alumno)
        {
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO _F_ALUMNO(ID_ALUMNO,CICLO_INGRESO,ID_ESPECIALIDAD,TIPO_GRUPO," +
                "DISTRITO_NACIMIENTO,PROVINCIA_NACIMIENTO,DEPARTAMENTO_NACIMIENTO,PAIS_NACIMIENTO,DIRECCION," +
                "DISTRITO_ACTUAL,PROVINCIA_ACTUAL,DEPARTAMENTO_ACTUAL) VALUES" +
                "(" + id_alumno + " ,'" + a.Ciclo_ingreso + "'," + id_especialidad + ",'" + a.Tipo_grupo + "','" +
                a.Distrito_nacimiento + "','" + a.Provincia_nacimiento + "','" + a.Departamento_nacimiento + "','" + a.Pais_nacimiento + "','" +
                a.Direccion + "','" + a.Distrito_actual + "','" + a.Provincia_actual + "','" + a.Departamento_actual + "');";
            System.Console.WriteLine(comando.CommandText);
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Actualizar_enTAlumnoTPersona(Alumno a, int id_especialidad)
        {
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //primer update
            MySqlCommand comando_1 = new MySqlCommand();
            comando_1.CommandText = "UPDATE _F_PERSONA SET CODIGO_PUCP=" + a.CodigoPUCP + ",NOMBRES='" + a.Nombres + "',APELLIDOS='" + a.Apellidos +
                "',SEXO='" + a.Sexo + "',DNI=" + a.Dni + ",EDAD=" + a.Edad + ",FECHA_NACIMIENTO='" + a.Fecha_nacimiento +
                "',CORREO_PUCP='" + a.CorreoPUCP + "',CORREO_ALTERNATIVO='" + a.CorreoAlternativo + "',TELF_MOVIL='" +
                a.TelfMovil + "',TELF_FIJO='" + a.TelfFijo + "' WHERE ID_PERSONA=" + a.Id_persona + ";";
            comando_1.Connection = con;
            comando_1.ExecuteNonQuery();

            //segundo update
            MySqlCommand comando_2 = new MySqlCommand();
            comando_2.CommandText = "UPDATE _F_ALUMNO SET CICLO_INGRESO='" + a.Ciclo_ingreso + "',ID_ESPECIALIDAD=" + id_especialidad +
                ",TIPO_GRUPO='" + a.Tipo_grupo + "',DISTRITO_NACIMIENTO='" + a.Distrito_nacimiento + "',PROVINCIA_NACIMIENTO='" + a.Provincia_nacimiento +
                "',DEPARTAMENTO_NACIMIENTO='" + a.Departamento_nacimiento +
                "',PAIS_NACIMIENTO='" + a.Pais_nacimiento + "',DIRECCION='" + a.Direccion + "',DISTRITO_ACTUAL='" +
                a.Distrito_actual + "',PROVINCIA_ACTUAL='" + a.Provincia_actual + "',DEPARTAMENTO_ACTUAL='" + a.Departamento_actual +
                "' WHERE ID_ALUMNO=" + a.Id_persona + ";";
            comando_2.Connection = con;
            comando_2.ExecuteNonQuery();

            con.Close();
        }

        public BindingList<Alumno> Buscar_enTAlumno()
        {
            BindingList<Alumno> lista = new BindingList<Alumno>();
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM _F_ALUMNO";
            comando.Connection = con;
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Alumno a = new Alumno();
                a.Id_persona = rs.GetInt32("ID_ALUMNO");
                a.Ciclo_ingreso = rs.GetString("CICLO_INGRESO");
                a.Tipo_grupo = rs.GetString("TIPO_GRUPO");
                a.Distrito_nacimiento = rs.GetString("DISTRITO_NACIMIENTO");
                a.Provincia_nacimiento = rs.GetString("PROVINCIA_NACIMIENTO");
                a.Departamento_nacimiento = rs.GetString("DEPARTAMENTO_NACIMIENTO");
                a.Pais_nacimiento = rs.GetString("PAIS_NACIMIENTO");
                a.Direccion = rs.GetString("DIRECCION");
                a.Distrito_actual = rs.GetString("DISTRITO_ACTUAL");
                a.Provincia_actual = rs.GetString("PROVINCIA_ACTUAL");
                a.Departamento_actual = rs.GetString("DEPARTAMENTO_ACTUAL");

                Especialidad e = new Especialidad();
                e.Id_especialidad = rs.GetInt32("ID_ESPECIALIDAD");
                foreach (Especialidad x in mylts_Especialidad)
                {
                    if (e.Id_especialidad == x.Id_especialidad)
                    {
                        e.Nombre = x.Nombre;
                        break;
                    }
                }
                a.Especialidad = e;
                lista.Add(a);
            }
            con.Close();
            return lista;
        }
        public void Buscar_enTPersona(BindingList<Alumno> lista)
        {
            //coneccion a BD
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                            "user=inf282g6;database=inf282g6;" +
                            "port=3306;password=Nk2ewy;SslMode=none;" + "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            //
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM _F_PERSONA";
            comando.Connection = con;
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                int id = rs.GetInt32("ID_PERSONA");
                foreach (Alumno a in lista)
                {
                    if (a.Id_persona == id)
                    {
                        a.CodigoPUCP = rs.GetInt32("CODIGO_PUCP");
                        a.Nombres = rs.GetString("NOMBRES");
                        a.Apellidos = rs.GetString("APELLIDOS");
                        a.Sexo = rs.GetChar("SEXO");
                        a.Dni = rs.GetInt32("DNI");
                        a.Fecha_nacimiento = rs.GetString("FECHA_NACIMIENTO");
                        a.CorreoPUCP = rs.GetString("CORREO_PUCP");
                        a.CorreoAlternativo = rs.GetString("CORREO_ALTERNATIVO");
                        a.TelfMovil = rs.GetString("TELF_MOVIL");
                        a.TelfFijo = rs.GetString("TELF_FIJO");
                        break;
                    }
                }
            }
            con.Close();
        }
    }
}
