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

        static void Main() { }

        public Boolean BuscarUsuario(string usuario, string pass)
        {
            Boolean bo = DALUserLogin.BuscarUsuarioBD(usuario, pass);

            return bo;
        }

        public String DetectarUsuario(string usuario, string pass)
        {
            String retornableComoCocaCola = null;
            string passEncript = encrip.Encriptador(pass);
            if (DALUserLogin.DetectarUsuario(usuario, passEncript))
            {
                foreach(string rolesContenidos in Enum.GetNames(typeof(Roles)))
                {
                    if (user.Rol == rolesContenidos)
                    {
                        retornableComoCocaCola = rolesContenidos;
                        break;
                    }
                }
            }
            else
            {
                retornableComoCocaCola = Roles.Error.ToString();
            }
            return retornableComoCocaCola;
        }
    }
}
