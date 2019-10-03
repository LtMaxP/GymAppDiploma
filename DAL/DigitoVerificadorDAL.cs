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
        private Conexion connect = new Conexion();
        protected BE.DVH dvh = new BE.DVH();
        private BE.Usuario usuarioActual = BE.Usuario.Instance;

        public List<string> ObtenerListaDeDVHUsuarios()
        {
            List<string> dVHUsuariosTotales = new List<string>();

            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT DVH FROM Usuario";
            sqlcomm.Connection = connect.sqlConn;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
            connect.Conectar();

            da.Fill(ds);
            connect.Desconectar();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dVHUsuariosTotales.Add(row["DVH"].ToString());
            }

            return dVHUsuariosTotales;
        }

        public DataTable TraerDVV()
        {
            DataSet ds = new DataSet();
            DataTable dVTable;
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "SELECT Id_DVV, CodigoHash FROM DVV";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    connection.Open();
                    da.Fill(ds);
                }
            }

            dVTable = ds.Tables[0];
            return dVTable;
        }

        public DataTable TraerDVH()
        {
            DataSet ds = new DataSet();
            DataTable dVTable;
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "SELECT Usuario, DVH FROM Usuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    connection.Open();
                    da.Fill(ds);
                }
            }

            dVTable = ds.Tables[0];
            return dVTable;
        }

        public void InsertarDVHEnUsuario(string codigoHash)
        {

            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "INSERT INTO Usuario (DVH) VALUES (@hashDVH) WHERE Usuario.Id_Usuario = @IdUsuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", usuarioActual.IdUsuario);
                    command.Parameters.AddWithValue("@hashDVH", codigoHash);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                }
            }
        }

        public void InsertarDVV(string codigoHash)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "INSERT INTO DVV (CodigoHash) VALUES (@hash) WHERE DVV.Id_DVV = @IdUsuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", "1");
                    command.Parameters.AddWithValue("@hash", codigoHash);
                    int result = command.ExecuteNonQuery();
                }
            }
        }


    }
}
