using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Compositergal
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


        public override List<Component> List()
        {
            return listadoComponent; //mismo list del usuario
        }
    }

}
