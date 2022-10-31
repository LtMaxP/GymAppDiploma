using BE;
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
                //Begin transaction
                Acceso.Instance.ComenzarTransaccion();
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

                    //Grabar historico CC
                    DAL.Tecnico.ControlCambiosDAL.GrabarHistoricoCC(new BE.Tecnico.ControlCambio(itm.Id_Item, itm.Valor, itm.Cantidad, itm.Descripcion, "Compra Factura " + factura.Id_Factura, 99));
                }
                Acceso.Instance.ConfirmarTransaccion();
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Factura " + factura.Id_Factura + " creada al cliente: " + factura.Id_Cliente, "Ninguno"));
            }
            catch
            {
                Acceso.Instance.CancelarTransaccion();
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Error al crear factura", "Medio"));
            }
        }
        /// <summary>
        /// Traer lista de facturas por DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static List<BE_Factura> TraerFacturas(string dni)
        {
            List<BE_Factura> facturaList = new List<BE_Factura>();
            try
            {
                //Crea factura
                string query = @"select * from factura where id_cliente = (select id_cliente from clienteGym where dni = @dni)";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@dni", dni);
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);

                foreach (DataRow fact in dt.Rows)
                {
                    BE_Factura factura = new BE_Factura();
                    factura.Fecha = DateTime.Parse(fact["fecha"].ToString());
                    factura.Monto = decimal.Parse(fact["monto"].ToString());
                    factura.Id_Factura = int.Parse(fact["Id_Factura"].ToString());
                    facturaList.Add(factura);
                }
            }
            catch { }
            return facturaList;
        }
    }
}
