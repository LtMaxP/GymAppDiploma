using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface ICRUDServicios<T>   //generics
    {
        bool Alta(T valueAlta);
        bool Baja(T valueBaja);
        bool Modificar(T valueModificar);
        DataTable Leer(T valueBuscar);
        List<T> Leer2(T valBuscar);
    }
}
