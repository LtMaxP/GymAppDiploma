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
        public void RestoreBD(string ruta)
        {
            restore.GenerarRestore(ruta);
        }
    }
}
