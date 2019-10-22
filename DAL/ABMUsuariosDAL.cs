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

    public class ABMUsuariosDAL : ICRUD<BE.ABMUsuarios>
    {
        DAL.Conexion conn = new DAL.Conexion();
        public void Alta(ABMUsuarios valAlta)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn.sqlConn;

                comm.CommandText = "INSERT INTO Usuario (Usuario.Usuario, Usuario.Password, Usuario.Id_Idioma, Usuario.Id_Estado, Usuario.Rol ) VALUES (@NombreUsuario, @Contraseña, @IdIdioma, @IdEstado, @Rol"; //INSERT INTO Usuario (Usuario.Usuario, Usuario.Password, Usuario.Id_Idioma, Usuario.Id_Estado, Usuario.Rol ) VALUES ('Pepe','123123','1','1', 'Prueba')

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@NombreUsuario";
                parameter1.Value = valAlta.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@Contraseña";
                parameter2.Value = valAlta.Pass;
                parameter2.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@IdIdioma";
                parameter3.Value = valAlta.idIdioma;
                parameter3.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@IdEstado";
                parameter4.Value = valAlta.idEstado;
                parameter4.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter5 = new SqlParameter();
                parameter5.ParameterName = "@Rol";
                parameter5.Value = valAlta.rol;
                parameter5.SqlDbType = System.Data.SqlDbType.VarChar;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter2);
                comm.Parameters.Add(parameter3);
                comm.Parameters.Add(parameter4);
                comm.Parameters.Add(parameter5);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta al Usuario."); }
        }



        public void Baja(ABMUsuarios valBaja)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn.sqlConn;

                comm.CommandText = "UPDATE Usuario SET Usuario.Id_Estado = @IdEstado WHERE Usuario.Usuario = @NombreUsuario";

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@NombreUsuario";
                parameter1.Value = valBaja.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@IdEstado";
                parameter4.Value = "2";
                parameter4.SqlDbType = System.Data.SqlDbType.Int;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter4);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta al Usuario."); }
        }


        public DataTable Leer(ABMUsuarios valBuscar)
        {
            DataTable dt = new DataTable();
            try
            {
                
                DataSet ds = new DataSet();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn.sqlConn;
                comm.CommandText = "SELECT Id_Usuario, Usuario, Id_Idioma, Id_Estado FROM Usuario WHERE Usuario.Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", valBuscar.User);
                SqlDataAdapter da = new SqlDataAdapter(comm);

                comm.Connection.Open();
                da.Fill(ds);
                comm.Connection.Close();
                dt = ds.Tables[0];
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }

            
            return dt;
        }

        public void Modificar(ABMUsuarios valModificar)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn.sqlConn;

                if (!string.IsNullOrEmpty(valModificar.Pass))
                {
                    comm.CommandText = "UPDATE Usuario SET Usuario.Password = @Contraseña, Usuario.Id_Idioma = @IdIdioma, Usuario.Id_Estado = @IdEstado, Usuario.Rol = @Rol WHERE Usuario.Usuario = @NombreUsuario";

                    SqlParameter parameter2 = new SqlParameter();
                    parameter2.ParameterName = "@Contraseña";
                    parameter2.Value = valModificar.Pass;
                    parameter2.SqlDbType = System.Data.SqlDbType.VarChar;
                    comm.Parameters.Add(parameter2);
                }
                else { comm.CommandText = "UPDATE Usuario SET Usuario.Id_Idioma = @IdIdioma, Usuario.Id_Estado = @IdEstado, Usuario.Rol = @Rol WHERE Usuario.Usuario = @NombreUsuario"; }

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@NombreUsuario";
                parameter1.Value = valModificar.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@IdIdioma";
                parameter3.Value = valModificar.idIdioma;
                parameter3.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@IdEstado";
                parameter4.Value = valModificar.idEstado;
                parameter4.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter5 = new SqlParameter();
                parameter5.ParameterName = "@Rol";
                parameter5.Value = valModificar.rol;
                parameter5.SqlDbType = System.Data.SqlDbType.VarChar;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter3);
                comm.Parameters.Add(parameter4);
                comm.Parameters.Add(parameter5);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta al Usuario."); }
        }

        public bool ValidarExistenciaDeUsuario(string user)
        {
            bool respuesta = false;
            try
            {

                DataSet ds = new DataSet();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn.sqlConn;
                comm.CommandText = "select CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", user);
                SqlDataAdapter da = new SqlDataAdapter(comm);

                comm.Connection.Open();
                respuesta = bool.Parse(comm.ExecuteScalar().ToString());
                comm.Connection.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de Leer la tabla."); }
            return respuesta;
        }


    }
}
