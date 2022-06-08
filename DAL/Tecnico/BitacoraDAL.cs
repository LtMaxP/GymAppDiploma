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
        public void RegistrarBitacora(string movimiento, string nivelDeProblema, DateTime fecha)
        {
            String query = "INSERT INTO Bitacora (FechaDelMov, Movimiento, NivelDelProblema) VALUES (@FechaMov, @Mov, @NivelDelP)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FechaMov", fecha);
            command.Parameters.AddWithValue("@Mov", movimiento);
            command.Parameters.AddWithValue("@NivelDelP", nivelDeProblema);
            Acceso.Instance.ExecuteNonQuery(command);

        }

        public DataTable TraerBitacora()
        {
            DataSet ds = new DataSet();
            DataTable bitacoraTable;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
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
