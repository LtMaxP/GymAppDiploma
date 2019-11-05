using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Composite
    {
        public string UsuarioCodigo { get; set; }
        public string PermisoCodigo { get; set; }
        public string IdComponente { get; set; }
        public string Descripcion { get; set; }
        public string IdComponenteHijo { get; set; }

        public Composite()
        { }

        public Composite(string UsuarioCodigo, string PermisoCodigo, string IdComponente, string Descripcion, string IdComponenteHijo)
        {
            this.UsuarioCodigo = UsuarioCodigo;
            this.PermisoCodigo = PermisoCodigo;
            this.IdComponente = IdComponente;
            this.Descripcion = Descripcion;
            this.IdComponenteHijo = IdComponenteHijo;
        }
    }
}

