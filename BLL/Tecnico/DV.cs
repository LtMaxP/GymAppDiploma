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
        //DAL.ABMUsuariosDAL ABMUs = new DAL.ABMUsuariosDAL();

        public static void RecalcularDigitosVerificadores()
        {
            foreach (BE.BE_Usuario usu in DAL.ABMUsuariosDAL.ListadoUsuarios())
            {
                RecalcularDVH(usu);
            }
            RecalcularDVV(DAL.ABMUsuariosDAL.ListadoUsuarios());
        }

        private static void RecalcularDVV(List<BE.BE_Usuario> listadoUsers)
        {
            string hash = string.Empty;
            foreach (BE.BE_Usuario usu in listadoUsers)
            {
                hash += usu._DVH;
            }

            //hasheo
            string hasheoDVV = Servicios.Encriptacion.Encriptador(hash);
            //insertar
            DAL.DigitoVerificadorDAL.InsertarDVV(hasheoDVV);
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
        }

        /// <summary>
        /// Recalcula el DVH del usuario pasado y se inserta en la DB
        /// </summary>
        /// <param name="user"></param>
        private static void RecalcularDVH(BE.BE_Usuario user)
        {
            string hash = string.Empty;

            hash = user.IdUsuario.ToString() + user.User + user.Pass;

            //hasheo
            user._DVH = Servicios.Encriptacion.Encriptador(hash);
            //Insertar
            DAL.DigitoVerificadorDAL.InsertarDVHEnUsuario(user);
        }

        public bool VerificarDB()
        {
            string DVV = Servicios.DigitoVerificadorHV.CalcularDVV(DAL.DigitoVerificadorDAL.ObtenerListaDeDVHUsuarios());
            return DVV.Equals(DAL.DigitoVerificadorDAL.TraerDVV()) ? true : false;
        }

        public String TraerDVV()
        {
            return DAL.DigitoVerificadorDAL.TraerDVV();
        }

        public DataTable TraerDVH()
        {
            DataTable dt = new DataTable();
            dt = DAL.DigitoVerificadorDAL.TraerDVH();
            return dt;
        }

    }
}
