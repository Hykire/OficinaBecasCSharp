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
    public class CandidatoBL
    {
        private CandidatoDA candidatoDA;
        public CandidatoBL()
        {
            candidatoDA = new CandidatoDA();
        }
        public BindingList<Candidato> listarCandidatos(int idCandidato)
        {
            return candidatoDA.listarCandidatos(idCandidato);
        }

        public int insertarPersona(Persona persona)
        {
            return candidatoDA.insertarPersona(persona);
        }
        public int insertarCandidato(Candidato candidato, int idConvocatoria)
        {
            return candidatoDA.insertarCandidato(candidato, idConvocatoria);
        }

        public BindingList<Candidato> filtrarNombre(string nombres, string postulante, string seleccionado)
        {
            return candidatoDA.filtrarNombre(nombres, postulante, seleccionado);
        }

        public BindingList<Candidato> filtrarApellidos(string apellidos, string postulante, string seleccionado)
        {
            return candidatoDA.filtrarApellidos(apellidos, postulante, seleccionado);
        }

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, string postulante, string seleccionado)
        {
            return candidatoDA.filtrarCodigoPUCP(codigoPUCP, postulante, seleccionado);
        }

        public BindingList<Candidato> filtrarDNI(int DNI, string postulante, string seleccionado)
        {
            return candidatoDA.filtrarDNI(DNI, postulante, seleccionado);
        }

        public void actualizarCandidato(Candidato candidato)
        {
            candidatoDA.actualizarCandidato(candidato);
        }

        public void actualizarContadores(Convocatoria convocatoria)
        {
            candidatoDA.actualizarContadores(convocatoria);
        }
    }
}
