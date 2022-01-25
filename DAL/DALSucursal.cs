using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALSucursal
    {
        DAL.Conexion conn = new DAL.Conexion();
        public DataTable DameSucursal(int idLoc)
        {
            DataTable dt = new DataTable();
            String query = "SELECT Id_Sucursal, Descripcion FROM [Localidad] WHERE Id_Localidad = @id";
            SqlCommand command = new SqlCommand(query, conn.sqlConn);
            command.Parameters.AddWithValue("@id", idLoc);

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
    }
}
