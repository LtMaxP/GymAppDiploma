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

            using (Acceso.Instance.sqlCon)
            {
                String query = "INSERT INTO Bitacora (FechaDelMov, Movimiento, NivelDelProblema) VALUES (@FechaMov, @Mov, @NivelDelP)";
                SqlCommand command = new SqlCommand(query);

                command.Parameters.AddWithValue("@FechaMov", fecha);
                command.Parameters.AddWithValue("@Mov", movimiento);
                command.Parameters.AddWithValue("@NivelDelP", nivelDeProblema);
                Acceso.Instance.sqlCon.Open();
                int result = command.ExecuteNonQuery();

            }
        }

        public DataTable TraerBitacora()
        {
            DataSet ds = new DataSet();
            DataTable bitacoraTable;
            using (Acceso.Instance.sqlCon)
            {

                String query = "SELECT FechaDelMov, Movimiento, NivelDelProblema FROM Bitacora";
                SqlCommand command = new SqlCommand(query);

                SqlDataAdapter da = new SqlDataAdapter(command);
                Acceso.Instance.sqlCon.Open();
                da.Fill(ds);

            }

            bitacoraTable = ds.Tables[0];
            return bitacoraTable;
        }
    }
}
