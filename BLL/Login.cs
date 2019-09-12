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

        public Boolean BuscarUsuario(string usuario, string pass)
        {
            Boolean bo = DALUserLogin.BuscarUsuarioBD(usuario, pass);
            
            return bo;
        }

        public Boolean DetectarUsuario(string usuario, string pass)
        {
            return DALUserLogin.DetectarUsuario(usuario, pass);
        }
    }
}
