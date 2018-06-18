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
        
        public string obtenerNombreUsuario(int idUsuario) {
            return usuarioDA.obtenerNombreUsuario(idUsuario);
        }

        public void cambiarContrasena(int idUsuario, string nuevaContra) {
            usuarioDA.cambiarContrasena(idUsuario, nuevaContra);
        }

        public bool contrasenaCoincide(int idUsuario, string contraIngresada) {
            return usuarioDA.contrasenaCoincide(idUsuario, contraIngresada);
        }

        public int obtenerIdUsuario(string nombre) {
            return usuarioDA.obtenerIdUsuario(nombre);
        }

        public int obtenerTipoUsuario(int idUsuario) {
            return usuarioDA.obtenerTipoUsuario(idUsuario);
        }
    }
}
