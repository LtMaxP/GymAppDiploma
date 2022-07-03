using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Negocio
{
    public class Trabajo
    {
        private int _idTrabajo;

        public int IdTrabajo
        {
            get { return _idTrabajo; }
            set { _idTrabajo = value; }
        }
        private String _descripcion;

        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


    }
}
