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
        void Alta(T valAlta);
        void Baja(T valBaja);
        void Modificar(T valMod);
        DataTable Leer(T valBuscar);
    }
}
