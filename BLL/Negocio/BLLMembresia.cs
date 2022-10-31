using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BE.Negocio;
using DAL;

namespace BLL.Negocio
{
    public class BLLMembresia
    {
        /// <summary>
        /// dame listado de membresias
        /// </summary>
        /// <returns></returns>
        public static List<BE.Negocio.BE_Membresia> DameMembresias()
        {
            return DAL.Negocio.DALMembresia.DameMembresias();
        }
        /// <summary>
        /// dame membresia por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static BE_Membresia DameMembresiaPorId(int id)
        {
            return DAL.Negocio.DALMembresia.DameMembresiaPorId(id);
        }

        /// <summary>
        /// dame listado de pagos por dni de cliente
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<BE.BE_Cuenta> DamePagosCliente(Cliente client)
        {
            return DAL.Negocio.DALMembresia.DamePagosCliente(client);
        }
        /// <summary>
        /// se valida si pasaron mas de 30 días del último pago
        /// </summary>
        /// <returns></returns>
        public static bool ValidarFaltaPago(BE.Cliente cliente)
        {
            return DAL.Negocio.DALMembresia.ValidarFaltaPago(cliente);
        }
        /// <summary>
        /// Pagar
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool EjecutarPago(Cliente cliente)
        {
            return DAL.Negocio.DALMembresia.EjecutarPago(cliente);
        }
    }
}