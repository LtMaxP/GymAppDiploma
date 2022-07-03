using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DigitoVerificadorDAL
    {
        private BE.BE_Usuarios usuarioActual = BE.Usuario.Instance;

        public DataTable ObtenerListaDeDVHUsuarios()
        {
            DataTable dt = new DataTable();
            String query = "SELECT [DVH] FROM [Usuario]";
            SqlCommand command = new SqlCommand(query);
            try
            {
                dt = Acceso.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVV :("); }
            return dt;
        }

        public String TraerDVV()
        {
            string returnable = string.Empty;
            String query = "SELECT [CodigoHash] FROM DVV";
            SqlCommand command = new SqlCommand(query);
            try
            {
                returnable = Acceso.Instance.ExecuteScalar2(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVV :("); }
            return returnable;
        }

        public DataTable TraerDVH()
        {
            DataTable returnable = new DataTable();
            String query = "SELECT [Id_Usuario], [DVH] FROM [Usuario]";
            SqlCommand command = new SqlCommand(query);
            try
            {
                returnable = Acceso.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVH :("); }
            return returnable;
        }

        public void InsertarDVHEnUsuario(string codigoHash)
        {

            String query = "UPDATE [DVHUsuario] set [HashCode] = @hashDVH WHERE id_Usuario = @IdUsuario";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdUsuario", BE.Usuario.Instance.IdUsuario);
            command.Parameters.AddWithValue("@hashDVH", codigoHash);

            try
            {
                Acceso.Instance.ExecuteNonQuery(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar insertar DVH :("); }
        }

        public void InsertarDVV(string codigoHash)
        {
            String query = "UPDATE [DVV] set [CodigoHash] = @hash";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@hash", codigoHash);

            try
            {
                Acceso.Instance.ExecuteNonQuery(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar insertar DVV :("); }
        }


    }
}
