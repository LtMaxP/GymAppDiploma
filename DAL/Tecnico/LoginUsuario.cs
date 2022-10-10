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
        public bool BuscarUsuarioBD()
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT [Id_Usuario] FROM Usuario WHERE usuario.Usuario=@User AND Usuario.Password=@Pass";

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "User";
            param1.Value = Usuario.Instance.User;
            param1.SqlDbType = System.Data.SqlDbType.VarChar;

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "Pass";
            param2.Value = Usuario.Instance.Pass;
            param2.SqlDbType = System.Data.SqlDbType.VarChar;

            sqlcomm.Parameters.Add(param1);
            sqlcomm.Parameters.Add(param2);

            try
            {
                Usuario.Instance.IdUsuario = Acceso.Instance.ExecuteScalar(sqlcomm);
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }
        /// <summary>
        /// Valida si el usuario existe
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Boolean DetectarUsuario()
        {
            Boolean returnable = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "select CASE WHEN count(*) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @user;";
            sqlcomm.Parameters.AddWithValue("@user", BE.Usuario.Instance.User);
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
        public Boolean LoginUser()
        {
            bool respuesta = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "select CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @nombre and Password = @pass";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);
                comm.Parameters.AddWithValue("@pass", BE.Usuario.Instance.Pass);

                respuesta = Acceso.Instance.ExecuteScalarBool(comm);
                if (respuesta)
                {
                    GoodUser();
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Inicio de sesión por el usuario " + BE.Usuario.Instance.User, "Ninguno"));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Contraseña erronea");
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Constraseña erronea usuario " + BE.Usuario.Instance.User, "Medio"));
                    BadPass();
                }
            }
            catch { }
            return respuesta;
        }

        private void GoodUser()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Update Usuario set IntentosFallidos = 0, Id_Estado = 1 where Usuario = @nombre ";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);
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
                    BE.Usuario.Instance.User = user.User;
                    validacion = true;
                    GoodUser();
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Desbloqueado el usuario " + BE.Usuario.Instance.User, "Bajo"));
                }
            }
            catch { };
            return validacion;
        }



        private void BadPass()
        {
            if (GetIntentosFallidos() > 3)
            {
                try
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "Update Usuario set Id_Estado = 2 where Usuario = @nombre ";
                    comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);
                    Acceso.Instance.ExecuteNonQuery(comm);
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Bloqueo por intentos fallidos del usuario " + BE.Usuario.Instance.User, "Alto"));
                }
                catch { };
            }
            else
            {
                try
                {
                    SqlCommand comm = new SqlCommand();
                    comm.CommandText = "Update Usuario set IntentosFallidos = IntentosFallidos +1 where Usuario = @nombre ";
                    comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);
                    Acceso.Instance.ExecuteNonQuery(comm);
                }
                catch { };
            }
        }

        /// <summary>
        /// Devuelve la cantidad de intentos fallidos del usuario
        /// </summary>
        /// <returns></returns>
        public int GetIntentosFallidos()
        {
            int result = 0;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT IntentosFallidos FROM Usuario WHERE Usuario = @nombre ";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);

                result = Acceso.Instance.ExecuteScalar(comm);
            }
            catch { };

            return result;
        }
        /// <summary>
        /// Validar si esta bloqueado
        /// </summary>
        /// <returns></returns>
        public bool ValidarBloqueo()
        {
            bool result = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "select CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @nombre and Id_Estado = 1 and IntentosFallidos <= 3";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);

                result = Acceso.Instance.ExecuteScalarBool(comm);
            }
            catch { };

            return result;
        }
    }
}
