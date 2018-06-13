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
    public class BecadoBL
    {
        private BecadoDA accesoDatos;

        public BecadoBL() { accesoDatos = new BecadoDA(); }

        //hecho por Francisco
        public int registrarAlumno(Becado a)
        {
            int idx = accesoDatos.registrar_enPersona(a); //registra en la tabla personas;
            int idx_becado = accesoDatos.registrar_enBecado(a, idx); //registra en la tabla becado
            return idx_becado;
        }
        //hecho por Francisco
        public void actualizarAlumno(Becado a) { accesoDatos.actualizar_enBecado(a); }
        //hecho por Francisco
        public BindingList<Becado> buscarAlumno(string codigoB, string nombreB, string apellidoB)
        {
            BindingList<Becado> lista = accesoDatos.buscar_enBecado(); //lista todos los becados
            accesoDatos.buscar_enPersona(lista); //actualiza a la lista de becados con sus datos de persona
            BindingList<Becado> listaB = new BindingList<Becado>(); //listaB tendrá los becados de acuerdo a los parametros de busqueda

            if (codigoB != "") //si se ingreso un codigo
            {
                bool esNumero = int.TryParse(codigoB, out int codigo);
                if (esNumero == true)
                {
                    if (nombreB != "" && apellidoB != "")
                    {
                        foreach (Becado a in lista)
                        {
                            if (a.CodigoPUCP == codigo && a.Nombres.Contains(nombreB) == true && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); break; }
                        }
                    }
                    if (nombreB != "" && apellidoB == "")
                    {
                        foreach (Becado a in lista)
                        {
                            if (a.CodigoPUCP == codigo && a.Nombres.Contains(nombreB) == true) { listaB.Add(a); break; }
                        }
                    }
                    if (nombreB == "" && apellidoB != "")
                    {
                        foreach (Becado a in lista)
                        {
                            if (a.CodigoPUCP == codigo && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); break; }
                        }
                    }
                    if (nombreB == "" && apellidoB == "")
                    {
                        foreach (Becado a in lista)
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
                    foreach (Becado a in lista)
                    {
                        if (a.Nombres.Contains(nombreB) == true && a.Apellidos.Contains(apellidoB) == true) { listaB.Add(a); }
                    }
                }
                if (nombreB != "" && apellidoB == "")
                {
                    foreach (Becado a in lista)
                    {
                        if (a.Nombres.Contains(nombreB) == true) { listaB.Add(a); }
                    }
                }
                if (nombreB == "" && apellidoB != "")
                {
                    foreach (Becado a in lista)
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

        //--?
        public BindingList<Becado> listarBecarios(String cod)
        {
            return accesoDatos.listarBecarios(cod);
        }

        public Becado buscarBecado(String cod)
        {
            return accesoDatos.buscarBecado(cod);
        }

    }
}
