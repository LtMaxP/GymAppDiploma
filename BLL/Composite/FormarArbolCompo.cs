using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Composite
{
    public class FormarArbolCompo
    {
        DAL.CompositeyPermisosDAL comp = new DAL.CompositeyPermisosDAL();



        public Composite FormarArbolDeUsuario(int idUsuario)
        {
            List<BE.Compositex> listCompo = comp.ObtenerPermisoUsuario(idUsuario);

            Composite composite = new Composite("0", "Arbol");

            foreach (var element in listCompo)
            {

                if (element.tipo.Contains("F"))
                {
                    Composite newcompo = FormarArbolito(element);
                    composite.Agregar(newcompo);
                }
                else if (element.tipo.Contains("P"))
                {
                    composite.Agregar(new Hoja(element.idComponente, element.descripcion));
                }

            }

            return composite;
        }
        public void FormarArbolDeUsuarioLog()
        {
            List<BE.Compositex> listCompo = comp.ObtenerPermisoUsuario(BE.Usuario.Instance.IdUsuario);

            Composite composite = new Composite();
            //se estaba creando y viendo composite con esto sin registros
            foreach (var element in listCompo)
            {

                if (element.tipo.Contains("F"))
                {
                    Composite newcompo = FormarArbolito(element);
                    composite.Agregar(newcompo);
                }
                else if (element.tipo.Contains("P"))
                {
                    composite.Agregar(new Hoja(element.idComponente, element.descripcion));
                }

            }

        }

        public Composite FormarArbolito(BE.Compositex compo)
        {
            List<BE.Compositex> listC = comp.ObtenerPerfilConTipo(compo.idComponente);
            Composite element = new Composite(compo.idComponente, compo.descripcion);

            foreach (var ele in listC)
            {
                if (ele.tipo.Contains("F"))
                {
                    Composite newcompo = FormarArbolito(ele);
                    element.Agregar(newcompo);
                }
                else if (ele.tipo.Contains("P"))
                {
                    element.Agregar(new Hoja(ele.idComponente, ele.descripcion));
                }
            }

            return element;
        }

    }

}
