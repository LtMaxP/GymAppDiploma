using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class DALEmpleado
    {
        
        public DataTable DameEmpleados(int id_Sucursal)
        {
            DataTable dt = new DataTable();
            String query = "select * from Empleado where id_Sucursal = @id";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            command.Parameters.AddWithValue("@id", id_Sucursal);

            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }
    }
}
