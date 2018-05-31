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
    public class Alumno_x_BecaBL
    {
        private Alumno_x_BecaDA accesoDatos;
        public Alumno_x_BecaBL()
        {
            accesoDatos = new Alumno_x_BecaDA();
        }
        public void RegistrarBecaxAlumno(Alumno_x_Beca axb)
        {
            accesoDatos.Registrar_enAlumno_x_Beca(axb);
        }
        public BindingList<Alumno_x_Beca> BuscarBecaxAlumno(int id_alumno)
        {
            BindingList<Alumno_x_Beca> lista = accesoDatos.Buscar_BecasxAlumno(id_alumno);
            BindingList<Alumno_x_Beca> ltsOrdenada = new BindingList<Alumno_x_Beca>(lista.OrderBy(x => x.Ciclo).ToList());
            return ltsOrdenada;

        }
        public void ActualizarBecaxAlumno(Alumno_x_Beca axb)
        {
            accesoDatos.actualizarAlumno_x_Beca(axb);
        }
    }
}
