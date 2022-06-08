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
            List<BE.Composite> listCompo = comp.ObtenerPermisoUsuario(idUsuario);

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


        public Composite FormarArbolito(BE.Composite compo)
        {
            List<BE.Composite> listC = comp.ObtenerPerfilConTipo(compo.idComponente);
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
