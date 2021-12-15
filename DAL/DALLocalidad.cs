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
            String query = "SELECT Id_Localidad, Descripcion FROM [Localidad] WHERE Id_Provincia = " + idProv;
            SqlCommand command = new SqlCommand(query, conn.sqlConn);

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
