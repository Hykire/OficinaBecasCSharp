﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Becado : Persona
    {
        private int _id_becado;
        private int _especialidad;
        private int _facultad;
        private string _ciclo_ingreso;
        private string _tipo_grupo;

        private string _distrito_nacimiento;
        private string _provincia_nacimiento;
        private string _departamento_nacimiento;
        private string _pais_nacimiento;

        private string _direccion;
        private string _distrito_actual;
        private string _provincia_actual;
        private string _departamento_actual;
        private string nombreEspecialidad;
        private int _id_tutor;
        //private BindingList<HistoriaAcademica> _historia_academica;
        public Becado() {
            nombreEspecialidad = "";
        }

        public int Id_becado { get => _id_becado; set => _id_becado = value; }
        public string Ciclo_ingreso { get => _ciclo_ingreso; set => _ciclo_ingreso = value; }
        public int Facultad { get => _facultad; set => _facultad = value; }
        public int Especialidad { get => _especialidad; set => _especialidad = value; }
        public string Tipo_grupo { get => _tipo_grupo; set => _tipo_grupo = value; }

        public string Distrito_nacimiento { get => _distrito_nacimiento; set => _distrito_nacimiento = value; }
        public string Provincia_nacimiento { get => _provincia_nacimiento; set => _provincia_nacimiento = value; }
        public string Departamento_nacimiento { get => _departamento_nacimiento; set => _departamento_nacimiento = value; }
        public string Pais_nacimiento { get => _pais_nacimiento; set => _pais_nacimiento = value; }

        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Distrito_actual { get => _distrito_actual; set => _distrito_actual = value; }
        public string Provincia_actual { get => _provincia_actual; set => _provincia_actual = value; }
        public string Departamento_actual { get => _departamento_actual; set => _departamento_actual = value; }
        public int Id_tutor { get => _id_tutor; set => _id_tutor = value; }
        public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }
    }
}