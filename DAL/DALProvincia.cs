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
        DAL.Conexion conn = new DAL.Conexion();
        public DataTable DameProvincias()
        {
            DataTable dt = new DataTable();
            String query = "SELECT Id_Provincia, Descripcion FROM Provincia";
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

        public int DameIdProvincias(string prov)
        {
            int idReturn = 0;
            String query = "SELECT Id_Provincia, Descripcion FROM [Provincia] ";
            SqlCommand command = new SqlCommand(query, conn.sqlConn);

            command.Connection.Open();
            try
            {
                idReturn = int.Parse(command.CommandText);
            }
            catch (Exception e)
            { }
            command.Connection.Close();
            return idReturn;
        }
    }
}
