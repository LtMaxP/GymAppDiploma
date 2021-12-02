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
            bool respuesta = false;
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "SELECT * FROM ClienteGYM WHERE EXISTS(SELECT * FROM ClienteGYM WHERE dni = " + cli._dni + ")"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Connection.Open();
                    try{
                        if(command.ExecuteScalar().ToString() == "1")
                        {
                            respuesta = true;
                        }
                    }
                    catch(Exception e)
                    { respuesta = false; }
                    command.Connection.Close();
                }
            }
            return respuesta;

        }
    }
}

