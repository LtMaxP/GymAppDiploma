using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tecnico
{
    public class Restore
    {
        DAL.Tecnico.RestoreDAL restore = new DAL.Tecnico.RestoreDAL();
        public bool RestoreBD(string ruta)
        {
            return restore.GenerarRestore(ruta);
        }
    }
}
