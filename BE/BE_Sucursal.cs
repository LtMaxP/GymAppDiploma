using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Sucursal
    {
        private int _id_Sucursal;

        public int Id_Sucursal
        {
            get { return _id_Sucursal; }
            set { _id_Sucursal = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
