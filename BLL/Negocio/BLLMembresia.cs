using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Negocio;
using DAL;

namespace BLL.Negocio
{
    public class BLLMembresia
    {
        public static List<BE.Negocio.BE_Membresia> DameMembresias()
        {
            return DAL.Negocio.DALMembresia.DameMembresias();
        }

        public static BE_Membresia DameMembresiaPorId(int id)
        {
            return DAL.Negocio.DALMembresia.DameMembresiaPorId(id);
        }
    }
}