using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Convocatoria
    {
        private int idConvocatoria;
        private string nombreConvocatoria;
        private string descripcionConvocatoria;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private DateTime fechaCreacion;
        private int cantidadCandidatosPrevistos;
        private int cantidadTotalCandidatos;
        private int cantidadPostulantes;
        private int cantidadSeleccionados;
        private string cicloConvocatoria;
        private Beca becaAsociada;
        private AsistenteComunicaciones creadorConvocatoria;

        public int IdConvocatoria { get => idConvocatoria; set => idConvocatoria = value; }
        public string NombreConvocatoria { get => nombreConvocatoria; set => nombreConvocatoria = value; }
        public string DescripcionConvocatoria { get => descripcionConvocatoria; set => descripcionConvocatoria = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string CicloConvocatoria { get => cicloConvocatoria; set => cicloConvocatoria = value; }
        public Beca BecaAsociada { get => becaAsociada; set => becaAsociada = value; }
        public AsistenteComunicaciones CreadorConvocatoria { get => creadorConvocatoria; set => creadorConvocatoria = value; }
        public string NombreBeca { get => becaAsociada.Nombre_beca; }
        public string NombreCreadorConvocatoria { get => creadorConvocatoria.Nombres + " " + creadorConvocatoria.Apellidos; }
        public int CantidadCandidatosPrevistos { get => cantidadCandidatosPrevistos; set => cantidadCandidatosPrevistos = value; }
        public int CantidadTotalCandidatos { get => cantidadTotalCandidatos; set => cantidadTotalCandidatos = value; }
        public int CantidadPostulantes { get => cantidadPostulantes; set => cantidadPostulantes = value; }
        public int CantidadSeleccionados { get => cantidadSeleccionados; set => cantidadSeleccionados = value; }
    }
}
