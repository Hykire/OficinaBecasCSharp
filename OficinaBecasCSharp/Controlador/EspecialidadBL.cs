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
    public class EspecialidadBL
    {
        private EspecialidadDA accesoDatos;

        public EspecialidadBL()
        {
            accesoDatos = new EspecialidadDA();
        }

        public BindingList<Especialidad> listarEspecialidad()
        {
            BindingList<Especialidad> lista = accesoDatos.lstEspecialidad();
            accesoDatos.agregarFacultad(lista);

            BindingList<Especialidad> ltsOrdenada = new BindingList<Especialidad>(lista.OrderBy(x => x.Nombre).ToList());
            return ltsOrdenada;
        }
    }
}
