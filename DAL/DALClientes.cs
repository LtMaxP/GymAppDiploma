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
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "SELECT ID, Nombre, Apellido, Dni FROM ClienteGYM WHERE Nombre = " + valBuscar._nombre + ")";
                SqlCommand command = new SqlCommand(query, connection);

                command.Connection.Open();
                try
                {
                    dt = (DataTable)command.ExecuteScalar();

                }
                catch (Exception e)
                { }
                command.Connection.Close();

            }
            return dt;
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
                SqlCommand command = new SqlCommand(query, connection);
                
                    command.Connection.Open();
                    try{
                    int resquery = Convert.ToInt32(command.ExecuteScalar());
                        if (resquery == 1)
                        {
                            respuesta = true;
                        }
                    }
                    catch(Exception e)
                    { respuesta = false; }
                    command.Connection.Close();
                
            }
            return respuesta;

        }
    }
}

