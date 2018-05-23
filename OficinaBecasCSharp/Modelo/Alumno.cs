using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Alumno:Persona
    {
        private string _ciclo_ingreso;
        private Especialidad _especialidad;
        private string _tipo_grupo;
        
        private string _distrito_nacimiento;
        private string _provincia_nacimiento;
        private string _departamento_nacimiento;
        private string _pais_nacimiento;

        private string _direccion;
        private string _distrito_actual;
        private string _provincia_actual;
        private string _departamento_actual;

        //private BindingList<HistoriaAcademica> _historia_academica;

        public string Ciclo_ingreso { get => _ciclo_ingreso; set => _ciclo_ingreso = value; }
        public Especialidad Especialidad { get => _especialidad; set => _especialidad = value; }
        public string Tipo_grupo { get => _tipo_grupo; set => _tipo_grupo = value; }

        public string Distrito_nacimiento { get => _distrito_nacimiento; set => _distrito_nacimiento = value; }
        public string Provincia_nacimiento { get => _provincia_nacimiento; set => _provincia_nacimiento = value; }
        public string Departamento_nacimiento { get => _departamento_nacimiento; set => _departamento_nacimiento = value; }
        public string Pais_nacimiento { get => _pais_nacimiento; set => _pais_nacimiento = value; }

        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Distrito_actual { get => _distrito_actual; set => _distrito_actual = value; }
        public string Provincia_actual { get => _provincia_actual; set => _provincia_actual = value; }
        public string Departamento_actual { get => _departamento_actual; set => _departamento_actual = value; }

    }
}
