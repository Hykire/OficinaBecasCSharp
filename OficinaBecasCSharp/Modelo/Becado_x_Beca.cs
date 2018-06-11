using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Becado_x_Beca
    {
        private int _id_becado_x_beca;
        private int _id_becado;
        private int _id_beca;
        private string _ciclo;
        private string _tipo_escala_pago;
        private int _escala_pago;
        private int _nivel_creditos;
        private double _ncreditos_cubiertos;
        private double _ncreditos_utilizados;
        private double _ncreditos_restantes;
        private int _nsemestres_regular;
        private int _nsemestres_verano;
        private int _nsemestres_restantes;
        private int _renovacion;
        private int _suspencion;
        private int _ampliacion;
        private string _ciclo_solicitado;
        private string _respuesta;
        private string _ncarta;
        private int _redencion_materiales;
        private int _redencion_alojamiento;
        private int _sansion;
        private string _sansion_tipo;
        private DateTime _sansion_ini;
        private DateTime _sansion_fin;
        private int _intercambio;
        private string _intercambio_tipo;
        private DateTime _intercambio_ini;
        private DateTime _intercambio_fin;
        private int _adelanto;

        public override string ToString() { return _ciclo; }

        public int Id_becado_x_beca { get => _id_becado_x_beca; set => _id_becado_x_beca = value; }
        public int Id_beca { get => _id_beca; set => _id_beca = value; }
        public string Ciclo { get => _ciclo; set => _ciclo = value; }
        public int Escala_pago { get => _escala_pago; set => _escala_pago = value; }
        public int Nivel_creditos { get => _nivel_creditos; set => _nivel_creditos = value; }
        public double Ncreditos_cubiertos { get => _ncreditos_cubiertos; set => _ncreditos_cubiertos = value; }
        public double Ncreditos_utilizados { get => _ncreditos_utilizados; set => _ncreditos_utilizados = value; }
        public double Ncreditos_restantes { get => _ncreditos_restantes; set => _ncreditos_restantes = value; }
        public int Nsemestres_regular { get => _nsemestres_regular; set => _nsemestres_regular = value; }
        public int Nsemestres_verano { get => _nsemestres_verano; set => _nsemestres_verano = value; }
        public int Nsemestres_restantes { get => _nsemestres_restantes; set => _nsemestres_restantes = value; }
        public int Renovacion { get => _renovacion; set => _renovacion = value; }
        public int Suspencion { get => _suspencion; set => _suspencion = value; }
        public int Ampliacion { get => _ampliacion; set => _ampliacion = value; }
        public string Ciclo_solicitado { get => _ciclo_solicitado; set => _ciclo_solicitado = value; }
        public string Respuesta { get => _respuesta; set => _respuesta = value; }
        public string Ncarta { get => _ncarta; set => _ncarta = value; }
        public int Redencion_materiales { get => _redencion_materiales; set => _redencion_materiales = value; }
        public int Redencion_alojamiento { get => _redencion_alojamiento; set => _redencion_alojamiento = value; }
        public int Sansion { get => _sansion; set => _sansion = value; }
        public string Sansion_tipo { get => _sansion_tipo; set => _sansion_tipo = value; }
        public DateTime Sansion_ini { get => _sansion_ini; set => _sansion_ini = value; }
        public DateTime Sansion_fin { get => _sansion_fin; set => _sansion_fin = value; }
        public int Intercambio { get => _intercambio; set => _intercambio = value; }
        public string Intercambio_tipo { get => _intercambio_tipo; set => _intercambio_tipo = value; }
        public DateTime Intercambio_ini { get => _intercambio_ini; set => _intercambio_ini = value; }
        public DateTime Intercambio_fin { get => _intercambio_fin; set => _intercambio_fin = value; }
        public int Adelanto { get => _adelanto; set => _adelanto = value; }
        public int Id_becado { get => _id_becado; set => _id_becado = value; }
        public string Tipo_escala_pago { get => _tipo_escala_pago; set => _tipo_escala_pago = value; }
    }
}
