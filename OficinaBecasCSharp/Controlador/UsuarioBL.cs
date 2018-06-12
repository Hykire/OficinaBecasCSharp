using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Controlador {
    public class UsuarioBL {
        UsuarioDA usuarioDA;

        public UsuarioBL() {
            usuarioDA = new UsuarioDA();
        }

        public bool validarUsuario(string nombreUsuario, string contraUsuario) {
            return usuarioDA.validarUsuario(nombreUsuario, contraUsuario);
        }
        public Usuario obtenerUsuario(int id_u)
        {
            return usuarioDA.obtener_usuario(id_u);

        }
        public int insertarUsuario(Usuario u)
        {
            return usuarioDA.insertar_usuario(u);
        }
    }
}
