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

        //private BE.Usuario user = new BE.Usuario();

        private DAL.LoginUsuario DALUserLogin = new DAL.LoginUsuario();
        private Servicios.Encriptacion encrip = new Servicios.Encriptacion();
        private BLL.Composite.FormarArbolCompo formarArbol = new Composite.FormarArbolCompo();
        private BLL.BitacoraBLL bit = new BLL.BitacoraBLL();


        static void Main() { }

        public void BuscarUsuario()
        {
            DALUserLogin.BuscarUsuarioBD();
        }

        //Login con validación de usuario
        public Boolean DetectarUsuario(string usuario, string pass)
        {
            Boolean retornableComoCocaCola = false;
            //string passEncript = Seguridad.Encriptacion.Encriptador(pass);
            if (DALUserLogin.DetectarUsuario(usuario))
            {
                BE.Usuario.Instance.User = usuario;
                BE.Usuario.Instance.Pass = pass;
                if (DALUserLogin.LoginUser()) //passEncript arreglalo que la cagaste
                {
                    BuscarUsuario();
                    //Composite arbol formado
                    var a = formarArbol.FormarArbolDeUsuario(BE.Usuario.Instance.IdUsuario);

                    foreach (Composite.Composite element in a.List())
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
                ////if (user.IntentosFallidos == 3)
                ////{
                ////    //bloqueas usuario
                ////}

            }
            return retornableComoCocaCola;
        }


        public bool EncontrarRolEnArbol(string rol, Composite.Component arbolObjeto)
        {
            Boolean isOk = false;
            if (arbolObjeto.List() != null)
            {
                foreach (Composite.Component comp in arbolObjeto.List())
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
