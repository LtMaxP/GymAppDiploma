using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Persona
    {

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

        private BE.Negocio.BE_Membresia _Membresia;
        public BE.Negocio.BE_Membresia Membresia
        {
            get { if (_Membresia == null)
                {
                    _Membresia = new Negocio.BE_Membresia();
                }
                    return _Membresia; }
            set { _Membresia = value; }
        }

        private bool _certificado;
        public bool Certificado
        {
            get { return _certificado; }
            set { _certificado = value; }
        }

        private int _descuento;
        public int Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        private float _altura;
        public float Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
    }
}
