using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Composite : Component
    {
        private List<Component> listadoComponent;

        public Composite(string idPat = null, string descrip = null) : base(idPat, descrip)
        {
            listadoComponent = new List<Component>();
        }

        public override void Agregar(Component componente)
        {
            if (componente != null)
            {
                listadoComponent.Add(componente); //aca iria el listado para el usuario
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
            return listadoComponent.ToArray(); //mismo list del usuario
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente || listadoComponent.Any(p => p.VerificarSiExiste(componente));
        }
    }

}
