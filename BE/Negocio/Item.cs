using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Item
    {
        public Item(string desc, decimal val, int cant)
        {
            this.Descripcion = desc;
            this.Valor = val;
            this.Cantidad = cant;
        }
        public Item()
        { }
        
        private int _id_Item;

        public int Id_Item
        {
            get { return _id_Item; }
            set { _id_Item = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private Decimal _valor;

        public Decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

    }
}
