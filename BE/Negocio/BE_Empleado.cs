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
    }
}
