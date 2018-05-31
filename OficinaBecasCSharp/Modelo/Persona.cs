using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Persona
    {
        private int _id_persona;
        private int _codigoPUCP;
        private string _nombres;
        private string _apellidos;
        private char _sexo;
        private int _dni;
        private int _edad;
        private DateTime _fecha_nacimiento;
        private string _correoPUCP;
        private string _correoAlternativo;
        private string _telfMovil;
        private string _telfFijo;
        private string _estado;

        private string _profesion; //lo uso en gestionar profes

        //private TipoUsuario tipoUsuario;
        //private Usuario usuarioP;

        public Persona() { }

        public int Id_persona { get => _id_persona; set => _id_persona = value; }
        public int CodigoPUCP { get => _codigoPUCP; set => _codigoPUCP = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public char Sexo { get => _sexo; set => _sexo = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public string CorreoPUCP { get => _correoPUCP; set => _correoPUCP = value; }
        public string CorreoAlternativo { get => _correoAlternativo; set => _correoAlternativo = value; }
        public string TelfMovil { get => _telfMovil; set => _telfMovil = value; }
        public string TelfFijo { get => _telfFijo; set => _telfFijo = value; }
        public string Profesion { get => _profesion; set => _profesion = value; }//lo uso en gestionar profes
        public string Estado { get => _estado; set => _estado = value; }
    }
}
