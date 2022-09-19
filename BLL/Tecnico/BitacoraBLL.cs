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


        public void RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento(movimiento, nivelDelProblema));
        }
        //public void RegistrarEnBitacora(BE.Bitacora bitacora)
        //{
        //    bitacora.Usuario = BE.Usuario.Instance.IdUsuario.ToString();
        //    bitacora.Fecha = DateTime.Now;
        //    bitDal..RegistrarBitacora(bitacora);
        //}
        public List<BE.Bitacora> CargarBitacora()
        {
            DataTable dt = bitDal.TraerBitacora();
            List<BE.Bitacora> bitacs = bit.CargarBitacora(dt);
            return bitacs;
        }
    }
}
