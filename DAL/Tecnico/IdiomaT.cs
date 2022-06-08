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
            DataTable dt = null;
            //fijarte en otro archivo q hace todo así te olvidas del open y dispones y blalbalba
            #region block

            String qry = "SELECT Id_Idioma, Texto_Lbl, NombreEtiqueta FROM CampoIdioma INNER JOIN Label_Etiqueta ON CampoIdioma.Id_label = Label_Etiqueta.Id_label";
            SqlCommand command = new SqlCommand(qry);
            try
            {
                dt = Acceso.Instance.ExecuteDataTable(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer idiomas"); }
            #endregion



            return dt;
        }
        public void CambiarIdiomaDeUsuarioDAL(int idUsuario, int idIdioma)
        {

            String query = "UPDATE Usuario SET id_idioma = '" + idIdioma + "' WHERE Id_Usuario = '" + idUsuario + "'";
            SqlCommand command = new SqlCommand(query);
            int i = Acceso.Instance.ExecuteNonQuery(command);
            if (i == 1)
            {
                BE.Usuario.Instance.idIdioma = idIdioma;
            }
        }
    }
}

