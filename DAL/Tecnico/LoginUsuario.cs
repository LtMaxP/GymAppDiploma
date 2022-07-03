﻿using System;
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

        public Boolean DetectarUsuario(string user)
        {
            Boolean returnable = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "select CASE WHEN count(*) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @user;";
            sqlcomm.Parameters.AddWithValue("@user", user);
            try
            {
                returnable = Acceso.Instance.ExecuteScalarBool(sqlcomm);
            }
            catch { System.Windows.Forms.MessageBox.Show("No se encontro el usuario"); }

            return returnable;
        }
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
                GoodUser();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Contraseña erronea");
                BitacoraDAL.NewRegistrarBitacora(new BE.Bitacora("Constraseña mal", "Medio"));
                BadPass();
            }
            return respuesta;
        }

        private void GoodUser()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Update Usuario set IntentosFallidos = 0 where Usuario = '@nombre' ";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);

                Acceso.Instance.ExecuteNonQuery(comm);
            }
            catch { };
        }

        public void BadPass()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Update Usuario set IntentosFallidos = IntentosFallidos +1 where Usuario = '@nombre' ";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.User);

                Acceso.Instance.ExecuteNonQuery(comm);
            }
            catch { };
        }
    }
}
