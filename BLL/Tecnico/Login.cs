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

        //Login con validación de usuario
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

                        foreach (var element in BE.Usuario.Instance.Permisos.List())
                        {
                            //if (element.descripcion.Equals("Restore"))// ejemplo de lo que tenes que hacer para validar QUE cosas habilitas luego
                            if (!element.descripcion.Equals(" "))
                            {
                                retornableComoCocaCola = true;
                                break;
                            }
                            else
                            {
                                EncontrarRolEnArbol(element.descripcion, element);
                            }
                        }
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
                    //if (comp.descripcion.Equals("Restore"))
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
