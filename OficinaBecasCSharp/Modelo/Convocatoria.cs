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
        private int cantidadPersonasPrevistas;
        private int cantidadPersonasConvocadas;
        private int cantidadRespuestas;
        private string cicloConvocatoria;
        private Beca becaAsociada;
        private AsistenteComunicaciones creadorConvocatoria;

        public int IdConvocatoria { get => idConvocatoria; set => idConvocatoria = value; }
        public string NombreConvocatoria { get => nombreConvocatoria; set => nombreConvocatoria = value; }
        public string DescripcionConvocatoria { get => descripcionConvocatoria; set => descripcionConvocatoria = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int CantidadPersonasPrevistas { get => cantidadPersonasPrevistas; set => cantidadPersonasPrevistas = value; }
        public int CantidadPersonasConvocadas { get => cantidadPersonasConvocadas; set => cantidadPersonasConvocadas = value; }
        public int CantidadRespuestas { get => cantidadRespuestas; set => cantidadRespuestas = value; }
        public string CicloConvocatoria { get => cicloConvocatoria; set => cicloConvocatoria = value; }
        public Beca BecaAsociada { get => becaAsociada; set => becaAsociada = value; }
        public AsistenteComunicaciones CreadorConvocatoria { get => creadorConvocatoria; set => creadorConvocatoria = value; }
        public string NombreBeca { get => becaAsociada.Nombre_beca; }
        public string NombreCreadorConvocatoria { get => creadorConvocatoria.Nombres + " " + creadorConvocatoria.Apellidos; }
    }
}
