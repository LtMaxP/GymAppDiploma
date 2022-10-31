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
        /// <summary>
        /// Traer dvv
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Inserta DVH calculado en Usuario por id
        /// </summary>
        /// <param name="usuario"></param>
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
        /// <summary>
        /// Insertar DVV
        /// </summary>
        /// <param name="codigoHash"></param>
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
