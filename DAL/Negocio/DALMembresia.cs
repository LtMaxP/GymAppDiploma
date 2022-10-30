using BE;
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
            return membresias;
        }

        public static BE_Membresia DameMembresiaPorId(int id)
        {
            BE_Membresia memb = new BE_Membresia();
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
            return memb;
        }

        public static bool ValidarFaltaPago()
        {
            throw new NotImplementedException();
        }

        public static bool EjecutarPago(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public static List<BE_Cuenta> DamePagosCliente(Cliente client)
        {
            List<BE_Cuenta> pagos = new List<BE_Cuenta>();
            String query = "  SELECT [PagoFecha], [monto] FROM [dbo].[Cuenta_Pago] CP INNER JOIN [ClienteGYM] CG on CP.Id_Cuenta = CG.Id_Cuenta WHERE CG.Dni = @dni";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@dni", client.Dni);
            DataTable dt = Acceso.Instance.ExecuteDataTable(command);
            foreach (DataRow row in dt.Rows)
            {
                BE_Cuenta pago = new BE_Cuenta();
                pago.FechaPago = DateTime.Parse(row["PagoFecha"].ToString());
                pago.Monto = double.Parse(row["monto"].ToString());
                pagos.Add(pago);
            }
            return pagos;
        }
    }
}
