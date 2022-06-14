using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bitacora
    {
        public Bitacora(string movimiento, string nivelDeProblema)
        {
            this.movimiento = movimiento;
            this._nivelDeProblema = nivelDeProblema;
        }
        public Bitacora()
        {
        }
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

        private string _usuario;

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }


    }
}
