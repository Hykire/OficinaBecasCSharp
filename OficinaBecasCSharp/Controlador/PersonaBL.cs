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

        
        
        public void enlazarBecario(Tutor pe,int idbec,string ciclo)
        {
            accesoDatosPersona.enlazarBecario(pe, idbec,ciclo);
        }

        public void enlazarBecario2(Alumno pe, string idAlum)
        {
            accesoDatosPersona.enlazarBecario2(pe, idAlum);
        }

        

        public BindingList<Persona> listarPersonas(String cod)
        {
            return accesoDatosPersona.listarPersonas(cod);
        }


        public void insertarNuevoTutor(String idPer, String idcoord, string est)
        {
            accesoDatosPersona.insertarNuevoTutor(idPer, idcoord, est);
        }

    }
}
