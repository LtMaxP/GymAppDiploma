using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IdiomaT
    {
        DAL.Conexion connect = new DAL.Conexion();


        /// <summary>
        /// Devuelve una lista de objetos que contiene el Idioma correspondiente, El texto en su correspondeinte idioma y el nombre de etiqueta perteneciente
        /// </summary>
        /// <returns></returns>
        public DataTable TraerListaDeIdiomas()
        {
            DataSet ds = new DataSet();
            DataTable dt;
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                //Query para traer con el idioma en texto
                //String query = "SELECT Idioma, Texto_Lbl, NombreEtiqueta FROM CampoIdioma INNER JOIN Label_Etiqueta ON CampoIdioma.Id_label = Label_Etiqueta.Id_label INNER JOIN Idioma ON CampoIdioma.Id_Idioma = Idioma.Id_Idioma";
                //Query para traer el idioma con ID
                String query = "SELECT Id_Idioma, Texto_Lbl, NombreEtiqueta FROM CampoIdioma INNER JOIN Label_Etiqueta ON CampoIdioma.Id_label = Label_Etiqueta.Id_label";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    connection.Open();
                    da.Fill(ds);
                }
            }

            dt = ds.Tables[0];

            return dt;
        }
        public void CambiarIdiomaDeUsuarioDAL(int idUsuario, int idIdioma)
        {
            using (SqlConnection connection = new SqlConnection(connect.ConexionRuta))
            {
                String query = "UPDATE Usuario SET id_idioma = '"+ idIdioma +"' WHERE Id_Usuario = '" + idUsuario + "'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    connection.Open();
                    da.SelectCommand.ExecuteNonQuery();

                    BE.Usuario.Instance.idIdioma = idIdioma;
                }
            }
        }
    }
}
