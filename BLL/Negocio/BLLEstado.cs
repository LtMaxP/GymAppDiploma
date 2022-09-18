using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLLEstado
    {
        public static int DameIdEst(string estado)
        {
            return DAL.Negocio.DALEstado.DameIdEstado(estado);
        }
    }
}
