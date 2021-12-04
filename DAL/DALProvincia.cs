using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProvincia
    {
        Conexion connect = new Conexion();
        public DataTable DameProvincias()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connect.ConexionRuta);
            String query = "SELECT Id_Provincia, Descripcion FROM [Provincia] ";
            SqlCommand command = new SqlCommand(query, connection);

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
