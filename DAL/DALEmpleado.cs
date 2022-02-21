using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALEmpleado
    {
        
        public DataTable DameEmpleados(int id_Sucursal)
        {
            DataTable dt = new DataTable();
            String query = "select * from Empleado where id_Sucursal = @id";

            SqlDataAdapter sqlAdap = new SqlDataAdapter(query, Singleton.Instance.ConexionRuta);
            sqlAdap.SelectCommand.Parameters.AddWithValue("@id", id_Sucursal);
            //SqlCommandBuilder command = new SqlCommandBuilder(sqlAdap);

            try
            {
                sqlAdap.Fill(dt);
                //dt.Load(sqlAdap.Fill());
                //dt.Load(command.ExecuteReader());
            }
            catch (Exception e)
            { }

            return dt;
        }
    }
}
