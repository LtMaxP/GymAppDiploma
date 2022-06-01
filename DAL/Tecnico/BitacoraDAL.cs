using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraDAL 
    {
        DAL.Conexion connect = new DAL.Conexion();
        public void RegistrarBitacora(string movimiento, string nivelDeProblema, DateTime fecha)
        {

            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "INSERT INTO Bitacora (FechaDelMov, Movimiento, NivelDelProblema) VALUES (@FechaMov, @Mov, @NivelDelP)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FechaMov", fecha);
                    command.Parameters.AddWithValue("@Mov", movimiento);
                    command.Parameters.AddWithValue("@NivelDelP", nivelDeProblema);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                }
            }
        }

        public DataTable TraerBitacora()
        {
            DataSet ds = new DataSet();
            DataTable bitacoraTable;
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {

                String query = "SELECT FechaDelMov, Movimiento, NivelDelProblema FROM Bitacora";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    connection.Open();
                    da.Fill(ds);
                }
            }

            bitacoraTable = ds.Tables[0];
            return bitacoraTable;
        }
    }
}
