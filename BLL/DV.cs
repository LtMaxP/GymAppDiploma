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
        BE.Usuario user = BE.Usuario.Instance;
        private DAL.DigitoVerificadorDAL dVDal = new DAL.DigitoVerificadorDAL();
        public void RecalcularDVV()
        {
            List<BE.DVH> listaDVH = dVDal.ObtenerListaDeUsuarios();

            string hash = string.Empty;

            foreach (BE.DVH n in listaDVH)
            {
                hash = n.IDUser.ToString() + n.Nombre.ToString() + n.Pass.ToString();
            }

            //hasheo
            string hasheoDVV = Seguridad.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVV(hasheoDVV);
        }

        public void RecalcularDVH()
        {
            string hash = string.Empty;

            hash = user.IdUsuario.ToString() + user.User.ToString() + user.Pass.ToString();

            //hasheo
            string hasheoDVV = Seguridad.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVHEnUsuario(hasheoDVV);
        }

        //public DataTable TraerDVV()
        //{
        //    DataTable dt = new DataTable();
        //    DAL.DigitoVerificadorDAL.

        //    return dt;
        //}
    }
}
