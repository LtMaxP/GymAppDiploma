using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Negocio
{
    public class DALProducto
    {
        /// <summary>
        /// Traer listado de productos
        /// </summary>
        /// <returns></returns>
        public List<Item> DALTraerProductos()
        {
            List<Item> ret = new List<Item>();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT Descripcion, Valor, Cantidad FROM Item";

                DataTable dt = Acceso.Instance.ExecuteReader(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    ret.Add(new Item(dr[0].ToString(), (decimal)dr[1], (int)dr[2]));
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }
            return ret;
        }
        /// <summary>
        /// Cargar productos 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool DALCargarProducto(Item item)
        {
            bool ret = false;
            try
            {
                var sqlCmd = Acceso.Instance.CrearCommandStoredProcedure("[dbo].[CargarItems]");
                sqlCmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = item.Descripcion;
                sqlCmd.Parameters.Add("@Valor", SqlDbType.Decimal).Value = item.Valor;
                sqlCmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = item.Cantidad;
                sqlCmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Servicios.Sesion.GetInstance.usuario.IdUsuario;
                Acceso.Instance.ExecuteNonQuery(sqlCmd);
                //cargar cc
                //DAL.Tecnico.ControlCambiosDAL.GrabarHistoricoCC(new BE.Tecnico.ControlCambio(item.Id_Item, item.Valor, item.Cantidad, item.Descripcion, "Carga stock ", 99));
                //DAL.Tecnico.ControlCambiosDAL.GrabarHistoricoCC(new BE.Tecnico.ControlCambio(item.Id_Item,item.Valor,item);
                ret = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de ejecutar SP."); }
            return ret;
        }
    }
}
