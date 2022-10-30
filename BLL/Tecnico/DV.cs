using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DV
    {
        /// <summary>
        /// Recalculo total
        /// </summary>
        public static bool RecalcularDigitosVerificadores()
        {
            foreach (BE.BE_Usuario user in DAL.ABMUsuariosDAL.ListadoUsuarios())
            {
                user._DVH = Servicios.DigitoVerificadorHV.CrearDVH(user);
                DAL.DigitoVerificadorDAL.InsertarDVHEnUsuario(user);
            }
            string hasheoDVV = Servicios.DigitoVerificadorHV.CalcularDVV(DAL.ABMUsuariosDAL.ListadoUsuarios());
            DAL.DigitoVerificadorDAL.InsertarDVV(hasheoDVV);
            return true;
        }

        /// <summary>
        /// Verificador de integridad de la Base de datos
        /// </summary>
        /// <returns></returns>
        public bool VerificarDB()
        {
            List<BE.BE_Usuario> listUsers = new List<BE.BE_Usuario>();
            foreach (BE.BE_Usuario user in DAL.ABMUsuariosDAL.ListadoUsuarios())
            {
                user._DVH = Servicios.DigitoVerificadorHV.CrearDVH(user);
                listUsers.Add(user);
            }

            string DVV = Servicios.DigitoVerificadorHV.CalcularDVV(listUsers);
            return DVV.Equals(DAL.DigitoVerificadorDAL.TraerDVV()) ? true : false;
        }

    }
}
