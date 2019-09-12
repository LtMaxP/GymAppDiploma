using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class LoginUsuario
    {
        Conexion conn = new Conexion();
        public bool BuscarUsuarioBD(string user, string pass)
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT * FROM Usuario WHERE usuario.Usuario=@User AND Usuario.Password=@Pass";
            sqlcomm.Connection = conn.sqlConn;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "User";
            param1.Value = user;
            param1.SqlDbType = System.Data.SqlDbType.VarChar;

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "Pass";
            param2.Value = pass;
            param2.SqlDbType = System.Data.SqlDbType.VarChar;

            sqlcomm.Parameters.Add(param1);
            sqlcomm.Parameters.Add(param2);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
            conn.Conectar();

            da.Fill(ds);
            conn.Desconectar();
            return true;
        }

        public Boolean DetectarUsuario(string user, string pass)
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT * FROM Usuario ";
            sqlcomm.Connection = conn.sqlConn;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
            conn.Conectar();

            da.Fill(ds);
            conn.Desconectar();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["Usuario"].ToString().Equals(user) && row["Password"].ToString().Equals(pass))
                {
                    return true;
             
                }
            }
                
                return false;
        }
    }
}
