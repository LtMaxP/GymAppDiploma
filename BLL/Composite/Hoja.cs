using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Composite
{
    public class Hoja : Component
    {
        public Hoja(string idPat, string descrip) : base(idPat, descrip)
        {

        }

        public override void Agregar(Component componente)
        {
            
        }

        public override void Eliminar(Component componente)
        {
           
        }

        public override List<Component> List()
        {
            return null;
        }
    }
}
