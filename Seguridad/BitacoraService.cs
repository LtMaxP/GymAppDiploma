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
        private BE.Bitacora bit = new BE.Bitacora();
        public BE.Bitacora RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            bit.Movimiento = movimiento;
            bit.NivelDeProblema = nivelDelProblema;
            bit.Fecha = DateTime.Now;
            return bit;
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

        //Eventos y delegados // Events and Delegates
        
        public event EventHandler<Bitacora> RegBit;

        protected virtual BE.Bitacora OnRegBit(BE.Bitacora biti)
        {
            if (RegBit != null)
            {
                biti.Fecha = DateTime.Now;
                RegBit(this, biti);
            }
            return biti;

        }


    }
}
