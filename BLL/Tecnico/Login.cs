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
            //string passEncript = Seguridad.Encriptacion.Encriptador(pass);
            if (DALUserLogin.DetectarUsuario(usuario, pass)) //passEncript arreglalo que la cagaste
            {
                //Composite arbol formado
                var a = formarArbol.FormarArbolDeUsuario(BE.Usuario.Instance.IdUsuario.ToString());


                foreach (Composite.Composite element in a.List())
                {

                    //if (element.descripcion.Equals("Restore"))// ejemplo de lo que tenes que hacer para validar QUE cosas habilitas luego
                    if(!element.descripcion.Equals(" "))
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
                    //if (comp.descripcion.Equals("Restore"))
                    if(!comp.descripcion.Equals(" "))
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
