using BE.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tecnico
{
    public class PermisosBLL
    {
        DAL.CompositeyPermisosDAL CyPDAL = new DAL.CompositeyPermisosDAL();
        public BE.Composite.Component TraerComponentesFyP()
        {
            return CyPDAL.TraerTodoFamiliasOPatentesDALNEW();
        }
        public BE.Composite.Component TraerAgrupadosDAL()
        {
            return CyPDAL.TraerComponentesAgrupadosDAL();
        }

        public BE.BE_Usuario TraerUsuarioConPermisos(BE.BE_Usuario user)
        {
            return CyPDAL.PermisosPorUsuario(user);
        }

        public bool CrearFamilia(BE.Composite.Composite newFamilia, string familiaNombre)
        {
            return CyPDAL.CrearFamilia(newFamilia, familiaNombre);
        }
    }
}
