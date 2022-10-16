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

        public static DataTable ObtenerListaDeDVHUsuarios()
        {
            DataTable dt = new DataTable();
            String query = "SELECT [DVH] FROM [Usuario]";
            SqlCommand command = new SqlCommand(query);
            try
            {
                dt = Acceso.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al encontrar DVH :("); }
            return dt;
        }

        public static String TraerDVV()
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

        public static DataTable TraerDVH()
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

        public static void InsertarDVHEnUsuario(BE.BE_Usuario usuario)
        {
            String query = "UPDATE Usuario SET [DVH] = @hashDVH WHERE Id_Usuario = @IdUsuario";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
            command.Parameters.AddWithValue("@hashDVH", usuario._DVH);

            try
            {
                Acceso.Instance.ExecuteNonQuery(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar insertar DVH :("); }
        }

        public static void InsertarDVV(string codigoHash)
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
