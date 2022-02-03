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
            SqlCommand command = new SqlCommand(query, conn.sqlConn);
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

            DataTable dt = new DataTable();
            String query = "SELECT Id_Localidad FROM [Localidad] WHERE Descripcion = @Localidad";
            SqlCommand command = new SqlCommand(query, conn.sqlConn);
            command.Parameters.AddWithValue("@Localidad", localidad);

            command.Connection.Open();
            try
            {
                idReturn = int.Parse(command.ExecuteScalar().ToString());
                command.Connection.Close();
            }
            catch { }
            command.Connection.Close();

            return idReturn;
        }
    }
}
