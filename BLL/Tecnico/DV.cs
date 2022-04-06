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
            DataTable listaDVHUsuarios = dVDal.ObtenerListaDeDVHUsuarios();

            string hash = string.Empty;

            foreach (string n in listaDVHUsuarios.Rows)
            {
                hash += n;
            }

            //hasheo
            string hasheoDVV = Seguridad.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVV(hasheoDVV);
            //probandoCositas.Pepe();

        }

        public void RecalcularDVH()
        {
            string hash = string.Empty;

            hash = user.IdUsuario.ToString() + user.User + user.Pass;

            //hasheo
            string hasheoDVH = Seguridad.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVHEnUsuario(hasheoDVH);
        }

        public DataTable TraerDVV()
        {
            return dVDal.TraerDVV(); 
        }

        public DataTable TraerDVH()
        {
            DataTable dt = new DataTable();
            dt = dVDal.TraerDVH();
            return dt;
        }

    }
}
