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
            return CyPDAL.TraerFamiliasDAL();
        }

        public List<BE.Composite.Component> TraerPatentes()
        {
            return CyPDAL.TraerPatentesDAL();
        }
    }
}
