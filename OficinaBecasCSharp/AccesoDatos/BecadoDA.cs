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
    public class BecadoDA
    {
        public int registrar_enPersona(Becado a)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_PERSONA";
            comando.Parameters.Add("_codigo_pucp", MySqlDbType.Int32).Value = a.CodigoPUCP;
            comando.Parameters.Add("_nombres", MySqlDbType.VarChar).Value = a.Nombres;
            comando.Parameters.Add("_apellidos", MySqlDbType.VarChar).Value = a.Apellidos;
            comando.Parameters.Add("_sexo", MySqlDbType.VarChar).Value = a.Sexo;
            comando.Parameters.Add("_dni", MySqlDbType.Int32).Value = a.Dni;
            comando.Parameters.Add("_edad", MySqlDbType.Int32).Value = a.Edad;
            comando.Parameters.Add("_fecha_nacimiento", MySqlDbType.Date).Value = a.Fecha_nacimiento;
            comando.Parameters.Add("_correo_pucp", MySqlDbType.VarChar).Value = a.CorreoPUCP;
            comando.Parameters.Add("_correo_alternativo", MySqlDbType.VarChar).Value = a.CorreoAlternativo;
            comando.Parameters.Add("_telf_movil", MySqlDbType.VarChar).Value = a.TelfMovil;
            comando.Parameters.Add("_telf_fijo", MySqlDbType.VarChar).Value = a.TelfFijo;
            comando.Parameters.Add("_estado", MySqlDbType.VarChar).Value = a.Estado;
            comando.Parameters.Add("_id_usuario", MySqlDbType.Int32).Value = 1;

            comando.Parameters.Add("_id", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            int id = Int32.Parse(comando.Parameters["_id"].Value.ToString());
            con.Close();

            return id;
        }

        public int registrar_enBecado(Becado a, int id_persona)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_INSERTAR_BECADO";
            comando.Parameters.Add("_id_persona", MySqlDbType.Int32).Value = id_persona;
            comando.Parameters.Add("_id_especialidad", MySqlDbType.Int32).Value = a.Especialidad;
            comando.Parameters.Add("_id_facultad", MySqlDbType.Int32).Value = a.Facultad;
            comando.Parameters.Add("_ciclo_ingreso", MySqlDbType.VarChar).Value = a.Ciclo_ingreso;
            comando.Parameters.Add("_tipo_grupo", MySqlDbType.VarChar).Value = a.Tipo_grupo;
            comando.Parameters.Add("_distrito_nacimiento", MySqlDbType.VarChar).Value = a.Distrito_nacimiento;
            comando.Parameters.Add("_provincia_nacimiento", MySqlDbType.VarChar).Value = a.Provincia_nacimiento;
            comando.Parameters.Add("_departamento_nacimiento", MySqlDbType.VarChar).Value = a.Departamento_nacimiento;
            comando.Parameters.Add("_pais_nacimiento", MySqlDbType.VarChar).Value = a.Pais_nacimiento;
            comando.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = a.Direccion;
            comando.Parameters.Add("_distrito_actual", MySqlDbType.VarChar).Value = a.Distrito_actual;
            comando.Parameters.Add("_provincia_actual", MySqlDbType.VarChar).Value = a.Provincia_actual;
            comando.Parameters.Add("_departamento_actual", MySqlDbType.VarChar).Value = a.Departamento_actual;
            comando.Parameters.Add("_id", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            int id = Int32.Parse(comando.Parameters["_id"].Value.ToString());
            con.Close();

            return id;
        }

        public void actualizar_enBecado(Becado a)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.CommandText = "F_ACTUALIZAR_BECADO";
            comando.Parameters.Add("_id_becado", MySqlDbType.Int32).Value = a.Id_becado;
            comando.Parameters.Add("_id_persona", MySqlDbType.Int32).Value = a.Id_persona;
            comando.Parameters.Add("_id_especialidad", MySqlDbType.Int32).Value = a.Especialidad;
            comando.Parameters.Add("_id_facultad", MySqlDbType.Int32).Value = a.Facultad;
            comando.Parameters.Add("_ciclo_ingreso", MySqlDbType.VarChar).Value = a.Ciclo_ingreso;
            comando.Parameters.Add("_tipo_grupo", MySqlDbType.VarChar).Value = a.Tipo_grupo;
            comando.Parameters.Add("_distrito_nacimiento", MySqlDbType.VarChar).Value = a.Distrito_nacimiento;
            comando.Parameters.Add("_provincia_nacimiento", MySqlDbType.VarChar).Value = a.Provincia_nacimiento;
            comando.Parameters.Add("_departamento_nacimiento", MySqlDbType.VarChar).Value = a.Departamento_nacimiento;
            comando.Parameters.Add("_pais_nacimiento", MySqlDbType.VarChar).Value = a.Pais_nacimiento;
            comando.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = a.Direccion;
            comando.Parameters.Add("_distrito_actual", MySqlDbType.VarChar).Value = a.Distrito_actual;
            comando.Parameters.Add("_provincia_actual", MySqlDbType.VarChar).Value = a.Provincia_actual;
            comando.Parameters.Add("_departamento_actual", MySqlDbType.VarChar).Value = a.Departamento_actual;

            comando.Parameters.Add("_codigo_pucp", MySqlDbType.Int32).Value = a.CodigoPUCP;
            comando.Parameters.Add("_nombres", MySqlDbType.VarChar).Value = a.Nombres;
            comando.Parameters.Add("_apellidos", MySqlDbType.VarChar).Value = a.Apellidos;
            comando.Parameters.Add("_sexo", MySqlDbType.VarChar).Value = a.Sexo;
            comando.Parameters.Add("_dni", MySqlDbType.Int32).Value = a.Dni;
            comando.Parameters.Add("_edad", MySqlDbType.Int32).Value = a.Edad;
            comando.Parameters.Add("_fecha_nacimiento", MySqlDbType.Date).Value = a.Fecha_nacimiento;
            comando.Parameters.Add("_correo_pucp", MySqlDbType.VarChar).Value = a.CorreoPUCP;
            comando.Parameters.Add("_correo_alternativo", MySqlDbType.VarChar).Value = a.CorreoAlternativo;
            comando.Parameters.Add("_telf_movil", MySqlDbType.VarChar).Value = a.TelfMovil;
            comando.Parameters.Add("_telf_fijo", MySqlDbType.VarChar).Value = a.TelfFijo;
            comando.Parameters.Add("_estado", MySqlDbType.VarChar).Value = a.Estado;

            comando.Connection = con;
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public BindingList<Becado> buscar_enBecado()
        {
            BindingList<Becado> lista = new BindingList<Becado>();

            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM BECADO";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                Becado a = new Becado();
                a.Id_becado = rs.GetInt32("ID_BECADO");
                a.Id_persona = rs.GetInt32("ID_PERSONA");
                a.Especialidad = rs.GetInt32("ID_ESPECIALIDAD_INGRESO");
                a.Facultad = rs.GetInt32("ID_FACULTAD_INGRESO");
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
                lista.Add(a);
            }
            con.Close();
            return lista;
        }

        public void buscar_enPersona(BindingList<Becado> lista)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g6;" + "database=inf282g6;" + "port=3306;" + "password=Nk2ewy;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM PERSONA";
            comando.Connection = con;

            con.Open();
            MySqlDataReader rs = comando.ExecuteReader();
            while (rs.Read())
            {
                int id = rs.GetInt32("ID_PERSONA");
                foreach (Becado a in lista)
                {
                    if (a.Id_persona == id)
                    {
                        a.CodigoPUCP = rs.GetInt32("CODIGO_PUCP");
                        a.Nombres = rs.GetString("NOMBRES");
                        a.Apellidos = rs.GetString("APELLIDOS");
                        a.Sexo = rs.GetChar("SEXO");
                        a.Dni = rs.GetInt32("DNI");
                        a.Fecha_nacimiento = rs.GetDateTime("FECHA_NACIMIENTO");
                        a.CorreoPUCP = rs.GetString("CORREO_PUCP");
                        a.CorreoAlternativo = rs.GetString("CORREO_ALTERNATIVO");
                        a.TelfMovil = rs.GetString("TELF_MOVIL");
                        a.TelfFijo = rs.GetString("TELF_FIJO");
                        a.Estado = rs.GetString("ESTADO");
                        break;
                    }
                }
            }
            con.Close();
        }

        public BindingList<Becado> listarBecarios(String cod)
        {
            BindingList<Becado> lista = new BindingList<Becado>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" +
                "user=inf282g6;database=inf282g6;" +
                "port=3306;password=Nk2ewy;SslMode=none;" +
                "";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand();
            if (cod.Length == 0)
            {
                comando.CommandText = "SELECT P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.CORREO_PUCP, B.ID_BECADO FROM PERSONA P INNER JOIN BECADO B WHERE P.ID_PERSONA = B.ID_PERSONA";
                comando.Connection = con;

            }
            else
            {
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "Y_BUSCAR_BECARIO";

                comando.Connection = con;
                comando.Parameters.AddWithValue("codBec", cod);

            }
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //P.CODIGO_PUCP, P.NOMBRES, P.APELLIDOS, P.CORREO_PUCP, B.ID_BECADO FROM PERSONA P
                Becado per = new Becado();
                per.CodigoPUCP = reader.GetInt32("CODIGO_PUCP");
                per.Nombres = reader.GetString("NOMBRES");
                per.Apellidos = reader.GetString("APELLIDOS");
                //es id becario 
                per.Id_becado = reader.GetInt32("ID_BECADO");
                per.CorreoPUCP = reader.GetString("CORREO_PUCP");
                lista.Add(per);
            }
            con.Close();
            return lista;
        }
    }
}
