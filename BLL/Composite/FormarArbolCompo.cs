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



        //public BE.Composite.Component FormarArbolDeUsuario(int idUsuario)
        //{
        //    List<BE.Composite.Component> listCompo = comp.ObtenerPermisoUsuario(idUsuario);

        //    BE.Composite.Composite composite = new BE.Composite.Composite("0", "Arbol");

        //    foreach (var element in listCompo)
        //    {

        //        if (element.tipo.Contains("F"))
        //        {
        //            BE.Composite.Composite newcompo = FormarArbolito(element);
        //            composite.Agregar(newcompo);
        //        }
        //        else if (element.tipo.Contains("P"))
        //        {
        //            composite.Agregar(new BE.Composite.Hoja(element.idComponente, element.descripcion));
        //        }

        //    }

        //    return composite;
        //}
        public void FormarArbolDeUsuarioLog()
        {
            comp.NewObtenerPermisoUsuario();
        }

        public BE.Composite.Composite FormarArbolito(BE.Compositex compo)
        {
            List<BE.Compositex> listC = comp.ObtenerPerfilConTipo(compo.idComponente);
            BE.Composite.Composite element = new BE.Composite.Composite(compo.idComponente, compo.descripcion);

            foreach (var ele in listC)
            {
                if (ele.tipo.Contains("F"))
                {
                    BE.Composite.Composite newcompo = FormarArbolito(ele);
                    element.Agregar(newcompo);
                }
                else if (ele.tipo.Contains("P"))
                {
                    element.Agregar(new BE.Composite.Hoja(ele.idComponente, ele.descripcion));
                }
            }

            return element;
        }

    }

}
