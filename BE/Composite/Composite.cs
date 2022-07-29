using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Composite : Component
    {
        private List<Component> listadoComponent = new List<Component>();

        public Composite(string idPat = null, string descrip = null) : base(idPat, descrip)
        {
        }

        public override void Agregar(Component componente)
        {
            if (componente != null)
            {
                listadoComponent.Add(componente);
            }
        }

        public override void Eliminar(Component componente)
        {
            if (componente != null)
            {
                listadoComponent.Remove(componente);
            }
        }


        public override IList<Component> List()
        {
            return listadoComponent.ToArray();
        }

        public override IEnumerable<Component> ListHoja()
        {
            return listadoComponent;
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente || listadoComponent.Any(p => p.VerificarSiExiste(componente));
        }

        public override bool VerificarSiExistePermiso(string id)
        {
            return this.iDPatente == id || listadoComponent.Any(p => p.VerificarSiExistePermiso(id));
        }
    }

}
