using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class BitacoraBLL
    {
        private DAL.BitacoraDAL bitDal = new DAL.BitacoraDAL();
        private Servicios.BitacoraServicio bit = new Servicios.BitacoraServicio();


        //arreglar con clases
        public void RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            bitDal.RegistrarBitacora(movimiento, nivelDelProblema, DateTime.Now);
        }

        public List<BE.Bitacora> CargarBitacora()
        {
            DataTable dt = bitDal.TraerBitacora();
            List<BE.Bitacora> bitacs = bit.CargarBitacora(dt);
            return bitacs;
        }
    }
}
