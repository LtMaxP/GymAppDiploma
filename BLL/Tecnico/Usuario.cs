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
            altaUser._DVH = Servicios.DigitoVerificadorHV.CrearDVH(altaUser);
            altaUser.Idioma = idiomaDal.DameIdIdioma(altaUser.Idioma);
            return abmUs.Alta(altaUser);
        }

        public bool EliminarUsuario(BE_Usuario bajaUser)
        {
            bool retornableComoCocaCola = false;
            bajaUser.Pass = Servicios.Encriptacion.Encriptador(bajaUser.Pass);
            retornableComoCocaCola = abmUs.Baja(bajaUser);
            return retornableComoCocaCola;
        }

        public bool ModificarUsuario(BE_Usuario modUser)
        {
            if (!String.IsNullOrEmpty(modUser.Pass))
                modUser.Pass = Servicios.Encriptacion.Encriptador(modUser.Pass); //stand by

            modUser.Idioma = idiomaDal.DameIdIdioma(modUser.Idioma);
            modUser._DVH = Servicios.DigitoVerificadorHV.CrearDVH(modUser);
            return abmUs.Modificar(modUser);
        }

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
        /// Validar existencia del nombre de usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarSiElUsuarioYaExiste(string usuario)
        {
            BE_Usuario buscarUser = new BE_Usuario();
            buscarUser.User = usuario;
            return abmUs.ValidarExistenciaDeUsuario(buscarUser);
        }

    }
}
