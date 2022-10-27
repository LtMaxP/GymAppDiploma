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
    public class DALClientes : ICRUD<Cliente>
    {
        /// <summary>
        /// Dar de Alta cliente
        /// </summary>
        /// <param name="valAlta"></param>
        /// <returns></returns>
        public bool Alta(Cliente valAlta)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "INSERT INTO ClienteGYM ([Nombre], [Apellido], [PesoKg], [Dni], [Calle], [Numero], [CodPostal], [Telefono], [Fecha_Nac], [Id_Membresia], [Id_Estado], [Certificado], [Descuento], [Altura]) VALUES (@Nombre, @Apellido, @Peso, @Dni, @Calle, @Numero, @CodPostal, @Telefono, @FechaNac, @Membresia, @Estado, @Certificado, @Descuento, @Altura)";

            comm.Parameters.AddWithValue("@Nombre", valAlta.Nombre);
            comm.Parameters.AddWithValue("@Apellido", valAlta.Apellido);
            comm.Parameters.AddWithValue("@FechaNac", valAlta._fechaNacimiento);
            comm.Parameters.AddWithValue("@Dni", valAlta.Dni);
            comm.Parameters.AddWithValue("@Calle", valAlta._calle);
            comm.Parameters.AddWithValue("@Numero", valAlta._numero);
            comm.Parameters.AddWithValue("@CodPostal", valAlta._codPostal);
            comm.Parameters.AddWithValue("@Telefono", valAlta._telefono);
            comm.Parameters.AddWithValue("@Estado", valAlta.Id_Estado);
            comm.Parameters.AddWithValue("@Peso", valAlta._pesokg);
            comm.Parameters.AddWithValue("@Altura", valAlta.Altura);
            comm.Parameters.AddWithValue("@Certificado", valAlta.Certificado);
            comm.Parameters.AddWithValue("@Membresia", valAlta.Membresia.Id);
            comm.Parameters.AddWithValue("@Descuento", valAlta.Descuento);

            int result = Acceso.Instance.ExecuteNonQuery(comm);
            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Creacion de cliente: " + valAlta.Dni, "Ninguno"));
            if (result != -1)
            {
                System.Windows.Forms.MessageBox.Show("Cliente dado de alta.");
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta el cliente.");
                return false;
            }
        }
        /// <summary>
        /// Cambia a baja el dni del cliente enviado
        /// </summary>
        /// <param name="valBaja"></param>
        /// <returns></returns>
        public bool Baja(Cliente valBaja)
        {
            String query = "UPDATE ClienteGYM SET [Id_Estado] = 2 WHERE Dni = @dni";
            SqlCommand comm = new SqlCommand(query);
            comm.Parameters.AddWithValue("@dni", valBaja.Dni);
            int ret = Acceso.Instance.ExecuteNonQuery(comm);
            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Dado de baja el Cliente : " + valBaja.Dni, "Ninguno"));
            if (ret != -1)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Trae dni/nombre/apellido del nombre dado
        /// </summary>
        /// <param name="valBuscar"></param>
        /// <returns></returns>
        public DataTable BuscarUsuarios(Cliente valBuscar)
        {
            DataTable dt = new DataTable();
            String query = "SELECT Dni, Nombre, Apellido FROM ClienteGYM WHERE Nombre = @name";
            SqlCommand comm = new SqlCommand(query);
            comm.Parameters.AddWithValue("@name", valBuscar.Nombre);
            dt = Acceso.Instance.ExecuteDataTable(comm);
            return dt;
        }
        /// <summary>
        /// Modificar Cliente
        /// </summary>
        /// <param name="valMod"></param>
        /// <returns></returns>
        public bool Modificar(Cliente valMod)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "UPDATE ClienteGYM SET Nombre = @Nombre, Apellido = @Apellido, Calle = @Calle, Numero = @Numero, CodPostal = @CodPostal, Telefono = @Telefono, PesoKg = @Peso, Id_Estado = @Estado, Altura = @Altura, Certificado = @Certificado, Id_Membresia = @Membresia, Descuento = @Descuento WHERE Dni = @Dni";

            comm.Parameters.AddWithValue("@Nombre", valMod.Nombre);
            comm.Parameters.AddWithValue("@Apellido", valMod.Apellido);
            comm.Parameters.AddWithValue("@Dni", valMod.Dni);
            comm.Parameters.AddWithValue("@Calle", valMod._calle);
            comm.Parameters.AddWithValue("@Numero", valMod._numero);
            comm.Parameters.AddWithValue("@CodPostal", valMod._codPostal);
            comm.Parameters.AddWithValue("@Telefono", valMod._telefono);
            comm.Parameters.AddWithValue("@Estado", valMod.Id_Estado);
            comm.Parameters.AddWithValue("@Peso", valMod._pesokg);
            comm.Parameters.AddWithValue("@Altura", valMod.Altura);
            comm.Parameters.AddWithValue("@Certificado", valMod.Certificado);
            comm.Parameters.AddWithValue("@Membresia", valMod.Membresia.Id);
            comm.Parameters.AddWithValue("@Descuento", valMod.Descuento);

            int result = Acceso.Instance.ExecuteNonQuery(comm);
            if (result != -1)
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se modificó el cliente: " + valMod.Dni, "Ninguno"));
                return true;
            }
            else
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("No se modificó el cliente: " + valMod.Dni, "Bajo"));
                return false;
            }
        }

        /// <summary>
        /// Validar existencia de cliente por DNI
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public bool ValidarSiExisteDAL(Cliente cli)
        {
            String query = "SELECT * FROM ClienteGYM WHERE EXISTS(SELECT * FROM ClienteGYM WHERE Dni = @dni)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@dni", cli.Dni);
            return Acceso.Instance.ExecuteScalarBool(command);
        }
        /// <summary>
        /// Trae el cliente en base al dni pasado
        /// </summary>
        /// <param name="cli"></param>
        /// <returns></returns>
        public BE.Cliente MostrarCliente(Cliente formaCliente)
        {
            String query = "SELECT * FROM ClienteGYM WHERE dni = " + formaCliente.Dni;
            SqlCommand command = new SqlCommand(query);

            DataTable dt = Acceso.Instance.ExecuteReader(command);
            foreach (DataRow fila in dt.Rows)
            {
                formaCliente.Nombre = fila["Nombre"].ToString();
                formaCliente.Apellido = fila["Apellido"].ToString();
                formaCliente._pesokg = float.Parse(fila["PesoKg"].ToString());
                formaCliente.Dni = int.Parse(fila["Dni"].ToString());
                formaCliente._calle = fila["Calle"].ToString();
                formaCliente._numero = int.Parse(fila["Numero"].ToString());
                formaCliente._codPostal = int.Parse(fila["CodPostal"].ToString());
                formaCliente._telefono = int.Parse(fila["Telefono"].ToString());
                formaCliente._fechaNacimiento = DateTime.Parse(fila["Fecha_Nac"].ToString());
                formaCliente.Membresia.Id = int.Parse(fila["Id_Membresia"].ToString());
                formaCliente.Id_Estado = int.Parse(fila["Id_Estado"].ToString());
                formaCliente.Certificado = bool.Parse(fila["Certificado"].ToString());
                formaCliente.Descuento = int.Parse(fila["Descuento"].ToString());
                formaCliente.Altura = float.Parse(fila["Altura"].ToString());
            }

            return formaCliente;
        }

        public int DameIdCliente(BE.Cliente cliente)
        {
            String query = "SELECT Id_Cliente FROM ClienteGYM WHERE Dni = @dni";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@dni", cliente.Dni);
            return Acceso.Instance.ExecuteScalar(command);
        }
        public Cliente Leer(Cliente valBuscar)
        {
            return valBuscar;
        }
        public List<Cliente> Leer2(Cliente valBuscar)
        {
            throw new NotImplementedException();
        }
    }
}

