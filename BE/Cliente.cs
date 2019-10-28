using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        private int id_Cliente;

        public int _IDCliente
        {
            get { return id_Cliente; }
            set { id_Cliente = value; }
        }

        private int id_Sucursal;

        public int _IDSucursal
        {
            get { return id_Sucursal; }
            set { id_Sucursal = value; }
        }

        private int id_Empleado;

        public int _IDEmpleado
        {
            get { return id_Empleado; }
            set { id_Empleado = value; }
        }

        private string nombre;

        public string _nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string _apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private float pesokg;

        public float _pesokg
        {
            get { return pesokg; }
            set { pesokg = value; }
        }

        private int id_Estado;

        public int _idEstado
        {
            get { return id_Estado; }
            set { id_Estado = value; }
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





    }
}
