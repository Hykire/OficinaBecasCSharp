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
    public class BecaBL
    {
        private BecaDA accesoDatos;
        private Beca_x_EspecialidadDA accesoDatos_BxE;
        public BecaBL() { accesoDatos = new BecaDA(); accesoDatos_BxE = new Beca_x_EspecialidadDA(); }

        //hecho por Francisco
        public BindingList<Beca> listar_Beca()
        {
            BindingList<Beca> lista = accesoDatos.listarBeca();
            BindingList<Beca> ltsOrdenada = new BindingList<Beca>(lista.OrderBy(x => x.Nombre_beca).ToList());
            return ltsOrdenada;
        }
        //hecho por Francisco
        public void registrar_Beca(Beca b, BindingList<int> esp)
        {
            //se registra en la tabla becas
            accesoDatos.registrarBeca(b);
            //se registra en la tabla becas_x_especialidad
            accesoDatos_BxE.agregarEspecialidades_BxE(b, esp);
        }
        //hecho por Francisco
        public void modificar_Beca(Beca b, BindingList<int> esp)
        {
            accesoDatos.editarBeca(b);
            accesoDatos_BxE.eliminarBeca_x_Especialidad(b);
            accesoDatos_BxE.agregarEspecialidades_BxE(b, esp);
        }
        //hecho por Francisco
        public BindingList<int> obtener_especialidadesBeca(Beca b)
        {
            return accesoDatos_BxE.obtenerEspecialidades_BxE(b);
        }
        //hecho por Francisco
        public BindingList<Beca> listar_BecaPorEspecialidad(int id_especialidad)
        {
            BindingList<Beca> lista = accesoDatos.listarBecaPorEspecialidad(id_especialidad);
            BindingList<Beca> ltsOrdenada = new BindingList<Beca>(lista.OrderBy(x => x.Nombre_beca).ToList());
            return ltsOrdenada;
        }





        //no entiendo porque hay otro listar?
        public BindingList<Beca> listarBecas() { return accesoDatos.listarBecas(); }

        public BindingList<Beca> listarBecaSolicitada(string name)
        {
            return accesoDatos.listarBecaSolicitada(name);
        }
    }
}
