using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public enum Roles
    {
        Administrador = 0,
        Gerente = 1,
        Empleado = 2,
        Error = 404,
    }

    public class Login
    {
        private DAL.LoginUsuario DALUserLogin = new DAL.LoginUsuario();
        private Servicios.Encriptacion encrip = new Servicios.Encriptacion();
        private BLL.Composite.FormarArbolCompo formarArbol = new Composite.FormarArbolCompo();
        private BLL.BitacoraBLL bit = new BLL.BitacoraBLL();

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
                        formarArbol.FormarArbolDeUsuarioLog(); //Composite arbol formado
                        retornableComoCocaCola = true;
                        bit.RegistrarMovimiento("Ingreso Usuario con ID: " + BE.Usuario.Instance.IdUsuario, "Bajo"); //cambiar a nueva clase
                    }
                }
            }
            return retornableComoCocaCola;
        }


        public bool EncontrarRolEnArbol(string rol, BE.Composite.Component arbolObjeto)
        {
            Boolean isOk = false;
            if (arbolObjeto.List() != null)
            {
                foreach (BE.Composite.Component comp in arbolObjeto.List())
                {
                    if (!comp.descripcion.Equals(" "))
                    {
                        isOk = true;
                        break;
                    }
                    else
                    {
                        if (EncontrarRolEnArbol(rol, comp))
                        {
                            break;
                        }
                    }
                }
            }
            return isOk;
        }



    }
}
