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
        //descontinuado
        public DataTable DameProvincias()
        {
            DataTable dt = new DataTable();
            String query = "SELECT Id_Provincia, Descripcion FROM Provincia";
            SqlCommand command = new SqlCommand(query);

            command.Connection.Open();
            try
            {
                dt.Load(command.ExecuteReader());
            }
            catch 
            { }
            command.Connection.Close();
            return dt;
        }

        // ADO Desconectado
        public int DameIdProvincias(string prov)
        {
            int idReturn = 0;
            String query = "SELECT Id_Provincia FROM [Provincia] WHERE Descripcion = @descripcion";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@descripcion", prov);

            try
            {
                idReturn = Acceso.Instance.ExecuteScalar(command);
            }
            catch { }

            return idReturn;
        }
    }
}
