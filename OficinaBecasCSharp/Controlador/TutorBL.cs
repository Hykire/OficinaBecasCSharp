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
    public class TutorBL
    {
        private TutorAD accesoDatosTutor;
        
        public TutorBL()
        {
            accesoDatosTutor = new TutorAD();
        }

        public BindingList<Tutor> listarTutorDeBecado(int idBec)
        {
            return accesoDatosTutor.listarTutorDeBecado(idBec);
        }
        public BindingList<Tutor> traerTutores()
        {
            return accesoDatosTutor.traerTutores();
        }
        public void eliminarTutor(int idPer)
        {
            accesoDatosTutor.eliminarTutor(idPer);
        }
        public BindingList<Tutor> traerTutoresCod(string codTut)
        {
            return accesoDatosTutor.traerTutoresCod(codTut);
        }
        public void insertarNuevoTutor(String idPer, String idcoord, string est) {
            accesoDatosTutor.insertarNuevoTutor(idPer, idcoord, est);
        }
        public BindingList<Tutor> listarTutores() {
            return accesoDatosTutor.listarTutores();
        }
        public Tutor buscarTutor(String cod)
        {
            return accesoDatosTutor.buscarTutor(cod);
        }
    }
}
