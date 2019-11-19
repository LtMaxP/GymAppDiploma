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

        private BE.Usuario user = BE.Usuario.Instance;
        private DAL.LoginUsuario DALUserLogin = new DAL.LoginUsuario();
        private Seguridad.Encriptacion encrip = new Seguridad.Encriptacion();
        private BLL.Composite.FormarArbolCompo formarArbol = new Composite.FormarArbolCompo();
        private BLL.BitacoraBLL bit = new BLL.BitacoraBLL();


        static void Main() { }

        public Boolean BuscarUsuario(string usuario, string pass)
        {
            Boolean bo = DALUserLogin.BuscarUsuarioBD(usuario, pass);

            return bo;
        }

        public Boolean DetectarUsuario(string usuario, string pass)
        {
            Boolean retornableComoCocaCola = false;
            string passEncript = Seguridad.Encriptacion.Encriptador(pass);
            if (DALUserLogin.DetectarUsuario(usuario, passEncript))
            {
                //Composite arbol formado
                var a = formarArbol.FormarArbolDeUsuario(BE.Usuario.Instance.IdUsuario.ToString());
                var ax = a.List();


                foreach (Composite.Composite element in a.List())
                {

                    if (element.descripcion.Equals("Restore"))
                    {
                        retornableComoCocaCola = true;
                        break;
                    }
                    else
                    {
                        EncontrarRolEnArbol(element.descripcion, element);
                    }

                }


                bit.RegistrarMovimiento("Ingreso Usuario con ID: " + BE.Usuario.Instance.IdUsuario, "Bajo");
            }
            else
            {
                retornableComoCocaCola = false;
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
                    if (comp.descripcion.Equals("Restore"))
                    {
                        isOk = true;
                        break;
                    }
                    else
                    {
                        if(EncontrarRolEnArbol(rol, comp))
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
