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
        public Boolean RecalcularDVV()
        {
            DataTable listaDVHUsuarios = dVDal.ObtenerListaDeDVHUsuarios();

            string hash = string.Empty;

            foreach (var n in listaDVHUsuarios.Rows)
            {
                hash += n.ToString();
            }

            //hasheo
            string hasheoDVV = Servicios.Encriptacion.Encriptador(hash);
            String DVV = dVDal.TraerDVV();
            if (DVV.Equals(hash))
            {
                return true;
            }
            else { return false; }

        }
        public void CalcularDVV()
        {
            DataTable listaDVHUsuarios = dVDal.ObtenerListaDeDVHUsuarios();

            string hash = string.Empty;

            foreach (string n in listaDVHUsuarios.Rows)
            {
                hash += n;
            }

            //hasheo
            string hasheoDVV = Servicios.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVV(hasheoDVV);
            //probandoCositas.Pepe();

        }
        public void RecalcularDVH()
        {
            string hash = string.Empty;

            hash = user.IdUsuario.ToString() + user.User + user.Pass;

            //hasheo
            string hasheoDVH = Servicios.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVHEnUsuario(hasheoDVH);
        }

        public String TraerDVV()
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
