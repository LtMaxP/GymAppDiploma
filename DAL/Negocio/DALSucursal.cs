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
        public DataTable DameSucursal(int idLoc)
        {
            DataTable dt = new DataTable();
            String query = "SELECT Id_Sucursal, Descripcion FROM [Sucursal] WHERE Id_Localidad = @id";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            command.Parameters.AddWithValue("@id", idLoc);

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

        public DataTable DameLocacionTotalSucursal(int idCliente)
        {
            DataTable dt = new DataTable();
            String query = "select * from [dbo].[DameTodoSucursalaProvincia](@id)";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            command.Parameters.AddWithValue("@id", idCliente);

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

        public int DameIdSucursal(string sucursal)
        {
            int idReturn = 0;
            String query = "SELECT id_Sucursal FROM Sucursal where Descripcion = @Sucursal";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Sucursal", sucursal);
            try
            {
                idReturn = Convert.ToInt32(Acceso.Instance.ExecuteScalar(command));
            }
            catch { }
            return idReturn;

        }
    }
}
