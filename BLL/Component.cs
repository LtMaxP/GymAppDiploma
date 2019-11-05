using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Component
    {
        public BE.Usuario usuario { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }

        public abstract void Agregar(Component componente);
        public abstract void Eliminar(Component componente);

        public abstract List<Component> ObtenerPermisos();
    }
}
