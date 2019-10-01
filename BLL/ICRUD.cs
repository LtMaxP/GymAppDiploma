using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICRUD<T>   //generics ejemplo
    {
        void Alta(T valAlta);
        void Baja(T valBaja);
        void Modificar();
        void Leer();
    }
}
