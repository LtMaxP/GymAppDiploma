using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{
    public class LoginUsuario
    {
        /// <summary>
        /// Cargar id_Usuario 
        /// </summary>
        /// <returns></returns>
        public bool BuscarUsuarioBD()
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT [Id_Usuario] FROM Usuario WHERE usuario.Usuario=@User AND Usuario.Password=@Pass";
            
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "User";
            param1.Value = Servicios.Sesion.GetInstance.usuario.User;
            param1.SqlDbType = System.Data.SqlDbType.VarChar;

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "Pass";
            param2.Value = Servicios.Sesion.GetInstance.usuario.Pass;
            param2.SqlDbType = System.Data.SqlDbType.VarChar;

            sqlcomm.Parameters.Add(param1);
            sqlcomm.Parameters.Add(param2);

            try
            {
                Servicios.Sesion.GetInstance.usuario.IdUsuario = Acceso.Instance.ExecuteScalar(sqlcomm);
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }
        /// <summary>
        /// Valida si el usuario existe y especialmente sin bloqueo
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Boolean DetectarUsuario(BE_Usuario usuario)
        {
            Boolean returnable = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario WHERE Usuario = @user";
            sqlcomm.Parameters.AddWithValue("@user", usuario.User);
            try
            {
                returnable = Acceso.Instance.ExecuteScalarBool(sqlcomm);
            }
            catch { }

            return returnable;
        }
        /// <summary>
        /// Detectar user y pass resetea o suma 1 a intentos fallidos
        /// </summary>
        /// <returns></returns>
        public Boolean LoginUser(BE_Usuario usuario)
        {
            bool respuesta = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario WHERE Usuario = @user AND Password = @pass AND Id_Estado = 1 AND IntentosFallidos <= 3";
                comm.Parameters.AddWithValue("@user", usuario.User);
                comm.Parameters.AddWithValue("@pass", usuario.Pass);

                respuesta = Acceso.Instance.ExecuteScalarBool(comm);
                if (respuesta)
                {
                    GoodUser(usuario);
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Inicio de sesión por el usuario " + usuario.User, "Ninguno"));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Contraseña erronea");
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Constraseña erronea usuario " + usuario.User, "Medio"));
                    BadPass(usuario);
                }
            }
            catch { }
            return respuesta;
        }
        /// <summary>
        /// Si se logeo, volver a 0 intentos fallidos
        /// </summary>
        /// <param name="usuario"></param>
        private void GoodUser(BE_Usuario usuario)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Update Usuario set IntentosFallidos = 0, Id_Estado = 1 where Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", usuario.User);
                Acceso.Instance.ExecuteNonQuery(comm);
            }
            catch { };
        }
        /// <summary>
        /// Validar por pregunta si el usuario se desbloquea
        /// </summary>
        public bool ValidacionPalabraSecreta(BE.BE_Usuario user)
        {
            bool validacion = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "select CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END FROM Usuario WHERE Usuario = @user AND [Palabra_Secreta] = @palabra ";
                comm.Parameters.AddWithValue("@palabra", user.PSecreta);
                comm.Parameters.AddWithValue("@user", user.User);
                if (Acceso.Instance.ExecuteScalarBool(comm))
                {
                    comm.CommandText = "Update Usuario set IntentosFallidos = 0, Id_Estado = 1 where Usuario = @nombre AND [Palabra_Secreta] = @palabra";
                    Acceso.Instance.ExecuteNonQuery(comm);
                    validacion = true;
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Desbloqueado el usuario " + user.User, "Bajo"));
                }
            }
            catch { };
            return validacion;
        }
        /// <summary>
        /// Bloquear si supera 3 intentos fallidos
        /// </summary>
        /// <param name="usuario"></param>
        private void BadPass(BE.BE_Usuario usuario)
        {
            if (GetIntentosFallidos(usuario) > 3)
            {
                try
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "Update Usuario set Id_Estado = 2 where Usuario = @nombre";
                    comm.Parameters.AddWithValue("@nombre", usuario.User);
                    Acceso.Instance.ExecuteNonQuery(comm);
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Bloqueo por intentos fallidos del usuario " + Servicios.Sesion.GetInstance.usuario.User, "Alto"));
                }
                catch { };
            }
            else
            {
                try
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "Update Usuario set IntentosFallidos = IntentosFallidos +1 where Usuario = @nombre AND Password = @pass ";
                    comm.Parameters.AddWithValue("@nombre", usuario.User);
                    comm.Parameters.AddWithValue("@pass", usuario.Pass);
                    Acceso.Instance.ExecuteNonQuery(comm);
                }
                catch { };
            }
        }
        /// <summary>
        /// Devuelve la cantidad de intentos fallidos del usuario
        /// </summary>
        /// <returns></returns>
        public int GetIntentosFallidos(BE.BE_Usuario usuario)
        {
            int result = 0;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT IntentosFallidos FROM Usuario WHERE Usuario = @nombre AND Password = @pass ";
                comm.Parameters.AddWithValue("@nombre", usuario.User);
                comm.Parameters.AddWithValue("@pass", usuario.Pass);
                result = Acceso.Instance.ExecuteScalar(comm);
            }
            catch { };

            return result;
        }
    }
}
