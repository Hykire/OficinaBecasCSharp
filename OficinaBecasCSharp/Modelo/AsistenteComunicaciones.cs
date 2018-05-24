using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AsistenteComunicaciones:Persona
    {
        int idAsistente;

        public int IdAsistente { get => idAsistente; set => idAsistente = value; }

        public void PublicarAnuncio() { }
    }
}
