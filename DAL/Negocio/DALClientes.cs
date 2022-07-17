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

                comm.CommandText = "INSERT INTO ClienteGYM (Nombre, Apellido, Dni, Calle, Numero, CodPostal, Telefono, Fecha_Nac, PesoKg, Id_Estado) VALUES (@Nombre, @Apellido, @Dni, @Calle, @Numero, @CodPostal, @Telefono, @FechaNac, @Peso, @Estado)";

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@Nombre";
                parameter1.Value = valAlta.Nombre;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@Apellido";
                parameter2.Value = valAlta.Apellido;
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
                parameter10.Value = valAlta.Id_Estado;
                parameter10.SqlDbType = System.Data.SqlDbType.Int;

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

                int result = Acceso.Instance.ExecuteNonQuery(comm);
                rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta el Usuario."); }
            return rpta;
        }

        public bool Baja(Cliente valBaja)
        {
            bool retornable = false;
            String query = "UPDATE ClienteGYM SET [Id_Estado] = " + "2" + " WHERE Dni = " + valBaja._dni;
            SqlCommand comm = new SqlCommand(query);
            try
            {
                Acceso.Instance.ExecuteNonQuery(comm);
                retornable = true;
            }
            catch
            { }
            return retornable;
        }

        public DataTable Leer(Cliente valBuscar)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = Acceso.Instance.sqlCon;
            String query = "SELECT Id_Cliente, Nombre, Apellido, Dni FROM ClienteGYM WHERE Nombre = " + "'" + valBuscar.Nombre + "'";
            SqlCommand comm = new SqlCommand(query);
            try
            {
                dt = Acceso.Instance.ExecuteDataTable(comm);
            }
            catch
            { }
            return dt;
        }

        public bool Modificar(Cliente valMod)
        {
            bool rpta = false;
            try
            {
                SqlCommand comm = new SqlCommand();

                comm.CommandText = "UPDATE ClienteGYM SET Nombre = @Nombre, Apellido = @Apellido, Calle = @Calle, Numero = @Numero, CodPostal = @CodPostal, Telefono = @Telefono, PesoKg = @Peso, Id_Estado = @Estado WHERE Dni = @Dni";

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@Nombre";
                parameter1.Value = valMod.Nombre;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@Apellido";
                parameter2.Value = valMod.Apellido;
                parameter2.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@Dni";
                parameter3.Value = valMod._dni;
                parameter3.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@Calle";
                parameter4.Value = valMod._calle;
                parameter4.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter5 = new SqlParameter();
                parameter5.ParameterName = "@Numero";
                parameter5.Value = valMod._numero;
                parameter5.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter6 = new SqlParameter();
                parameter6.ParameterName = "@CodPostal";
                parameter6.Value = valMod._codPostal;
                parameter6.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter7 = new SqlParameter();
                parameter7.ParameterName = "@Telefono";
                parameter7.Value = valMod._telefono;
                parameter7.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter9 = new SqlParameter();
                parameter9.ParameterName = "@Peso";
                parameter9.Value = valMod._pesokg;
                parameter9.SqlDbType = System.Data.SqlDbType.Float;

                SqlParameter parameter10 = new SqlParameter();
                parameter10.ParameterName = "@Estado";
                parameter10.Value = valMod.Id_Estado;
                parameter10.SqlDbType = System.Data.SqlDbType.Int;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter2);
                comm.Parameters.Add(parameter3);
                comm.Parameters.Add(parameter4);
                comm.Parameters.Add(parameter5);
                comm.Parameters.Add(parameter6);
                comm.Parameters.Add(parameter7);
                comm.Parameters.Add(parameter9);
                comm.Parameters.Add(parameter10);

                int result = Acceso.Instance.ExecuteNonQuery(comm);
                rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta el Usuario."); }
            return rpta;
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
                SqlCommand command = new SqlCommand(query);
                try
                {
                    dt = Acceso.Instance.ExecuteReader(command);
                }
                catch
                { }

            }
            return dt;

        }

        public int DameIdCliente(string nombre)
        {
            int idCliente = 0;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                String query = "SELECT Id_Cliente FROM ClienteGYM WHERE Nombre = @nombre";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@nombre", nombre);
                try
                {
                    idCliente = Acceso.Instance.ExecuteScalar(command);
                }
                catch
                { }
            }
            return idCliente;
        }
        Cliente ICRUD<Cliente>.Leer(Cliente valBuscar)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Leer2(Cliente valBuscar)
        {
            throw new NotImplementedException();
        }
    }
}

