using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cita
    {
        private int idCita;
        private string fecha;
       // private string hora;
        private string observacion;
        private string lugar;

        public Cita()
        {

        }

        public int IdCita { get => idCita; set => idCita = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Lugar { get => lugar; set => lugar = value; }
       // public string Hora { get => hora; set => hora = value; }
    }
}
