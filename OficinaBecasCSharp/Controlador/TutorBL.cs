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
    }
}
