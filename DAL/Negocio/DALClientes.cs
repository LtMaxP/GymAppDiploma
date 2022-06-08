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
        public bool Alta(Cliente valAlta)
        {
            bool rpta = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = Acceso.Instance.sqlCon;

                comm.CommandText = "INSERT INTO ClienteGYM (Nombre, Apellido, Dni, Calle, Numero, CodPostal, Telefono, Fecha_Nac, PesoKg, Id_Estado, Id_Empleado) VALUES (@Nombre, @Apellido, @Dni, @Calle, @Numero, @CodPostal, @Telefono, @FechaNac, @Peso, @Estado, @Empleado)";

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@Nombre";
                parameter1.Value = valAlta._nombre;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@Apellido";
                parameter2.Value = valAlta._apellido;
                parameter2.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@Dni";
                parameter3.Value = valAlta._dni;
                parameter3.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@Calle";
                parameter4.Value = valAlta._calle;
                parameter4.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter5 = new SqlParameter();
                parameter5.ParameterName = "@Numero";
                parameter5.Value = valAlta._numero;
                parameter5.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter6 = new SqlParameter();
                parameter6.ParameterName = "@CodPostal";
                parameter6.Value = valAlta._codPostal;
                parameter6.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter7 = new SqlParameter();
                parameter7.ParameterName = "@Telefono";
                parameter7.Value = valAlta._telefono;
                parameter7.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter8 = new SqlParameter();
                parameter8.ParameterName = "@FechaNac";
                parameter8.Value = valAlta._fechaNacimiento;
                parameter8.SqlDbType = System.Data.SqlDbType.DateTime;

                SqlParameter parameter9 = new SqlParameter();
                parameter9.ParameterName = "@Peso";
                parameter9.Value = valAlta._pesokg;
                parameter9.SqlDbType = System.Data.SqlDbType.Float;

                SqlParameter parameter10 = new SqlParameter();
                parameter10.ParameterName = "@Estado";
                parameter10.Value = valAlta._idEstado;
                parameter10.SqlDbType = System.Data.SqlDbType.Int;

                //SqlParameter parameter11 = new SqlParameter();
                //parameter11.ParameterName = "@Sucursal";
                //parameter11.Value = valAlta._IDSucursal;
                //parameter11.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter12 = new SqlParameter();
                parameter12.ParameterName = "@Empleado";
                parameter12.Value = valAlta._IDEmpleado;
                parameter12.SqlDbType = System.Data.SqlDbType.Int;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter2);
                comm.Parameters.Add(parameter3);
                comm.Parameters.Add(parameter4);
                comm.Parameters.Add(parameter5);
                comm.Parameters.Add(parameter6);
                comm.Parameters.Add(parameter7);
                comm.Parameters.Add(parameter8);
                comm.Parameters.Add(parameter9);
                comm.Parameters.Add(parameter10);
                //comm.Parameters.Add(parameter11);
                comm.Parameters.Add(parameter12);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();
                rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta el Usuario."); }
            return rpta;
        }

        public bool Baja(Cliente valBaja)
        {
            throw new NotImplementedException();
        }

        public DataTable Leer(Cliente valBuscar)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = Acceso.Instance.sqlCon;
            String query = "SELECT Id_Cliente, Nombre, Apellido, Dni FROM ClienteGYM WHERE Nombre = " + "'" + valBuscar._nombre + "'";
            SqlCommand command = new SqlCommand(query, connection);

            command.Connection.Open();
            try
            {
                dt.Load(command.ExecuteReader());
            }
            catch 
            { }
            command.Connection.Close();
            return dt;
        }

        public bool Modificar(Cliente valMod)
        {
            throw new NotImplementedException();
        }

        public bool ValidarSiExisteDAL(Cliente cli)
        {
            bool respuesta = false;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                String query = "SELECT * FROM ClienteGYM WHERE EXISTS(SELECT * FROM ClienteGYM WHERE dni = " + cli._dni + ")";
                SqlCommand command = new SqlCommand(query, connection);

                command.Connection.Open();
                try
                {
                    int resquery = Convert.ToInt32(command.ExecuteScalar());
                    if (resquery == 1)
                    {
                        respuesta = true;
                    }
                }
                catch
                { respuesta = false; }
                command.Connection.Close();

            }
            return respuesta;

        }

        public DataTable MostrarCliente(Cliente cli)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                String query = "SELECT * FROM ClienteGYM WHERE dni = " + cli._dni;
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                try
                {
                    dt.Load(command.ExecuteReader());
                }
                catch 
                { }
                command.Connection.Close();

            }
            return dt;

        }
    }
}

