using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bitacora
    {
        private int id_Bitacora;

        public int IdBitacora
        {
            get { return id_Bitacora; }
            set { id_Bitacora = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string movimiento;

        public string Movimiento
        {
            get { return movimiento; }
            set { movimiento = value; }
        }

        private string _nivelDeProblema;

        public string NivelDeProblema
        {
            get { return _nivelDeProblema; }
            set { _nivelDeProblema = value; }
        }



    }
}
