using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICRUD<T>   //generics ejemplo
    {
        bool Alta(T valAlta);
        bool Baja(T valBaja);
        bool Modificar(T valMod);
        DataTable Leer(T valBuscar);
    }
}
