using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Genero
    {
        private int _id_Genero;

        public int Id_Genero
        {
            get { return _id_Genero; }
            set { _id_Genero = value; }
        }

        private string _genero;

        public string _Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

    }
}
