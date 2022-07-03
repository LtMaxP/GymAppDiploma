using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Persona
    {

        private float pesokg;
        public float _pesokg
        {
            get { return pesokg; }
            set { pesokg = value; }
        }


        private int dni;
        public int _dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string calle;
        public string _calle
        {
            get { return calle; }
            set { calle = value; }
        }

        private int numero;
        public int _numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int codPostal;
        public int _codPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }

        private int telefono;
        public int _telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private DateTime fechaNacimiento;
        public DateTime _fechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private Negocio.BE_Rutina _membresia;

        public Negocio.BE_Rutina Membresia
        {
            get { return _membresia; }
            set { _membresia = value; }
        }


        private Negocio.BE_Rutina _rutina;
        public Negocio.BE_Rutina Rutina
        {
            get { return _rutina; }
            set { _rutina = value; }
        }

        private List<Negocio.BE_Clase> _clases;

        public List<Negocio.BE_Clase> Clases
        {
            get { return _clases; }
            set { _clases = value; }
        }

    }
}
