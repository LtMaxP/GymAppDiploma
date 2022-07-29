using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public abstract class Component
    {

        public string iDPatente { get; set; }
        public string descripcion { get; set; }
        public abstract IList<Component> List();
        public abstract IEnumerable<Component> ListHoja();

        public Component(string idPat, string descrip)
        {
            this.iDPatente = idPat;
            this.descripcion = descrip;
        }

        public abstract void Agregar(Component componente);
        public abstract void Eliminar(Component componente);
        public abstract bool VerificarSiExiste(Component componente);
        public abstract bool VerificarSiExistePermiso(string id);
    }
}
