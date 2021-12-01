using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALClientes : DAL.ICRUD<BE.Cliente>
    {
        private Conexion connect = new Conexion();
        public void Alta(Cliente valAlta)
        {
            throw new NotImplementedException();
        }

        public void Baja(Cliente valBaja)
        {
            throw new NotImplementedException();
        }

        public DataTable Leer(Cliente valBuscar)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Cliente valMod)
        {
            throw new NotImplementedException();
        }
        public bool ValidarSiExisteDAL(Cliente cli)
        {
            DataSet ds = new DataSet();
            DataTable dVTable;
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "SELECT dni FROM Clientes WHERE dni = " + cli;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    connection.Open();
                    da.Fill(ds); //preguntar por match true or false
                }
            }

            dVTable = ds.Tables[0];
            return true;

        }
    }
}

