using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Persona
    {
        private int idPersona;
        private string nombre;
        private string apellidos;
        private string direccion;
        private int dni;
        private int codigoPUCP;
        private string correo;
        private string profesion;
        private string especialidad;
        private long telfMovil;
        private long telfCasa;
        private TipoUsuario tipoUsuario;
        private Usuario usuarioP;

        public Persona()
        {

        }

        public int _idPersona
        {
            set
            {
                idPersona = value;
            }
            get
            {
                return idPersona;
            }
        }

        public string _nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string _apellidos
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }
        }

        public string _direccion
        {
            set
            {
                direccion = value;
            }
            get
            {
                return direccion;
            }
        }

        public int _dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public int _codigoPUCP
        {
            set
            {
                codigoPUCP = value;
            }
            get
            {
                return codigoPUCP;
            }
        }

        public string _correo
        {
            set
            {
                correo = value;
            }
            get
            {
                return correo;
            }
        }

        public string _profesion
        {
            set
            {
                profesion = value;
            }
            get
            {
                return profesion;
            }
        }

        public string _especialidad
        {
            set
            {
                especialidad = value;
            }
            get
            {
                return especialidad;
            }
        }

        public long _telfMovil
        {
            set
            {
                telfMovil = value;
            }
            get
            {
                return telfMovil;
            }
        }

        public long _telfCasa
        {
            set
            {
                telfCasa = value;
            }
            get
            {
                return telfCasa;
            }
        }

        public TipoUsuario _tipoUsuario
        {
            set
            {
                tipoUsuario = value;
            }
            get
            {
                return tipoUsuario;
            }
        }

        public Usuario _usuarioP
        {
            set
            {
                usuarioP = value;
            }
            get
            {
                return usuarioP;
            }
        }


    }
}
