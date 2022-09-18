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
        private DAL.DigitoVerificadorDAL dVDal = new DAL.DigitoVerificadorDAL();
        public Boolean RecalcularDVV()
        {
            DataTable listaDVHUsuarios = DAL.DigitoVerificadorDAL.ObtenerListaDeDVHUsuarios();

            string hash = string.Empty;

            foreach (DataRow row in listaDVHUsuarios.Rows)
            {
                hash += row[0].ToString();
            }

            //hasheo
            string hasheoDVV = Servicios.Encriptacion.Encriptador(hash);
            String DVV = dVDal.TraerDVV();
            if (DVV.Equals(hasheoDVV))
            {
                return true;
            }
            else { return false; }

        }
        public void CalcularDVV()
        {
            DataTable listaDVHUsuarios = DAL.DigitoVerificadorDAL.ObtenerListaDeDVHUsuarios();

            string hash = string.Empty;

            foreach (string n in listaDVHUsuarios.Rows)
            {
                hash += n;
            }

            //hasheo
            string hasheoDVV = Servicios.Encriptacion.Encriptador(hash);
            //Insertar

            DAL.DigitoVerificadorDAL.InsertarDVV(hasheoDVV);
            //probandoCositas.Pepe();

        }
        public void RecalcularDVH()
        {
            string hash = string.Empty;

            hash = BE.Usuario.Instance.IdUsuario.ToString() + BE.Usuario.Instance.User + BE.Usuario.Instance.Pass;

            //hasheo
            string hasheoDVH = Servicios.Encriptacion.Encriptador(hash);
            //Insertar
            dVDal.InsertarDVHEnUsuario(hasheoDVH);
        }

        public bool VerificarDB()
        {
            string DVV = Servicios.DigitoVerificadorHV.CalcularDVV(DAL.DigitoVerificadorDAL.ObtenerListaDeDVHUsuarios());
            return DVV.Equals(dVDal.TraerDVV()) ? true : false;
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
