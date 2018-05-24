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
        public BindingList<Convocatoria> listarConvocatorias()
        {
            return convocatoriaDA.listarConvocatorias();
        }

        public int agregarConvocatoria(Convocatoria convocatoria)
        {
            return convocatoriaDA.agregarConvocatoria(convocatoria);
        }
 
        public BindingList<Convocatoria> listarFiltroNombre(string nombre)
        {
            return convocatoriaDA.listarFiltroNombre(nombre);
        }

        public BindingList<Convocatoria> listarFiltroCiclo(string ciclo)
        {
            return convocatoriaDA.listarFiltroCiclo(ciclo);
        }
    }
}
