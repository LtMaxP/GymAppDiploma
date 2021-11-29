using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLClientes : DAL.ICRUD<BE.Cliente>
    {
        public void Alta(Cliente valAlta)
        {
            bool ok = true;
        }

        public void Baja(Cliente valBaja)
        {
            throw new NotImplementedException();
        }

        public DataTable Leer(Cliente valBuscar)
        {
            DataTable a = new DataTable();
            return a;
        }

        public void Modificar(Cliente valMod)
        {
            throw new NotImplementedException();
        }

        public void ValidarSiClienteExiste(Cliente cli)
        {

            //DAL.DALClientes
        }
    }
}
