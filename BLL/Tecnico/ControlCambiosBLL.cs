using BE.Tecnico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return DAL.Tecnico.ControlCambiosDAL.TTCC();
        }

        public static void GuardarCC(BE.Tecnico.ControlCambio rCC)
        {
            rCC.usuarioID = Servicios.Sesion.GetInstance.usuario.IdUsuario;
            DAL.Tecnico.ControlCambiosDAL.GrabarCC(rCC);
        }

        public static List<BE.Tecnico.ControlCambio> TraerCC(ControlCambio cc, DateTime dt1, DateTime dt2)
        {
            return DAL.Tecnico.ControlCambiosDAL.TTCC(cc, dt1, dt2);
        }
    }
}
