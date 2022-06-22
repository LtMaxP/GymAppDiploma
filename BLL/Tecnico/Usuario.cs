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
            catch (Exception e)
            {
                b.RegistrarMovimiento("Error creando el Usuario: " + altaUser.User, "Alta");
            }


            return rpta;
        }

        public bool EliminarUsuario(string usuario)
        {
            BE_Usuarios bajaUser = new BE_Usuarios();
            bajaUser.User = usuario;

            return abmUs.Baja(bajaUser);
        }

        public bool ModificarUsuario(string usuario, string contraseña, string idioma, string estado)
        {
            BE_Usuarios modUser = new BE_Usuarios();
            if (!string.IsNullOrEmpty(contraseña))
            {
                contraseña = Servicios.Encriptacion.Encriptador(contraseña);
            }
            DevolverIDs(modUser, idioma, estado);
            modUser.User = usuario;
            modUser.Pass = contraseña;

            return abmUs.Modificar(modUser);
        }

        public void DevolverIDs(BE_Usuarios objetoUsuario, string idioma, string estado)
        {
            string idIdio = buscar.DevolvemeElIDQueQuieroPorTexto(idioma, "idioma");
            string idEst = buscar.DevolvemeElIDQueQuieroPorTexto(estado, "estado");
            objetoUsuario.idIdioma = int.Parse(idIdio);
            objetoUsuario.idEstado = int.Parse(idEst);
        }


        public String[] BuscarUsuario(string usuario)
        {
            BE_Usuarios buscarUser = new BE_Usuarios();
            buscarUser.User = usuario;
            string[] rowFix = new string[4];

            DataTable dt = abmUs.Leer(buscarUser);

            if (dt.Rows.Count == 0)
            { System.Windows.Forms.MessageBox.Show("Usuario no encontrado"); }
            else
            {
                DataRow usuarioRow = dt.Rows[0];

                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 2:
                            rowFix[i] = buscar.DevolvemeElValorQueQuieroPorId(usuarioRow.ItemArray[i].ToString(), "idioma");
                            break;
                        case 3:
                            rowFix[i] = buscar.DevolvemeElValorQueQuieroPorId(usuarioRow.ItemArray[i].ToString(), "estado");
                            break;
                        default:
                            rowFix[i] = usuarioRow.ItemArray[i].ToString();
                            break;
                    }
                }

            }
            return rowFix;
        }

        public bool ValidarSiElUsuarioYaExiste(string usuario)
        {
            BE_Usuarios buscarUser = new BE_Usuarios();
            buscarUser.User = usuario;
            return abmUs.ValidarExistenciaDeUsuario(buscarUser);
        }

    }
}
