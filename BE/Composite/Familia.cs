using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Familia : Component
    {
        /// <summary>
        /// Lista de componentes de la familia
        /// </summary>
        public List<Component> _ListaComponentes = new List<Component>();
        /// <summary>
        /// Constructor sobrecargado de la clase Familia
        /// </summary>
        /// <param name="PatenteCod"></param>
        /// <param name="Descripcion"></param>
        public Familia(string PatenteCod, string Descripcion)
        {
            base.iDPatente = PatenteCod;
            base.descripcion = Descripcion;
        }
        /// <summary>
        /// Constructor sobrecargado de la clase Familia
        /// </summary>
        /// <param name="PatenteCod"></param>
        /// <param name="Descripcion"></param>
        /// <param name="usuario"></param>
        public Familia(string PatenteCod, string Descripcion, BE_Usuario usuario)
        {
            base.iDPatente = PatenteCod;
            base.descripcion = Descripcion;
            base.usuario = usuario;
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Familia()
        {
        }
        public override void AgregarHijo(Component _miComponente)
        {
            _ListaComponentes.Add(_miComponente);
        }

        public override void Eliminar(Component _miComponente)
        {
            _ListaComponentes.Remove(_miComponente);
        }

        public override IEnumerable<Component> ObtenerHijo()
        {
            return _ListaComponentes;
        }

        public override List<Component> ObtenerPermisos()
        {
            return _ListaComponentes;
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente || _ListaComponentes.Any(p => p.VerificarSiExiste(componente));
        }
    }
}
