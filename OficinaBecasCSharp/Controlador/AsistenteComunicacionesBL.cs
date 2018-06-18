using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class AsistenteComunicacionesBL
    {
        private AsistenteComunicacionesDA asistenteComunicacionesDA;

        public AsistenteComunicacionesBL()
        {
            asistenteComunicacionesDA = new AsistenteComunicacionesDA();
        }

        public AsistenteComunicaciones buscarAsistente(int idUsuario)
        {
            return asistenteComunicacionesDA.buscarAsistente(idUsuario);
        }
    }
}
