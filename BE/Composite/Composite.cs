using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
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
                listadoComponent.Add(componente);
            }
        }

        public override void Eliminar(Component componente)
        {
            if (componente != null)
            {
                foreach (var it in listadoComponent)
                {
                    if (componente == it)
                    {
                        listadoComponent.Remove(it);
                        break;
                    }
                    else if (it is Composite)
                        BusquedaDelete(componente, it);
                    else if (it is Hoja)
                    {
                        if (it == componente)
                            listadoComponent.Remove(it);
                    }
                }
            }
        }

        public override IList<Component> List()
        {
            return listadoComponent.ToArray();
        }

        public override IEnumerable<Component> ListHoja()
        {
            return listadoComponent;
        }

        public override bool VerificarSiExiste(Component componente)
        {
            return this.iDPatente == componente.iDPatente || listadoComponent.Any(p => p.VerificarSiExiste(componente));
        }

        public override bool VerificarSiExistePermiso(string id)
        {
            return this.iDPatente == id || listadoComponent.Any(p => p.VerificarSiExistePermiso(id));
        }

        public override Component TraetePermiso(string id)
        {
            Component perm = null;
            foreach (var a in listadoComponent)
            {
                if (a.iDPatente == id)
                {
                    perm = a;
                    return perm;
                }
                if (a is Composite)
                {
                    perm = a.TraetePermiso(id);
                    if (perm != null)
                        return perm;
                }
            }
            return perm;// listadoComponent.Find(p => p.iDPatente.Equals(id));
        }

        private Component BusquedaDelete(Component componenteBusqueda, Component componenteListado)
        {
            foreach (var cmp in componenteListado.List())
            {
                if (cmp == componenteBusqueda)
                {
                    componenteListado.Eliminar(cmp);
                    return componenteListado;
                }
                if (cmp is Composite)
                {
                    BusquedaDelete(componenteBusqueda, cmp);
                }
            }
            return componenteListado;
        }
    }

}
