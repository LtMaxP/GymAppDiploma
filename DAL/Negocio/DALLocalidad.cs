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
        //DESCONTINUADO
        public DataTable DameLocalidad(int idProv)
        {
            DataTable dt = new DataTable();
            String query = "SELECT Id_Localidad, Descripcion FROM [Localidad] WHERE Id_Provincia = @id";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            command.Parameters.AddWithValue("@id", idProv);

            dt = Acceso.Instance.ExecuteDataTable(command);
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
                idReturn = Acceso.Instance.ExecuteScalar(command);
            }
            catch { }

            return idReturn;
        }
    }
}
