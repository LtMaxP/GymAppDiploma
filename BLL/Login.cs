using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {
        DAL.LoginUsuario DALUserLogin = new DAL.LoginUsuario();
        Seguridad.Encriptacion encrip = new Seguridad.Encriptacion();

        static void Main() { }

        public Boolean BuscarUsuario(string usuario, string pass)
        {
            Boolean bo = DALUserLogin.BuscarUsuarioBD(usuario, pass);
            
            return bo;
        }

        public Boolean DetectarUsuario(string usuario, string pass)
        {
            string passEncript = encrip.Encriptador(pass);
            return DALUserLogin.DetectarUsuario(usuario, passEncript);
        }
    }
}
