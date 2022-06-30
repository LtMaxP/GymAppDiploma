using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BE_Empleado
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private int _genero;

        public int Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }


        private string _trabajo;

        public string Trabajo
        {
            get { return _trabajo; }
            set { _trabajo = value; }
        }

        private Decimal _sueldo;

        public Decimal Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }


    }
}
