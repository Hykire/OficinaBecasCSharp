using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class HistoriaAcademica
    {
        private int _id_historia_academica;
        private int _id_becado;
        private string _ciclo;
        private int _id_especialidad_actual;
        private int _id_facultad_actual;
        private string _ultimo_ciclom;
        private double _craest;
        private double _orden;
        private int _ncm;
        private string _etapa;
        private double _crpe;
        private int _ncur_msr;
        private int _ncur_r;
        private double _ncre_msr;
        private double _ncre_mr;
        private double _ncre_1;
        private double _ncre_2;
        private double _ncre_3;
        private double _ncre_4;
        private double _cahn;
        private double _tcac;
        private double _cdh;
        private double _cur;
        private double _cac;
        private double _cr;
        private double _cah_exi;
        private double _cah_exo;
        private double _cah_con;
        private double _ncre_rh;

        public override string ToString() { return _ciclo; }

        public int Id_historia_academica { get => _id_historia_academica; set => _id_historia_academica = value; }
        public int Id_becado { get => _id_becado; set => _id_becado = value; }
        public string Ciclo { get => _ciclo; set => _ciclo = value; }
        public int Id_especialidad_actual { get => _id_especialidad_actual; set => _id_especialidad_actual = value; }
        public int Id_facultad_actual { get => _id_facultad_actual; set => _id_facultad_actual = value; }
        public string Ultimo_ciclom { get => _ultimo_ciclom; set => _ultimo_ciclom = value; }
        public double Craest { get => _craest; set => _craest = value; }
        public double Orden { get => _orden; set => _orden = value; }
        public int Ncm { get => _ncm; set => _ncm = value; }
        public string Etapa { get => _etapa; set => _etapa = value; }
        public double Crpe { get => _crpe; set => _crpe = value; }
        public int Ncur_msr { get => _ncur_msr; set => _ncur_msr = value; }
        public int Ncur_r { get => _ncur_r; set => _ncur_r = value; }
        public double Ncre_msr { get => _ncre_msr; set => _ncre_msr = value; }
        public double Ncre_mr { get => _ncre_mr; set => _ncre_mr = value; }
        public double Ncre_1 { get => _ncre_1; set => _ncre_1 = value; }
        public double Ncre_2 { get => _ncre_2; set => _ncre_2 = value; }
        public double Ncre_3 { get => _ncre_3; set => _ncre_3 = value; }
        public double Ncre_4 { get => _ncre_4; set => _ncre_4 = value; }
        public double Cahn { get => _cahn; set => _cahn = value; }
        public double Tcac { get => _tcac; set => _tcac = value; }
        public double Cdh { get => _cdh; set => _cdh = value; }
        public double Cur { get => _cur; set => _cur = value; }
        public double Cac { get => _cac; set => _cac = value; }
        public double Cr { get => _cr; set => _cr = value; }
        public double Cah_exi { get => _cah_exi; set => _cah_exi = value; }
        public double Cah_exo { get => _cah_exo; set => _cah_exo = value; }
        public double Cah_con { get => _cah_con; set => _cah_con = value; }
        public double Ncre_rh { get => _ncre_rh; set => _ncre_rh = value; }
    }
}
