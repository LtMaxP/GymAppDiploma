using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Hoja : BE.Composite.Component
    {
        private List<Component> listadoComponent = new List<Component>();
        public Hoja(string idPat = null, string descrip = null) : base(idPat, descrip)
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
           
        }

        public override IList<Component> List()
        {
            return listadoComponent;
        }

        public override IEnumerable<Component> ListHoja()
        {
            return listadoComponent;
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente;
        }
        public override bool VerificarSiExistePermiso(string id)
        {
            if(!String.IsNullOrEmpty(id))
                return this.iDPatente == id;
            return false;
        }
    }
}
