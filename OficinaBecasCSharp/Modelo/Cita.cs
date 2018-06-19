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
        private DateTime fecha;
       // private string hora;
        private string observacion;
        private string lugar;
        private int idBecado;
        private int idTutor;
        private string hora;

        public Cita() { }
        public int IdCita { get => idCita; set => idCita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public int IdBecado { get => idBecado; set => idBecado = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public string Hora { get => hora; set => hora = value; }
        // public string Hora { get => hora; set => hora = value; }
    }
}
