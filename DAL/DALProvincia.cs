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

        // ADO Desconectado
        public int DameIdProvincias(string prov)
        {
            int idReturn = 0;
            SqlCommand command = new SqlCommand();

            command.Connection = conn.sqlConn;
            command.CommandText = "SELECT Id_Provincia FROM [Provincia] WHERE Descripcion = @descripcion";
            command.Parameters.AddWithValue("@descripcion", prov);
            try { 
            command.Connection.Open();
            idReturn = int.Parse(command.ExecuteScalar().ToString());
            command.Connection.Close();
            }
            catch { }
            return idReturn;
        }
    }
}
