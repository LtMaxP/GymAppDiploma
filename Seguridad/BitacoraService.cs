using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;

namespace Servicios
{
    public class BitacoraServicio
    {
        public static BE.Bitacora RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            BE.Bitacora bit = new BE.Bitacora();
            bit.Movimiento = movimiento;
            bit.NivelDeProblema = nivelDelProblema;
            return bit;
        }
        public static BE.Bitacora CrearMovimiento(BE.Bitacora bitacora)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = Usuario.Instance.User;
            return bitacora;
        }
        //public static BE.Bitacora CrearRegistroBkp(BE.Bitacora bitacora)
        //{
        //    bitacora.Fecha = DateTime.Parse((DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute).ToString());
        //    bitacora.Usuario = Usuario.Instance.User;
        //    return bitacora;
        //}

        public List<BE.Bitacora> CargarBitacora(DataTable bitacora)
        {
            List<BE.Bitacora> bitacoras = new List<BE.Bitacora>();
            foreach (DataRow dr in bitacora.Rows)
            {
                BE.Bitacora b = new BE.Bitacora();
                b.Movimiento = dr.Field<string>("Movimiento");
                b.Fecha = dr.Field<DateTime>("FechaDelMov");
                b.NivelDeProblema = dr.Field<string>("NivelDelProblema");
                bitacoras.Add(b);
            }
            return bitacoras;
        }

    }

}
