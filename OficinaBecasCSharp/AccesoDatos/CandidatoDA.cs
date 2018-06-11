using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CandidatoDA
    {
        public BindingList<Candidato> listarCandidatos()
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public int insertarPersona(Persona persona)
        {
            int idPersona = 0;
            return idPersona;
        }
        public int insertarCandidato(Candidato candidato, int idConvocatoria)
        {
            int idCandidato = 0;
            return idCandidato;
        }

        public BindingList<Candidato> filtrarNombre(string nombres, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public BindingList<Candidato> filtrarApellidos(string apellidos, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public BindingList<Candidato> filtrarCodigoPUCP(int codigoPUCP, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public BindingList<Candidato> filtrarDNI(int DNI, string postulante, string seleccionado)
        {
            BindingList<Candidato> candidatos = new BindingList<Candidato>();
            return candidatos;
        }

        public void actualizarCandidato(Candidato candidato)
        {

        }

        public void actualizarContadores(Convocatoria convocatoria)
        {
            
        }
    }
}
