using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {
        private DAL.LoginUsuario DALUserLogin = new DAL.LoginUsuario();
        DAL.CompositeyPermisosDAL comp = new DAL.CompositeyPermisosDAL();
        DAL.BitacoraDAL bitacora = new DAL.BitacoraDAL();
        BLL.Usuario usuarioABM = new BLL.Usuario();

        /// <summary>
        /// Login con validación de usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Boolean DetectarUsuario(BE.BE_Usuario user)
        {
            Boolean retornableComoCocaCola = false;

            user.Pass = Servicios.Encriptacion.Encriptador(user.Pass);
            if (DALUserLogin.DetectarUsuario(user))
            {
                if (DALUserLogin.LoginUser(user))
                {
                    Servicios.Sesion.Login(user);
                    DALUserLogin.BuscarUsuarioBD();
                    comp.NewObtenerPermisoUsuario();
                    retornableComoCocaCola = true;
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Inicio de sesión por el usuario", "Ninguno"));
                }
            }
            return retornableComoCocaCola;
        }

        /// <summary>
        /// Validar por pregunta si el usuario se desbloquea
        /// </summary>
        public bool ValidacionPalabraSecreta(BE.BE_Usuario user)
        {
            return DALUserLogin.ValidacionPalabraSecreta(user);
        }

        /// <summary>
        /// Metodo de ruta para cambiar la pass del usuario |Recupero de pass aplica
        /// </summary>
        /// <param name="user"></param>
        public void CambiarPass(BE_Usuario user)
        {
            user = DAL.ABMUsuariosDAL.DameId(user);
            DAL.ABMUsuariosDAL.RecuperoPass(user);
            BLL.DV.RecalcularDigitosVerificadores();
            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se reestableció la contraseña " + user.User, "Ninguno"));
        }
        /// <summary>
        /// Validacion que el usuario tenga perfil Admin
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool ValidarAdmin(BE_Usuario user)
        {
            if (user.Permisos != null)
                if (user.Permisos.VerificarSiExistePermiso("15"))
                    return true;
                else
                    return false;
            return
                false;
        }
    }
}
