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
    public class DALLocalidad
    {
        DAL.Conexion conn = new DAL.Conexion();
        public DataTable DameLocalidad(int idProv)
        {
            DataTable dt = new DataTable();
            String query = "SELECT Id_Localidad, Descripcion FROM [Localidad] WHERE Id_Provincia = @id";
            SqlCommand command = new SqlCommand(query, Singleton.Instance.sqlCon);
            command.Parameters.AddWithValue("@id", idProv);

            command.Connection.Open();
            try
            {
                dt.Load(command.ExecuteReader());
            }
            catch (Exception e)
            { }
            command.Connection.Close();
            return dt;
        }
        public int DameIdLocalidad(string localidad)
        {
            int idReturn = 0;
            String query = "SELECT Id_Localidad FROM [Localidad] WHERE Descripcion = @Localidad";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Localidad", localidad);

            try
            {
                idReturn = Singleton.Instance.ExecuteScalar(command);
            }
            catch { }

            return idReturn;
        }
    }
}
