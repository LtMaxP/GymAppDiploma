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
            List<string> listaDVH = dVDal.ObtenerListaDeDVHUsuarios();

            string hash = string.Empty;

            foreach (string n in listaDVH)
            {
                hash = hash + user._DVH;
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
            string hasheoDVH = Seguridad.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVHEnUsuario(hasheoDVH);
        }

        public DataTable TraerDVV()
        {
            DataTable dt = new DataTable();
            dt = dVDal.TraerDVV();
            return dt;
        }

        public DataTable TraerDVH()
        {
            DataTable dt = new DataTable();
            dt = dVDal.TraerDVH();
            return dt;
        }

    }
}
