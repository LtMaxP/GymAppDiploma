using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Ejercicio
    {
        private int _id_Ejercicio;

        public int Id_Ejercicio
        {
            get { return _id_Ejercicio; }
            set { _id_Ejercicio = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private string _ejercicio;

        public string Ejercicio
        {
            get { return _ejercicio; }
            set { _ejercicio = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

    }
}
