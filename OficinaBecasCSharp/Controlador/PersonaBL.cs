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

    public class PersonaBL
    {
        private PersonaAD accesoDatosPersona;
        public PersonaBL()
        {
            accesoDatosPersona = new PersonaAD();
        }

        public BindingList<Persona> listarTutores()
        {
            return accesoDatosPersona.listarTutores();
        }

        public BindingList<Persona> listarBecadosXTutor(String idTut)
        {
            return accesoDatosPersona.listarBecadosXTutor(idTut);
        }

        public BindingList<Persona> listarBecarios(String cod)
        {
            return accesoDatosPersona.listarBecarios(cod);
        }
        public BindingList<Persona> traerTutores()
        {
            return accesoDatosPersona.traerTutores();
        }

        public void enlazarBecario(Alumno pe)
        {
            accesoDatosPersona.enlazarBecario(pe);
        }

        public BindingList<Persona> listarTutorDeBecado(int idBec)
        {
            return accesoDatosPersona.listarTutorDeBecado(idBec);
        }

        public BindingList<Persona> listarPersonas(String cod)
        {
            return accesoDatosPersona.listarPersonas(cod);
        }
        public BindingList<Persona> traerCoordinadores()
        {
            return accesoDatosPersona.traerCoordinadores();
        }

        public void insertarNuevoTutor(String idPer, String idcoord, char est)
        {
            accesoDatosPersona.insertarNuevoTutor(idPer, idcoord, est);
        }

    }
}
