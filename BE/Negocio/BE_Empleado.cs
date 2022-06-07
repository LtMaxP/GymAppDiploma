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
        private int _id_genero;

        public int Id_genero
        {
            get { return _id_genero; }
            set { _id_genero = value; }
        }


        //private string _sucursal;

        //public string Sucursal
        //{
        //    get { return _sucursal; }
        //    set { _sucursal = value; }
        //}

        private int _id_trabajo;

        public int Id_Trabajo
        {
            get { return _id_trabajo; }
            set { _id_trabajo = value; }
        }



    }
}
