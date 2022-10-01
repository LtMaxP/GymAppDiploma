using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Persona
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

        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private int _id_estado;

        public int Id_Estado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }
        private int _id_genero;

        public int Id_Genero
        {
            get { return _id_genero; }
            set { _id_genero = value; }
        }

    }
}
