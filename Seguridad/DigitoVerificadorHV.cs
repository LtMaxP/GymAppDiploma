using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios
{
    public class DigitoVerificadorHV
    {
        /// <summary>
        /// Creacion de DVH
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string CrearDVH(BE_Usuario user)
        {
            string hash = user.IdUsuario.ToString() + user.User + user.Pass;
            //hasheo
            string hasheoDVH = Servicios.Encriptacion.Encriptador(hash);
            return hasheoDVH;
        }

        /// <summary>
        /// Calcular DVV por listado de DVH
        /// </summary>
        /// <param name="usersDVH"></param>
        /// <returns></returns>
        public static string CalcularDVV(DataTable usersDVH)
        {
            string hash = null;
            foreach (DataRow us in usersDVH.Rows)
            {
                hash += us[0].ToString();
            }
            string hasheoDVH = Servicios.Encriptacion.Encriptador(hash);
            return hasheoDVH;
        }
    }
}
