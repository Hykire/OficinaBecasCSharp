using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CitaBL
    {
        private CitaAD accesoDatosCita;
        public CitaBL()
        {
            accesoDatosCita = new CitaAD();
        }
        public bool agregarCita(Cita cita, int idBec, int idTut)
        {
            return accesoDatosCita.agregarCita(cita, idBec, idTut);
        }
        public BindingList<Cita> buscarcita(DateTime fecha)
        {
            return accesoDatosCita.buscarcita(fecha);
        }
        public BindingList<Cita> buscarcitaPorTutor(string idtutor)
        {
            return accesoDatosCita.buscarcitaPorTutor(idtutor);
        }
    }
}
