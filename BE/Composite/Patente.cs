using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Patente : Component
    {
        /// <summary>
        /// Representa la lista de componentes de la patente
        /// </summary>
        public List<Component> _ListaComponentes = new List<Component>();

        public override void AgregarHijo(Component _miComponente)
        {
            _ListaComponentes.Add(_miComponente);
        }

        public override void Eliminar(Component _miComponente)
        {
           
        }

        public override IEnumerable<Component> ObtenerHijo()
        {
            return new List<Component>();
        }

        public override List<Component> ObtenerPermisos()
        {
            return _ListaComponentes;
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente;
        }
    }
}
