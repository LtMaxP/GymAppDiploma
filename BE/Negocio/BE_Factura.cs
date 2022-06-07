using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Factura
    {
        private int _id_Factura;

        public int Id_Factura
        {
            get { return _id_Factura; }
            set { _id_Factura = value; }
        }

        private decimal _monto;

        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

    }
}
