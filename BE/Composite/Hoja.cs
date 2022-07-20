using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Hoja : BE.Composite.Component
    {
        public Hoja(string idPat = null, string descrip = null) : base(idPat, descrip)
        {

        }

        public override void Agregar(Component componente)
        {

        }

        public override void Eliminar(Component componente)
        {
           
        }

        public override IList<Component> List()
        {
            return null;
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente;
        }
    }
}
