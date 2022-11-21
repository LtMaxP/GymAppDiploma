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
        /// <summary>
        /// Devuelve todas las membresias
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Devuelve detalle de membresia por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Validacion si ya esta pago
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool ValidarFaltaPago(BE.Cliente cliente)
        {
            SqlCommand command = Acceso.Instance.CrearCommandStoredProcedureReturnBool("ValidarUltimoPago");
            command.Parameters.AddWithValue("@Dni", cliente.Dni);
            return Acceso.Instance.ExecuteSPWithReturnableBool(command);
        }
        /// <summary>
        /// Efectuar Pago
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool EjecutarPago(Cliente cliente)
        {
            bool returnable = false;
            try
            {
                SqlCommand command = Acceso.Instance.CrearCommandStoredProcedure("EjecutarPago");//ver el descuento
                command.Parameters.AddWithValue("@Dni", cliente.Dni);
                Acceso.Instance.ExecuteNonQuery(command);
                returnable = true;
            }
            catch
            { }
            return returnable;
        }
        /// <summary>
        /// Devolver pagos realizados por dni de cliente
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static List<BE_Cuenta> DamePagosCliente(Cliente client)
        {
            List<BE_Cuenta> pagos = new List<BE_Cuenta>();
            String query = "SELECT F.fecha,F.monto,C.Id_Cuenta,C.Id_Estado,C.FechaInicio  FROM [dbo].[Cuenta_Factura] CF INNER JOIN [Cuenta] C ON C.[Id_Cuenta] = CF.[Id_Cuenta] INNER JOIN Factura F ON CF.Id_Factura = F.Id_Factura INNER JOIN [ClienteGYM] CG on C.Id_Cuenta = CG.Id_Cuenta WHERE CG.Dni = @dni";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@dni", client.Dni);
            DataTable dt = Acceso.Instance.ExecuteDataTable(command);
            foreach (DataRow row in dt.Rows)
            {
                BE_Cuenta pago = new BE_Cuenta();
                pago.FechaPago = DateTime.Parse(row["fecha"].ToString());
                pago.Monto = double.Parse(row["monto"].ToString());
                pago.Id_Cuenta = int.Parse(row["Id_Cuenta"].ToString());
                pago.Id_Estado = int.Parse(row["Id_Estado"].ToString());
                pago.FechaInicio = DateTime.Parse(row["FechaInicio"].ToString());
                pagos.Add(pago);
            }
            return pagos;
        }
    }
}
