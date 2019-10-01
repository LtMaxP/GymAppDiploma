using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BitacoraBLL
    {
        private BE.Bitacora bitacora = new BE.Bitacora();
        private DAL.BitacoraDAL bitDal = new DAL.BitacoraDAL();
        public void RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            bitDal.RegistrarBitacora(movimiento, nivelDelProblema, DateTime.Now);
        }
    }
}
