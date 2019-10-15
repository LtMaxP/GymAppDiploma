using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Usuario
    {
        DAL.BusquedaDAL buscar = new DAL.BusquedaDAL();
        DAL.ICRUD<BE.ABMUsuarios> cRUD = new DAL.ABMUsuariosDAL();

        public void AgregarUsuario(string usuario, string contraseña, string idioma, string estado)
        {
            contraseña = Seguridad.Encriptacion.Encriptador(contraseña);
            ABMUsuarios altaUser = new ABMUsuarios();
            DevolverIDs(altaUser, idioma, estado);
            altaUser.User = usuario;
            altaUser.Pass = contraseña;

            cRUD.Alta(altaUser);

        }

        public void EliminarUsuario(string usuario)
        {
            ABMUsuarios bajaUser = new ABMUsuarios();
            bajaUser.User = usuario;
            cRUD.Baja(bajaUser);
        }

        public void ModificarUsuario(string usuario, string contraseña, string idioma, string estado)
        {
            ABMUsuarios modUser = new ABMUsuarios();
            if (!string.IsNullOrEmpty(contraseña))
            {
                contraseña = Seguridad.Encriptacion.Encriptador(contraseña);
            }
            DevolverIDs(modUser, idioma, estado);
            modUser.User = usuario;
            modUser.Pass = contraseña;

            cRUD.Modificar(modUser);
        }

        public void DevolverIDs(ABMUsuarios objetoUsuario, string idioma, string estado)
        {
            string idIdio = buscar.DevolvemeElIDQueQuieroPorTexto(idioma, "idioma");
            string idEst = buscar.DevolvemeElIDQueQuieroPorTexto(estado, "estado");
            objetoUsuario.idIdioma = int.Parse(idIdio);
            objetoUsuario.idEstado = int.Parse(idEst);
        }

    }
}
