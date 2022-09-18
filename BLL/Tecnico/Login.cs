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
        private Servicios.Encriptacion encrip = new Servicios.Encriptacion();
        private Servicios.BitacoraServicio bit = new Servicios.BitacoraServicio();
        DAL.CompositeyPermisosDAL comp = new DAL.CompositeyPermisosDAL();
        DAL.BitacoraDAL bitacora = new DAL.BitacoraDAL();

        static void Main() { }
        /// <summary>
        /// Buscar el ID del usuario
        /// </summary>
        public void BuscarUsuario()
        {
            DALUserLogin.BuscarUsuarioBD();
        }

        /// <summary>
        /// Login con validación de usuario
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Boolean DetectarUsuario(BE.BE_Usuario user)
        {
            Boolean retornableComoCocaCola = false;
            BE.Usuario.Instance.User = user.User;
            BE.Usuario.Instance.Pass = Servicios.Encriptacion.Encriptador(user.Pass);
            if (DALUserLogin.DetectarUsuario())
            {
                if (DALUserLogin.ValidarBloqueo())
                {
                    if (DALUserLogin.LoginUser())
                    {
                        BuscarUsuario();
                        comp.NewObtenerPermisoUsuario();
                        retornableComoCocaCola = true;
                        DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Inicio de sesión por el usuario", "Ninguno"));
                    }
                }
            }
            return retornableComoCocaCola;
        }
    }
}
