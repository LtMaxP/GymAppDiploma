using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Persona
    {

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

        private float pesokg;
        public float _pesokg
        {
            get { return pesokg; }
            set { pesokg = value; }
        }

        private int _membresia;
        public int Membresia
        {
            get { return _membresia; }
            set { _membresia = value; }
        }

        private int _idEstado;

        public int IdEstado
        {
            get { return _idEstado; }
            set { _idEstado = value; }
        }

        private bool _certificado;

        public bool Certificado
        {
            get { return _certificado; }
            set { _certificado = value; }
        }

        private decimal _descuento;

        public decimal Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
        private decimal _altura;

        public decimal Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }




    }
}
