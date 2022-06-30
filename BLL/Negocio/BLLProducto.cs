using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Negocio
{
    public class BLLProducto
    {
        DAL.Negocio.DALProducto Prod = new DAL.Negocio.DALProducto();
        public List<BE.Item> TraerProductos()
        {
            return Prod.DALTraerProductos();
        }
    }
}
