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
            String query = "SELECT Id_Sucursal, Descripcion FROM [Sucursal] WHERE Id_Localidad = @id";
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

        public DataTable DameLocacionTotalSucursal(int idCliente)
        {
            DataTable dt = new DataTable();
            String query = "select * from [dbo].[DameTodoSucursalaProvincia](@id)";
            SqlCommand command = new SqlCommand(query, conn.sqlConn);
            command.Parameters.AddWithValue("@id", idCliente);

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

        public int DameIdSucursal(string sucursal)
        {
            int idReturn = 0;
            ///////////////////////////////////////////// la q sería de id     

            DataTable dt = new DataTable();
            String query = "SELECT id_Sucursal FROM Sucursal where Descripcion = @Sucursal";
            //SqlCommand command = new SqlCommand(query, Singleton.Instance.ConexionRuta);
            SqlDataAdapter sqlAdap = new SqlDataAdapter(query, Singleton.Instance.ConexionRuta);
            sqlAdap.SelectCommand.Parameters.AddWithValue("@Sucursal", sucursal);
            //command.Parameters.AddWithValue("@Sucursal", sucursal);

            sqlAdap.SelectCommand.Connection.Open();
            try
            {
                idReturn = int.Parse(sqlAdap.SelectCommand.ExecuteScalar().ToString());
            }
            catch { }
            sqlAdap.SelectCommand.Connection.Close();
            //command.Connection.Close();

            return idReturn;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //DataTable dt = new DataTable();
            //String query = "select * from Empleado where id_Sucursal = @id";

            //SqlDataAdapter sqlAdap = new SqlDataAdapter(query, Singleton.Instance.ConexionRuta);
            //sqlAdap.SelectCommand.Parameters.AddWithValue("@id", id_Sucursal);
            ////SqlCommandBuilder command = new SqlCommandBuilder(sqlAdap);

            //try
            //{
            //    sqlAdap.Fill(dt);
            //    //dt.Load(sqlAdap.Fill());
            //    //dt.Load(command.ExecuteReader());
            //}
            //catch (Exception e)
            //{ }

            //return dt;

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //return idReturn;
        }
    }
}
