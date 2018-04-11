using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Cita
    {
        private int idCita;
        private DateTime fecha;
        private string descripcion;
        private string lugar;

        public Cita()
        {

        }

        public int IdCita { get => idCita; set => idCita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Lugar { get => lugar; set => lugar = value; }
    }
}
