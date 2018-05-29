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
    public class CoordinadorBL
    {
        private CoordinadorAD accesoDatosCoord;
        public CoordinadorBL()
        {
            accesoDatosCoord = new CoordinadorAD();
        }
        public BindingList<CoordinadorTutoria> traerCoordinadores()
        {
            return accesoDatosCoord.traerCoordinadores();
        }
    }
}
