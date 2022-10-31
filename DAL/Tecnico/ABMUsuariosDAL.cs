using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class ABMUsuariosDAL : ICRUD<BE_Usuario>
    {
        /// <summary>
        /// Alta usuario nuevo
        /// </summary>
        /// <param name="valAlta"></param>
        /// <returns></returns>
        public bool Alta(BE_Usuario valAlta)
        {
            bool ret = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "INSERT INTO Usuario (Usuario.Usuario, Usuario.Password, Usuario.Id_Idioma, Usuario.Id_Estado, Usuario.Palabra_Secreta ) VALUES (@NombreUsuario, @Contraseña, @IdIdioma, @IdEstado, @PSecreta)";
                comm.Parameters.AddWithValue("@NombreUsuario", valAlta.User);
                comm.Parameters.AddWithValue("@Contraseña", valAlta.Pass);
                comm.Parameters.AddWithValue("@IdIdioma", valAlta.Idioma.Id);
                comm.Parameters.AddWithValue("@IdEstado", valAlta.idEstado);
                comm.Parameters.AddWithValue("@PSecreta", valAlta.PSecreta);

                Acceso.Instance.ExecuteNonQuery(comm);
                
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Creacion de usuario: " + valAlta.User, "Ninguno"));
                ret = true;
            }
            catch
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Error en creacion de usuario: " + valAlta.User, "Medio"));
            }
            return ret;
        }
        /// <summary>
        /// Recupero de pass
        /// </summary>
        /// <param name="user"></param>
        public static void RecuperoPass(BE_Usuario user)
        {
            String query = "UPDATE Usuario SET Password = @pass WHERE Id_Usuario = @idUser";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@idUser", user.IdUsuario);
            command.Parameters.AddWithValue("@pass", user.Pass);
            Acceso.Instance.ExecuteNonQuery(command);
        }
        /// <summary>
        /// Busca Id de usuario por UserName y palabra secreta
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static BE_Usuario DameId(BE_Usuario user)
        {
            String query = "SELECT id FROM Usuario WHERE usuario = @user AND Palabra_Secreta = @PSecret";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", user.User);
            command.Parameters.AddWithValue("@PSecret", user.PSecreta);
            user.IdUsuario = Acceso.Instance.ExecuteScalar(command);

            return user;
        }
        /// <summary>
        /// Eliminar el usuario
        /// </summary>
        /// <param name="valBaja"></param>
        /// <returns></returns>
        public bool Baja(BE_Usuario valBaja)
        {
            bool ret = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "UPDATE Usuario SET Id_Estado = @IdEstado WHERE Usuario = @NombreUsuario AND Password = @Pass";
                comm.Parameters.AddWithValue("@NombreUsuario", valBaja.User);
                comm.Parameters.AddWithValue("@Pass", valBaja.Pass);
                comm.Parameters.AddWithValue("@IdEstado", 2);

                int result = Acceso.Instance.ExecuteNonQuery(comm);
                ret = true;
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Baja de usuario: " + valBaja.User, "Ninguno"));
            }
            catch { DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Problema al tratar de dar de baja el Usuario " + valBaja.User, "Medio")); }
            return ret;
        }
        /// <summary>
        /// Traer usuario buscado por nombre
        /// </summary>
        /// <param name="valBuscar"></param>
        /// <returns></returns>
        public BE_Usuario Leer(BE_Usuario valBuscar)
        {
            BE_Usuario UserRet = new BE_Usuario();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT Usuario, Password, Id_Idioma, Id_Estado, Palabra_Secreta FROM Usuario WHERE Usuario.Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", valBuscar.User);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    UserRet.User = dr[0].ToString();
                    UserRet.Pass = dr[1].ToString();
                    UserRet.Idioma = new BE.ObserverIdioma.BE_Idioma();
                    UserRet.Idioma.Id = (int)dr[2];
                    UserRet.idEstado = (int)dr[3];
                    UserRet.PSecreta = dr["Palabra_Secreta"].ToString();
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }

            return UserRet;
        }
        /// <summary>
        /// Traer listado de usuarios por nombre
        /// </summary>
        /// <param name="valBuscar"></param>
        /// <returns></returns>
        public List<BE_Usuario> Leer2(BE_Usuario valBuscar)
        {
            List<BE_Usuario> listUser = new List<BE_Usuario>();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT Usuario, Id_Idioma, Id_Estado FROM Usuario WHERE Usuario.Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", valBuscar.User);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    BE_Usuario user = new BE_Usuario();
                    user.User = dr[0].ToString();
                    user.Idioma = new BE.ObserverIdioma.BE_Idioma();
                    user.Idioma.Id = (int)dr[1];
                    user.idEstado = (int)dr[2];
                    listUser.Add(user);
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }

            return listUser;
        }
        /// <summary>
        /// Devuelve todos los IDs de Usuarios-
        /// </summary>
        /// <returns></returns>
        public List<BE_Usuario> TraerUsuarios()
        {
            List<BE_Usuario> users = new List<BE_Usuario>();
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.CommandText = "SELECT Id_Usuario, Usuario from Usuario";

                DataTable dt = Acceso.Instance.ExecuteDataTable(sqlcomm);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr != null)
                    {
                        BE_Usuario us = new BE_Usuario();
                        us.IdUsuario = (int)dr[0];
                        us.User = dr[1].ToString();
                        users.Add(us);
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un problema al traer los ids de usuarios");
            }
            return users;
        }
        /// <summary>
        /// Listado de usuarios con pass encriptada
        /// </summary>
        /// <returns></returns>
        public static List<BE_Usuario> ListadoUsuarios()
        {
            List<BE_Usuario> users = new List<BE_Usuario>();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT * from Usuario";

            DataTable dt = Acceso.Instance.ExecuteDataTable(sqlcomm);
            BE_Usuario us;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr != null)
                {
                    us = new BE_Usuario();
                    us.IdUsuario = (int)dr["Id_Usuario"];
                    us.User = dr["Usuario"].ToString();
                    us.Pass = dr["Password"].ToString();
                    us._DVH = dr["DVH"].ToString();
                    users.Add(us);
                }
            }

            return users;
        }
        /// <summary>
        /// Modificar usuario con o sin nueva pass
        /// </summary>
        /// <param name="valModificar"></param>
        /// <returns></returns>
        public bool Modificar(BE_Usuario valModificar)
        {
            bool ret = false;
            try
            {
                SqlCommand comm = new SqlCommand();

                if (!string.IsNullOrEmpty(valModificar.Pass))
                {
                    comm.CommandText = "UPDATE Usuario SET Usuario.Password = @Contraseña, Usuario.Id_Idioma = @IdIdioma, Usuario.Id_Estado = @IdEstado, Usuario.Palabra_Secreta = @Palabra_Secreta WHERE Usuario.Usuario = @NombreUsuario";
                    comm.Parameters.AddWithValue("@Contraseña", valModificar.Pass);
                }
                else { comm.CommandText = "UPDATE Usuario SET Usuario.Id_Idioma = @IdIdioma, Usuario.Id_Estado = @IdEstado, Usuario.Palabra_Secreta = @Palabra_Secreta WHERE Usuario.Usuario = @NombreUsuario"; }

                comm.Parameters.AddWithValue("@NombreUsuario", valModificar.User);
                comm.Parameters.AddWithValue("@IdIdioma", valModificar.Idioma.Id);
                comm.Parameters.AddWithValue("@IdEstado", valModificar.idEstado);
                comm.Parameters.AddWithValue("@Palabra_Secreta", valModificar.PSecreta);

                Acceso.Instance.ExecuteNonQuery(comm);
                ret = true;
                if (!string.IsNullOrEmpty(valModificar.Pass))
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Exito al modificar la contraseña y el Usuario " + valModificar.User, "Ninguno"));
                else
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Exito al modificar el Usuario " + valModificar.User, "Ninguno"));
            }
            catch { DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Problema al tratar de modificar el Usuario " + valModificar.User, "Medio")); }
            return ret;
        }
        /// <summary>
        /// Validar que usuario y/o contraseña esten ok
        /// </summary>
        /// <param name="usuari"></param>
        /// <returns></returns>
        public bool ValidarExistenciaDeUsuario(BE_Usuario usuari)
        {
            bool respuesta = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                if (!String.IsNullOrEmpty(usuari.Pass))
                {
                    comm.CommandText = "SELECT CASE WHEN COUNT(1) > 0 THEN 'true' ELSE 'false' END FROM Usuario WHERE Usuario = @nombre AND Password = @Pass";
                    comm.Parameters.AddWithValue("@nombre", usuari.User);
                    comm.Parameters.AddWithValue("@Pass", usuari.Pass);
                }
                else
                {
                    comm.CommandText = "select CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @nombre";
                    comm.Parameters.AddWithValue("@nombre", usuari.User);
                }
                respuesta = Acceso.Instance.ExecuteScalarBool(comm);
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }
            return respuesta;
        }
    }
}
