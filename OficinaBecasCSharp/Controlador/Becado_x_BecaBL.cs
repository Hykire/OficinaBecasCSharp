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
    public class Becado_x_BecaBL
    {
        private Becado_x_BecaDA accesoDatos;
        public Becado_x_BecaBL()
        {
            accesoDatos = new Becado_x_BecaDA();
        }
        public void RegistrarBecaxAlumno(Becado_x_Beca axb)
        {
            accesoDatos.Registrar_enAlumno_x_Beca(axb);
        }
        public BindingList<Becado_x_Beca> BuscarBecaxAlumno(int id_alumno)
        {
            BindingList<Becado_x_Beca> lista = accesoDatos.Buscar_BecasxAlumno(id_alumno);
            BindingList<Becado_x_Beca> ltsOrdenada = new BindingList<Becado_x_Beca>(lista.OrderBy(x => x.Ciclo).ToList());
            return ltsOrdenada;

        }
        public void ActualizarBecaxAlumno(Becado_x_Beca axb)
        {
            accesoDatos.actualizarAlumno_x_Beca(axb);
        }
    }
}
