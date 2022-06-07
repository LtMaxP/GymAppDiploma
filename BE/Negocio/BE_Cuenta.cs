using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Cuenta
    {
        private int _id_Cuenta;

        public int Id_Cuenta
        {
            get { return _id_Cuenta; }
            set { _id_Cuenta = value; }
        }

        private double _monto;

        public double Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private DateTime _fechaInicio;

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

    }
}
