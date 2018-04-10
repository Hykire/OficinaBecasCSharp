using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Usuario
    {
        private string usuario;
        private string pasword;

        public Usuario()
        {

        }

        public string _usuario
        {
            set
            {
                usuario = value;
            }
            get
            {
                return usuario;
            }
        }

        public string _pasword
        {
            set
            {
                pasword = value;
            }
            get
            {
                return pasword;
            }
        }


    }
}
