using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Profesor : BE_Empleado
    {

        private List<Cliente> _personasACargo;

        public List<Cliente> PersonasACargo
        {
            get { return _personasACargo; }
            set { _personasACargo = value; }
        }
    }
}
