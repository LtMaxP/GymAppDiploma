using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFacturas
    {
        /// <summary>
        /// Ejecutar Compra enviando Factura
        /// </summary>
        /// <param name="factura"></param>
        public static void EjecutarCompra(BE.BE_Factura factura)
        {
            DAL.DALFactura.EjecutarCompraDAL(factura);
        }
    }
}
