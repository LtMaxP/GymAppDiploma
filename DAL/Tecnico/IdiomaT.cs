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
       
        /// <summary>
        /// Devuelve una lista de objetos que contiene el Idioma correspondiente, El texto en su correspondeinte idioma y el nombre de etiqueta perteneciente
        /// </summary>
        /// <returns></returns>
        public DataTable TraerListaDeIdiomas()
        {
            DataSet ds = new DataSet();
            DataTable dt;
            using (Acceso.Instance.sqlCon)
            {
                String query = "SELECT Id_Idioma, Texto_Lbl, NombreEtiqueta FROM CampoIdioma INNER JOIN Label_Etiqueta ON CampoIdioma.Id_label = Label_Etiqueta.Id_label";
                SqlCommand command = new SqlCommand(query);

                SqlDataAdapter da = new SqlDataAdapter(command);
                Acceso.Instance.sqlCon.Open();
                da.Fill(ds);
                command.Dispose();
            }


            dt = ds.Tables[0];

            return dt;
        }
        public void CambiarIdiomaDeUsuarioDAL(int idUsuario, int idIdioma)
        {
            using (Acceso.Instance.sqlCon)
            {
                String query = "UPDATE Usuario SET id_idioma = '" + idIdioma + "' WHERE Id_Usuario = '" + idUsuario + "'";
                SqlCommand command = new SqlCommand(query);

                SqlDataAdapter da = new SqlDataAdapter(command);
                Acceso.Instance.sqlCon.Open();
                da.SelectCommand.ExecuteNonQuery();

                BE.Usuario.Instance.idIdioma = idIdioma;
                command.Dispose();

            }
        }
    }
}
