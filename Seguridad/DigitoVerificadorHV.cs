using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios
{
    public class DigitoVerificadorHV
    {
        public static string CrearDVH(BE_Usuarios user)
        {
            string hash = string.Empty;

            hash = user.IdUsuario.ToString() + user.User + user.Pass;

            //hasheo
            string hasheoDVH = Servicios.Encriptacion.Encriptador(hash);

            return hasheoDVH;
        }
    }
}
