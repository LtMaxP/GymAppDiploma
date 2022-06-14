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
        public BE.Bitacora RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            BE.Bitacora bit = new BE.Bitacora();
            bit.Movimiento = movimiento;
            bit.NivelDeProblema = nivelDelProblema;
            bit.Fecha = DateTime.Now;
            bit.Usuario = Usuario.Instance.User;
            return bit;
        }
        public static BE.Bitacora CrearMovimiento(BE.Bitacora bitacora)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = Usuario.Instance.User;
            return bitacora;
        }
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

        public static bool Alta(Bitacora valueAlta)
        {

            throw new NotImplementedException();
        }
        


        public DataTable Leer(Bitacora valueBuscar)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valBuscar"></param>
        /// <returns></returns>
        public List<Bitacora> Leer2(Bitacora valBuscar)
        {
            throw new NotImplementedException();
        }



    }

}
