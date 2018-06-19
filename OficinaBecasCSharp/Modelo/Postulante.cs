using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Postulante
    {
        private float promedio;
        private float craest;
        private int ciclo;
        private float porcentajeMerito;
        private int escala;

        public Postulante() { }

        public float Promedio { get => promedio; set => promedio = value; }

        public float Craest { get => craest; set => craest = value; }

        public int Ciclo { get => ciclo; set => ciclo = value; }

        public float PorcentajeMerito { get => porcentajeMerito; set => porcentajeMerito = value; }
        public int Escala { get => escala; set => escala = value; }
    }
}
