using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            bool rpta = false;
            DAL.Conexion conn = new DAL.Conexion();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn.sqlConn;

                comm.CommandText = "INSERT INTO ClienteGYM (Nombre, Apellido, Dni, Calle, Numero, CodPostal, Telefono, Fecha_Nac, PesoKg, Id_Estado, Id_Sucursal, Id_Empleado) VALUES (@Nombre, @Apellido, @Dni, @Calle, @Numero, @CodPostal, @Telefono, @FechaNac, @Peso, @Estado, @Sucursal, @Empleado)";

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

                SqlParameter parameter11 = new SqlParameter();
                parameter11.ParameterName = "@Sucursal";
                parameter11.Value = valAlta._IDSucursal;
                parameter11.SqlDbType = System.Data.SqlDbType.Int;

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
                comm.Parameters.Add(parameter11);
                comm.Parameters.Add(parameter12);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();
                rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta al Usuario."); }
            return rpta;
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
