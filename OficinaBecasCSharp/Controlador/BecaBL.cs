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
        public BecaBL()
        {
            accesoDatos = new BecaDA();
        }
        public BindingList<Beca> listarBeca()
        {
            BindingList<Beca> lista = accesoDatos.lstEspecialidad();
            BindingList<Beca> ltsOrdenada = new BindingList<Beca>(lista.OrderBy(x => x.Nombre_beca).ToList());
            return ltsOrdenada;
        }

        public BindingList<Beca> listarBecas()
        {
            return accesoDatos.listarBecas();
        }
        public BindingList<Beca> listarBecaSolicitada(string name)
        {
            return accesoDatos.listarBecaSolicitada(name);
        }
    }
}
