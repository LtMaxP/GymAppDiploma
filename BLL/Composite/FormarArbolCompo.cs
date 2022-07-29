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

        public void FormarArbolDeUsuarioLog()
        {
            comp.NewObtenerPermisoUsuario();
        }

    }

}
