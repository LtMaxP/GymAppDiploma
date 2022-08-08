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
        public List<BE.Composite.Component> TraerFamilias()
        {
            return CyPDAL.TraerFamiliasOPatentesDAL("F");
        }

        public List<BE.Composite.Component> TraerPatentes()
        {
            return CyPDAL.TraerFamiliasOPatentesDAL("P");
        }
        public BE.Composite.Component TraerComponentesFyP()
        {
            return CyPDAL.TraerTodoFamiliasOPatentesDALNEW();
        }
        
        public bool DetectarUsuario(BE.BE_Usuario user)
        {
            return CyPDAL.DetectarUsuario(user);
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
