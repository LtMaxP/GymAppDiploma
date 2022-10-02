using BE.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Negocio
{
    public class DALMembresia
    {
        public static List<BE_Membresia> DameMembresias()
        {
            List<BE.Negocio.BE_Membresia> membresias = new List<BE_Membresia>();
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                String query = "SELECT [Id_Membresia], [Descripcion], [monto] FROM [GymApp].[dbo].[Membresia]";
                SqlCommand command = new SqlCommand(query);
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                foreach (DataRow row in dt.Rows)
                {
                    BE_Membresia memb = new BE_Membresia();
                    memb.Id = int.Parse(row["Id_Membresia"].ToString());
                    memb.Descripcion = row["Descripcion"].ToString();
                    memb.Monto = decimal.Parse(row["monto"].ToString());
                    membresias.Add(memb);
                }
            }
            return membresias;
        }

        public static BE_Membresia DameMembresiaPorId(int id)
        {
            BE_Membresia memb = new BE_Membresia();
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                String query = "SELECT [Id_Membresia], [Descripcion], [monto] FROM [GymApp].[dbo].[Membresia] WHERE [Id_Membresia] = @id";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@id", id);
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                foreach (DataRow row in dt.Rows)
                {
                    memb.Id = int.Parse(row["Id_Membresia"].ToString());
                    memb.Descripcion = row["Descripcion"].ToString();
                    memb.Monto = decimal.Parse(row["monto"].ToString());
                }
            }
            return memb;
        }
    }
}
