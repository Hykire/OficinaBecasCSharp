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
        private string password;

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

        public string _password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }


    }
}
