using Modelo;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Controlador
{
    public class AlumnoBL
    {
        private AlumnoDA accesoDatos;

        public AlumnoBL()
        {
            accesoDatos = new AlumnoDA();
        }

        public void RegistrarAlumno(Alumno a, int id_especialidad)
        {
            //la primera parte es el registro en la tabla personas y la segunda en la tabla alumno
            accesoDatos.Registrar_enPersonas(a);
            int idx = accesoDatos.ObtenerMaxId();
            accesoDatos.Registrar_enAlumno(a, id_especialidad, idx);
        }
        public void ActualizarAlumno(Alumno a, int id_especialidad)
        {
            accesoDatos.Actualizar_enTAlumnoTPersona(a, id_especialidad);
        }
        public BindingList<Alumno> BuscarAlumno(string codigoB, string nombreB, string apellidoB)
        {

            BindingList<Alumno> lista = accesoDatos.Buscar_enTAlumno();
            accesoDatos.Buscar_enTPersona(lista);

            BindingList<Alumno> listaB = new BindingList<Alumno>();

            if (codigoB != "") //si se ingreso un codigo
            {
                bool esNumero = int.TryParse(codigoB, out int codigo);
                if (esNumero == true)
                {
                    if (nombreB != "" && apellidoB != "")
                    {
                        foreach (Alumno a in lista)
                        {
                            if (a.CodigoPUCP == codigo && a.Nombres.Contains(nombreB) == true && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); break; }
                        }
                    }
                    if (nombreB != "" && apellidoB == "")
                    {
                        foreach (Alumno a in lista)
                        {
                            if (a.CodigoPUCP == codigo && a.Nombres.Contains(nombreB) == true) { listaB.Add(a); break; }
                        }
                    }
                    if (nombreB == "" && apellidoB != "")
                    {
                        foreach (Alumno a in lista)
                        {
                            if (a.CodigoPUCP == codigo && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); break; }
                        }
                    }
                    if (nombreB == "" && apellidoB == "")
                    {
                        foreach (Alumno a in lista)
                        {
                            if (a.CodigoPUCP == codigo) { listaB.Add(a); break; }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error, el codigo ingresado no es un número", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //si no se ingreso un codigo...
            {
                if (nombreB != "" && apellidoB != "")
                {
                    foreach (Alumno a in lista)
                    {
                        if (a.Nombres.Contains(nombreB) == true && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); }
                    }
                }
                if (nombreB != "" && apellidoB == "")
                {
                    foreach (Alumno a in lista)
                    {
                        if (a.Nombres.Contains(nombreB) == true) { listaB.Add(a); }
                    }
                }
                if (nombreB == "" && apellidoB != "")
                {
                    foreach (Alumno a in lista)
                    {
                        if (a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); }
                    }
                }
                if (nombreB == "" && apellidoB == "")
                {
                    return listaB;
                }
            }
            return listaB;
        }
    }
}
