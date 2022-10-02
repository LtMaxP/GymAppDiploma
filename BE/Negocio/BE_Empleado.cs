using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Empleado : Persona
    {

        private string _trabajo;

        public string Trabajo
        {
            get { return _trabajo; }
            set { _trabajo = value; }
        }

        private BE.BE_Cuenta _cuenta;

        public BE.BE_Cuenta Cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }


    }
}
