using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;

namespace BLL
{
    public class BitacoraBLL
    {
        private DAL.BitacoraDAL bitDal = new DAL.BitacoraDAL();
        private Servicios.BitacoraServicio bit = new Servicios.BitacoraServicio();


        public void RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento(movimiento, nivelDelProblema));
        }

        public List<Bitacora> CargarBitacoraFechas(DateTime dt1, DateTime dt2)
        {
            return DAL.BitacoraDAL.TraerBitacoraPorFecha(dt1, dt2);
        }
    }
}
