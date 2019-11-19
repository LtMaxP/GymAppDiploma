using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Composite
{
    public class Composite : Component
    {
        private List<Component> listadoComponent;

        public Composite(string idPat, string descrip) : base(idPat, descrip)
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


        public List<Component> List()
        {
            return listadoComponent;
        }
    }

}
