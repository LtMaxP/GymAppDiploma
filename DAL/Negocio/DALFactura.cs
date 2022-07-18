using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFactura
    {
        /// <summary>
        /// Ejecutar Compra de productos
        /// </summary>
        /// <param name="factura"></param>
        public static void EjecutarCompraDAL(BE.BE_Factura factura)
        {
            try
            {
                //Crea factura
                string query = @"INSERT INTO Factura VALUES(@monto, @fecha, @idCliente)";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@fecha", factura.Fecha);
                command.Parameters.AddWithValue("@monto", factura.Monto);
                command.Parameters.AddWithValue("@idCliente", factura.Id_Cliente);
                Acceso.Instance.ExecuteNonQuery(command);

                //traer id de factura creada
                string query2 = @"SELECT IDENT_CURRENT('[GymApp].[dbo].[Factura]')";
                SqlCommand command2 = new SqlCommand(query2);
                factura.Id_Factura = Acceso.Instance.ExecuteScalar(command2);

                //Crea relacion productos facturas
                foreach (BE.Item itm in factura.Items)
                {
                    //ACA PODRIA IR UN SP Q HAGA TODO 1X1
                    string query3 = @"INSERT INTO Factura_Item VALUES(@idFactura, (select Id_Item from Item where Descripcion = @desc), @cantidad)
                                        UPDATE Item SET Cantidad = (SELECT Cantidad FROM Item WHERE Descripcion = @desc) - @cantidad WHERE Descripcion = @desc";
                    SqlCommand command3 = new SqlCommand(query3);
                    command3.Parameters.AddWithValue("@idFactura", factura.Id_Factura);
                    command3.Parameters.AddWithValue("@cantidad", itm.Cantidad);
                    command3.Parameters.AddWithValue("@desc", itm.Descripcion);
                    Acceso.Instance.ExecuteNonQuery(command3);
                }
                DAL.BitacoraDAL.NewRegistrarBitacora(new BE.Bitacora("Factura " + factura.Id_Factura + " creada al cliente: " + factura.Id_Cliente, "Ninguno"));
            }
            catch
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(new BE.Bitacora("Error al crear factura", "Medio"));
            }
        }
    }
}
