using System;
using System.Collections.Generic;
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
    }
}
