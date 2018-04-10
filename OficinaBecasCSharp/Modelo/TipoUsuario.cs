using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class TipoUsuario
    {
        private int idUsuario;
        private string descripUsuario;
        private string nombreTipoUs;

        public TipoUsuario()
        {

        }

        public int _idUsuario
        {
            set
            {
                idUsuario = value;
            }
            get
            {
                return idUsuario;
            }
        }

        public string _descripUsuario
        {
            set
            {
                descripUsuario = value;
            }
            get
            {
                return descripUsuario;
            }
        }

        public string _nombreTipoUs
        {
            set
            {
                nombreTipoUs = value;
            }
            get
            {
                return nombreTipoUs;
            }
        }


    }
}
