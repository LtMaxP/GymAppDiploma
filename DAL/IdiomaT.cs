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

                String query = "SELECT Idioma, Texto_Lbl, NombreEtiqueta FROM CampoIdioma INNER JOIN Label_Etiqueta ON CampoIdioma.Id_label = Label_Etiqueta.Id_label INNER JOIN Idioma ON CampoIdioma.Id_Idioma = Idioma.Id_Idioma";
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
    }
}
