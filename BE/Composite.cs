using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class Composite
    {
        public string UsuarioID { get; set; }
        public string idComponente { get; set; }
        public string descripcion { get; set; }
        public string idComponentoHijo { get; set; }

        public string tipo { get; set; }

        public Composite()
        { }

        public Composite(string UsuarioID, string idComponente, string descripcion, string idComponentoHijo, string tipo)
        {
            this.UsuarioID = UsuarioID;
            this.idComponente = idComponente;
            this.descripcion = descripcion;
            this.idComponentoHijo = idComponentoHijo;
            this.tipo = tipo;
        }
    }
}

