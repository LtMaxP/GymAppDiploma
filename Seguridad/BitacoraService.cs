using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Servicios
{
    public class BitacoraServicio
    {
        public BitacoraServicio()
        {

        }
        /// <summary>
        /// Crea un objeto bitacora por medio del movimiento y el nivel del problema que pase
        /// </summary>
        /// <param name="movimiento"></param>
        /// <param name="nivelDelProblema"></param>
        /// <returns></returns>
        public static BE.Bitacora RegistrarMovimiento(string movimiento, string nivelDelProblema)
        {
            BE.Bitacora bit = new BE.Bitacora();
            bit.Movimiento = movimiento;
            bit.NivelDeProblema = nivelDelProblema;
            return bit;
        }
        /// <summary>
        /// devuelve la bitacora con el usuario logeado y la fecha con hora actual 
        /// </summary>
        /// <param name="bitacora"></param>
        /// <returns></returns>
        public static BE.Bitacora CrearMovimiento(BE.Bitacora bitacora)
        {
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = Sesion.GetInstance.usuario.User;
            return bitacora;
        }
    }

}
