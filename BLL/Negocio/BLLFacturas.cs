using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFacturas
    {
        BLL.BLLClientes bllClientes = new BLLClientes();
        public BLLFacturas()
        {
        }
        /// <summary>
        /// Ejecutar Compra enviando Factura
        /// </summary>
        /// <param name="factura"></param>
        public static void EjecutarCompra(BE.BE_Factura factura)
        {
            DAL.DALFactura.EjecutarCompraDAL(factura);
        }
        /// <summary>
        /// Serializar y guardar
        /// </summary>
        /// <param name="facturas"></param>
        /// <param name="ruta"></param>
        public static void ExportarFactura(List<BE_Factura> facturas, string ruta)
        {
            Servicios.Serializar.Guardar(facturas, ruta);
        }
        /// <summary>
        /// Traer facturas por DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public List<BE_Factura> TraerFacturas(string dni)
        {
            return DAL.DALFactura.TraerFacturas(dni);
        }
        /// <summary>
        /// Detectar existencia del dni
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public bool DetectarCliente(string dni)
        {
            return bllClientes.ValidarSiExiste(new Cliente() { Dni = int.Parse(dni) });
        }
    }
}
