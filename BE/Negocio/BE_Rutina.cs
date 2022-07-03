using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Negocio
{
    public class BE_Rutina
    {
        private int _idRutina;

        public int IdRutina
        {
            get { return _idRutina; }
            set { _idRutina = value; }
        }

        private List<BE_Ejercicio> _ejercicios;
        public List<BE_Ejercicio> Ejercicios
        {
            get { return _ejercicios; }
            set { _ejercicios = value; }
        }

        private String _descripcion;
        public String Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private Profesor _profesor;
        public Profesor Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }

    }
}
