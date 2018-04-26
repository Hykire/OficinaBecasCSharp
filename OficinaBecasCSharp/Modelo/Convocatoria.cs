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
        private int numeroRespuestas;
        private int numeroTotalEnviados;
        private DateTime fechaConvocatoria;
        private string nombreConvocatoria;
        private string descripcionConvocatoria;
        private Beca beca;
        private AsistenteComunicaciones asistenteComunicaciones;

        public int IdConvocatoria { get => idConvocatoria; set => idConvocatoria = value; }
        public int NumeroRespuestas { get => numeroRespuestas; set => numeroRespuestas = value; }
        public int NumeroTotalEnviados { get => numeroTotalEnviados; set => numeroTotalEnviados = value; }
        public DateTime FechaConvocatoria { get => fechaConvocatoria; set => fechaConvocatoria = value; }
        public string NombreConvocatoria { get => nombreConvocatoria; set => nombreConvocatoria = value; }
        public string DescripcionConvocatoria { get => descripcionConvocatoria; set => descripcionConvocatoria = value; }
        public Beca Beca { get => beca; set => beca = value; }
        internal AsistenteComunicaciones AsistenteComunicaciones { get => asistenteComunicaciones; set => asistenteComunicaciones = value; }
    }
}
