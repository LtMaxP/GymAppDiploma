using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public abstract class Component
    {
        public BE_Usuario usuario { get; set; }
        public string iDPatente { get; set; }
        public string descripcion { get; set; }
        public abstract List<Component> ObtenerPermisos();
        public abstract void AgregarHijo(Component _miComponente);
        public abstract void Eliminar(Component _miComponente);
        public abstract bool VerificarSiExiste(Component componente);
        public abstract IEnumerable<Component> ObtenerHijo();
    }
}
