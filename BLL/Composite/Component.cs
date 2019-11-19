using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Composite
{
    public abstract class Component
    {

        public string iDPatente { get; set; }
        public string descripcion { get; set; }

        public Component(string idPat, string descrip)
        {
            this.iDPatente = idPat;
            this.descripcion = descrip;
        }

        public abstract void Agregar(Component componente);
        public abstract void Eliminar(Component componente);
    }
}
