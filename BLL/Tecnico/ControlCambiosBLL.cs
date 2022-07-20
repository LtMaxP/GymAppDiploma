using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tecnico
{
    public class ControlCambiosBLL
    {
        /// <summary>
        /// Traer listado de CC
        /// </summary>
        /// <returns></returns>
        public static List<BE.Tecnico.ControlCambio> TraerCC()
        {
            return DAL.Tecnico.ControlCambiosDAL.TraerCC();
        }

        /// <summary>
        /// Traer en base a un CC especificado
        /// </summary>
        /// <param name="rCC"></param>
        /// <returns></returns>
        public static List<BE.Tecnico.ControlCambio> TraerCCPorCC(BE.Tecnico.ControlCambio rCC)
        {
            return DAL.Tecnico.ControlCambiosDAL.TraerCC();
        }
    }
}
