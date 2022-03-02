using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Localidad
    {
        private int _id_Localidad;

        public int Id_Localidad
        {
            get { return _id_Localidad; }
            set { _id_Localidad = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private List<BE_Sucursal> _sucursal;

        public List<BE_Sucursal> Sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }
    }
}
