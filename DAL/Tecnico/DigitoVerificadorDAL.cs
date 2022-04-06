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
        private BE.Usuario usuarioActual = BE.Usuario.Instance;

        public DataTable ObtenerListaDeDVHUsuarios()
        {
            DataTable dt = new DataTable();
            String query = "SELECT [HashCode] FROM [DVHUsuario]";
            SqlCommand command = new SqlCommand(query);
            try
            {
                dt = Singleton.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVV :("); }
            return dt;
        }

        public DataTable TraerDVV()
        {
            DataTable dt = new DataTable();
            String query = "SELECT [CodigoHash] FROM DVV";
            SqlCommand command = new SqlCommand(query);
            try
            {
                dt = Singleton.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVV :("); }
            return dt;
        }

        public DataTable TraerDVH()
        {
            DataTable returnable = new DataTable();
            String query = "SELECT [id_Usuario], [HashCode] FROM [DVHUsuario]";
            SqlCommand command = new SqlCommand(query);
            try
            {
                returnable = Singleton.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVV :("); }
            return returnable;
        }

        public void InsertarDVHEnUsuario(string codigoHash)
        {

            String query = "UPDATE [DVHUsuario] set [HashCode] = @hashDVH WHERE id_Usuario = @IdUsuario";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdUsuario", usuarioActual.IdUsuario);
            command.Parameters.AddWithValue("@hashDVH", codigoHash);

            try
            {
                Singleton.Instance.ExecuteNonQuery(command);
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
                Singleton.Instance.ExecuteNonQuery(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar insertar DVV :("); }
        }


    }
}
