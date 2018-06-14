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
        public BindingList<Candidato> listarCandidatos(int idConvocatoria)
        {
            return candidatoDA.listarCandidatos(idConvocatoria);
        }

        public BindingList<Candidato> listarCandidatosAnteriores(int idConvocatoria)
        {
            return candidatoDA.listarCandidatosAnteriores(idConvocatoria);
        }

        public int insertarPersona(Persona persona)
        {
            return candidatoDA.insertarPersona(persona);
        }
        public int insertarCandidato(Candidato candidato, int idConvocatoria)
        {
            return candidatoDA.insertarCandidato(candidato, idConvocatoria);
        }

        public void insertarCandidatoAntiguo(Candidato candidato,int idConvocatoria)
        {
            candidatoDA.insertarCandidatoAntiguo(candidato,idConvocatoria);
        }

        public BindingList<Candidato> filtrarNombre(string nombres, string postulante, string seleccionado, int idConvocatoria)
        {
            return candidatoDA.filtrarNombre(nombres, postulante, seleccionado, idConvocatoria);
        }

        public BindingList<Candidato> filtrarApellidos(string apellidos, string postulante, string seleccionado, int idConvocatoria)
        {
            return candidatoDA.filtrarApellidos(apellidos, postulante, seleccionado, idConvocatoria);
        }

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, string postulante, string seleccionado, int idConvocatoria)
        {
            return candidatoDA.filtrarCodigoPUCP(codigoPUCP, postulante, seleccionado, idConvocatoria);
        }

        public BindingList<Candidato> filtrarDNI(int DNI, string postulante, string seleccionado, int idConvocatoria)
        {
            return candidatoDA.filtrarDNI(DNI, postulante, seleccionado, idConvocatoria);
        }

        public BindingList<Candidato> filtrarNombre(string nombres, int idConvocatoria)
        {
            return candidatoDA.filtrarNombre(nombres, idConvocatoria);
        }

        public BindingList<Candidato> filtrarApellidos(string apellidos, int idConvocatoria)
        {
            return candidatoDA.filtrarApellidos(apellidos, idConvocatoria);
        }

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, int idConvocatoria)
        {
            return candidatoDA.filtrarCodigoPUCP(codigoPUCP, idConvocatoria);
        }

        public BindingList<Candidato> filtrarDNI(int DNI, int idConvocatoria)
        {
            return candidatoDA.filtrarDNI(DNI, idConvocatoria);
        }

        public void actualizarCandidatoAntiguo(Candidato candidato, int idConvocatoria)
        {
            candidatoDA.actualizarCandidatoAntiguo(candidato, idConvocatoria);
        }

        public void actualizarCandidatoActual(Candidato candidato, int idConvocatoria)
        {
            candidatoDA.actualizarCandidatoActual(candidato, idConvocatoria);
        }

        public void actualizarContadores(Convocatoria convocatoria)
        {
            candidatoDA.actualizarContadores(convocatoria);
        }
    }
}
