using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Compuesto : Component
    {
        public override void Agregar(Component componente)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Component componente)
        {
            throw new NotImplementedException();
        }

        public override List<Component> ObtenerPermisos()
        {
            throw new NotImplementedException();
        }
    }

}
