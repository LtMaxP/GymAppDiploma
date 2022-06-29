using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Usuario //: DAL.ICRUD<BE.ABMUsuarios> Esto tiene que ser así, arregl
    {

        DAL.BusquedaDAL buscar = new DAL.BusquedaDAL();
        DAL.ABMUsuariosDAL abmUs = new DAL.ABMUsuariosDAL();
        BitacoraBLL b = new BitacoraBLL();

        /// <summary>
        /// Crea el objeto BE_Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="idioma"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public bool AgregarUsuario(BE_Usuarios altaUser)
        {
            altaUser.Pass = Servicios.Encriptacion.Encriptador(altaUser.Pass);
            altaUser._DVH = Servicios.DigitoVerificadorHV.CrearDVH(altaUser);
            bool rpta = false;
            //recalcular DVV
            try
            {

                rpta = abmUs.Alta(altaUser);
                //Servicios.BitacoraServicio
                b.RegistrarMovimiento("Creacion exitosa de Usuario: " + altaUser.User, "Ninguno");
            }
            catch
            {
                b.RegistrarMovimiento("Error creando el Usuario: " + altaUser.User, "Alta");
            }


            return rpta;
        }

        public bool EliminarUsuario(BE_Usuarios bajaUser)
        {
            bool retornableComoCocaCola = false;
            bajaUser.Pass = Servicios.Encriptacion.Encriptador(bajaUser.Pass);
            retornableComoCocaCola = abmUs.Baja(bajaUser);
            return retornableComoCocaCola;
        }

        public bool ModificarUsuario(BE_Usuarios modUser, string idioma, string estado)
        {
            modUser.Pass = Servicios.Encriptacion.Encriptador(modUser.Pass);
            DevolverIDs(modUser, idioma, estado);
            modUser._DVH = Servicios.DigitoVerificadorHV.CrearDVH(modUser);
            return abmUs.Modificar(modUser);
        }

        public void DevolverIDs(BE_Usuarios objetoUsuario, string idioma, string estado)
        {
            string idIdio = buscar.DevolvemeElIDQueQuieroPorTexto(idioma, "idioma");
            string idEst = buscar.DevolvemeElIDQueQuieroPorTexto(estado, "estado");
            objetoUsuario.idIdioma = int.Parse(idIdio);
            objetoUsuario.idEstado = int.Parse(idEst);
        }


        public List<BE_Usuarios> BuscarUsuario(BE_Usuarios buscarUser)
        {
            List<BE_Usuarios> dt = abmUs.Leer2(buscarUser);
            return dt;
            //if (dt.Count == 0)
            //{ System.Windows.Forms.MessageBox.Show("Usuario no encontrado"); }
            //else
            //{
            //    DataRow usuarioRow = dt.Rows[0];

            //    for (int i = 0; i < 4; i++)
            //    {
            //        switch (i)
            //        {
            //            case 2:
            //                rowFix[i] = buscar.DevolvemeElValorQueQuieroPorId(usuarioRow.ItemArray[i].ToString(), "idioma");
            //                break;
            //            case 3:
            //                rowFix[i] = buscar.DevolvemeElValorQueQuieroPorId(usuarioRow.ItemArray[i].ToString(), "estado");
            //                break;
            //            default:
            //                rowFix[i] = usuarioRow.ItemArray[i].ToString();
            //                break;
            //        }
            //    }

            //}

        }
        public BE_Usuarios MostrarUsuario(BE_Usuarios buscarUser)
        {
            BE_Usuarios dt = abmUs.Leer(buscarUser);
            return dt;
        }
        public bool ValidarSiElUsuarioYaExiste(string usuario)
        {
            BE_Usuarios buscarUser = new BE_Usuarios();
            buscarUser.User = usuario;
            return abmUs.ValidarExistenciaDeUsuario(buscarUser);
        }

    }
}
