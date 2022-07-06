using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Compositergal
{
    public abstract class Component
    {

        public string iDPatente { get; set; }
        public string descripcion { get; set; }
        public abstract List<Component> List();

        public Component(string idPat, string descrip)
        {
            this.iDPatente = idPat;
            this.descripcion = descrip;
        }

        public abstract void Agregar(Component componente);
        public abstract void Eliminar(Component componente);
    }
}
