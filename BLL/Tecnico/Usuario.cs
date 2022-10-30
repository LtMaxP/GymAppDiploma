using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Usuario
    {
        DAL.ABMUsuariosDAL abmUs = new DAL.ABMUsuariosDAL();
        DAL.IdiomaT idiomaDal = new DAL.IdiomaT();

        /// <summary>
        /// Crea el objeto BE_Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="idioma"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool AgregarUsuario(BE_Usuario altaUser)
        {
            altaUser.Pass = Servicios.Encriptacion.Encriptador(altaUser.Pass);
            altaUser.Idioma = idiomaDal.DameIdIdioma(altaUser.Idioma);
            if (abmUs.Alta(altaUser))
            {
                BLL.DV.RecalcularDigitosVerificadores();
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Eliminar Usuario
        /// </summary>
        /// <param name="bajaUser"></param>
        /// <returns></returns>
        public bool EliminarUsuario(BE_Usuario bajaUser)
        {
            bool retornableComoCocaCola = abmUs.Baja(bajaUser);
            return retornableComoCocaCola;
        }
        /// <summary>
        /// Modificar Usuario, si se desea modificar la contraseña, enviarla también
        /// </summary>
        /// <param name="modUser"></param>
        /// <returns></returns>
        public bool ModificarUsuario(BE_Usuario modUser)
        {
            if (!String.IsNullOrEmpty(modUser.Pass))
                modUser.Pass = Servicios.Encriptacion.Encriptador(modUser.Pass);

            modUser.Idioma = idiomaDal.DameIdIdioma(modUser.Idioma);
            if (abmUs.Modificar(modUser))
            {
                BLL.DV.RecalcularDigitosVerificadores();
                return true;
            }
            else
                return false;
        }

        //Traer listado de todos los Usuarios con sus IDs
        public List<BE_Usuario> TraerUsuarios()
        {
            return abmUs.TraerUsuarios();
        }

        /// <summary>
        /// Buscar el o los usuarios bajo el mismo nombre
        /// </summary>
        /// <param name="buscarUser"></param>
        /// <returns></returns>
        public List<BE_Usuario> BuscarUsuario(BE_Usuario buscarUser)
        {
            return abmUs.Leer2(buscarUser);
        }

        public BE_Usuario MostrarUsuario(BE_Usuario buscarUser)
        {
            return abmUs.Leer(buscarUser);
        }

        /// <summary>
        /// Validar usuario y pass
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarUsuarioyPass(BE_Usuario buscarUser)
        {
            buscarUser.Pass = Servicios.Encriptacion.Encriptador(buscarUser.Pass);
            return abmUs.ValidarExistenciaDeUsuario(buscarUser);
        }

        /// <summary>
        /// Validar existencia del nombre de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarSiElUsuarioYaExiste(BE_Usuario buscarUser)
        {
            return abmUs.ValidarExistenciaDeUsuario(buscarUser);
        }
    }
}
