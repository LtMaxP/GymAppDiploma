using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL.Negocio
{
    public class BLLProducto
    {
        DAL.Negocio.DALProducto prod = new DAL.Negocio.DALProducto();
        public List<BE.Item> TraerProductos()
        {
            return prod.DALTraerProductos();
        }

        public bool CargarProducto(Item item)
        {
            return prod.DALCargarProducto(item);
        }
    }
}
