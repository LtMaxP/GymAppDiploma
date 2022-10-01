using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLLCalculos
    {
        public static int DameIdM(string text)
        {
            return DAL.Negocio.DALCalculos.DameIdM(text);
        }

    }
}
