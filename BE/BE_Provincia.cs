using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Provincia
    {
        private int _id_Provincia;

        public int Id_Provincia
        {
            get { return _id_Provincia; }
            set { _id_Provincia = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private List<BE_Localidad> _localidad;

        public List<BE_Localidad> Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }


    }
}
