using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ConvocatoriaBL
    {
        private ConvocatoriaDA convocatoriaDA;
        public ConvocatoriaBL()
        {
            convocatoriaDA = new ConvocatoriaDA();
        }
        public BindingList<Convocatoria> listarConvocatoriasActuales(string ciclo, string ciclo2)
        {
            return convocatoriaDA.listarConvocatoriasActuales(ciclo, ciclo2);
        }

        public int agregarConvocatoria(Convocatoria convocatoria)
        {
            return convocatoriaDA.agregarConvocatoria(convocatoria);
        }
 
        public BindingList<Convocatoria> listarFiltroNombreAnterior(string nombre, string ciclo, string ciclo2)
        {
            return convocatoriaDA.listarFiltroNombreAnterior(nombre,ciclo, ciclo2);
        }
        public BindingList<Convocatoria> listarFiltroNombreActual(string nombre, string ciclo, string ciclo2)
        {
            return convocatoriaDA.listarFiltroNombreActual(nombre,ciclo, ciclo2);
        }

        public BindingList<Convocatoria> filtroConvocatorias(string ciclo)
        {
            return convocatoriaDA.filtroConvocatorias(ciclo);
        }
        public BindingList<Convocatoria> listarConvocatoriasAnteriores(string ciclo, string ciclo2)
        {
            return convocatoriaDA.listarConvocatoriasAnteriores(ciclo, ciclo2);
        }

        public void actualizarConvocatoria(Convocatoria convocatoria)
        {
            convocatoriaDA.actualizarConvocatoria(convocatoria);
        }

        public void eliminarConvocatoria(Convocatoria convocatoria)
        {
            convocatoriaDA.eliminarConvocatoria(convocatoria);
        }

        public BindingList<string> ciclosAnteriores(string ciclo, string ciclo2)
        {
            return convocatoriaDA.ciclosAnteriores(ciclo, ciclo2);
        }

        public BindingList<Convocatoria> filtroNombreCiclo(string nombre, string ciclo)
        {
            return convocatoriaDA.filtroNombreCiclo(nombre, ciclo);
        }
    }
}
