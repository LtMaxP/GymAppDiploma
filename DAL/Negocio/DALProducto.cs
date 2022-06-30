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
    }
}
