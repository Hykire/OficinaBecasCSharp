using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int _id_usuario;
        private int _id_tipo_usuario;
        private string _user;
        private string _password;

        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public int Id_tipo_usuario { get => _id_tipo_usuario; set => _id_tipo_usuario = value; }
        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
