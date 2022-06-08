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
        private BE.Usuario userBE = BE.Usuario.Instance;

        public bool BuscarUsuarioBD(string user, string pass)
        {
            
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT * FROM Usuario WHERE usuario.Usuario=@User AND Usuario.Password=@Pass";

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
            int i = 0;
            try
            {
                i = Acceso.Instance.ExecuteScalar(sqlcomm);
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }

        public Boolean DetectarUsuario(string user, string pass)
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT * FROM Usuario";
            //sqlcomm.Connection = Acceso.Instance.sqlCon;

            //DataSet ds = new DataSet();
            //SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
            //sqlcomm.Connection.Open();

            //da.Fill(ds);
            //sqlcomm.Connection.Close();

            DataTable dt = new DataTable();
            dt = Acceso.Instance.ExecuteDataTable(sqlcomm);
            foreach (DataRow row in dt.Rows)
            {
                if (row["Usuario"].ToString().Equals(user) && row["Password"].ToString().Equals(pass))
                {
                    userBE.User = row["Usuario"].ToString();
                    userBE.Pass = row["Password"].ToString();
                    userBE.IdUsuario = int.Parse(row["Id_Usuario"].ToString());
                    userBE.idIdioma = int.Parse(row["Id_Idioma"].ToString());
                    userBE.idEstado = int.Parse(row["Id_Estado"].ToString()); 
                    return true;
                }
            }

            return false;
        }
    }
}
