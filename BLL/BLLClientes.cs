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
    public class BLLClientes
    {
        public bool Alta(Cliente valAlta)
        {
            return true;
        }

        public bool Baja(Cliente valBaja)
        {
            return true;
        }

        public DataTable Leer(Cliente valBuscar)
        {
            DataTable a = new DataTable();
            return a;
        }

        public bool Modificar(Cliente valMod)
        {
            return true;
        }

        public bool ValidarSiExiste(Cliente cli)
        {
            DALClientes dalCli = new DALClientes();
            return dalCli.ValidarSiExisteDAL(cli);
        }
    }
}
