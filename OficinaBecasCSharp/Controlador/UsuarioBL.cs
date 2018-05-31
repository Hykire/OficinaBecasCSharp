using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Controlador {
    public class UsuarioBL {
        UsuarioDA usuarioDA;

        public UsuarioBL() {
            usuarioDA = new UsuarioDA();
        }

        public bool validarUsuario(string nombreUsuario, string contraUsuario) {
            return usuarioDA.validarUsuario(nombreUsuario, contraUsuario);
        }
    }
}
