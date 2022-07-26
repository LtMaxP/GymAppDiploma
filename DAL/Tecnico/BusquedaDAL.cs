using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BusquedaDAL
    {
        public string DevolvemeElValorQueQuieroPorId(string id, string queEs)
        {
            string dato = string.Empty;
            queEs = queEs.ToLower();

            switch (queEs)
            {
                case "idioma":
                    dato = DameTexto(id, "Idioma", "Idioma", "Id_Idioma");
                    break;
                case "estado":
                    dato = DameTexto(id, "Desc_Estado", "Estado", "Id_Estado");
                    break;
            }

            return dato;
        }

        /// <summary>
        /// Funcion utilizable para convertir el idioma o el estado en su ID correspondiente
        /// </summary>
        /// <param name="texto"> Texto es el valor a buscar en table</param>
        /// <param name="queEs"> Especifica si es para buscar -idioma- o -estado-</param>
        /// <returns></returns>
        public string DevolvemeElIDQueQuieroPorTexto(string texto, string queEs)
        {
            string dato = string.Empty;
            queEs = queEs.ToLower();

            switch (queEs)
            {
                case "idioma":
                    dato = DameID(texto, "Id_Idioma", "Idioma", "Idioma"); //"SELECT Id_Idioma FROM Idioma WHERE Idioma = @Idioma";
                    break;
                case "estado":
                    dato = DameID(texto, "Id_Estado", "Estado", "Desc_Estado");
                    break;
            }

            return dato;
        }


        private string DameID(string nombre, string devolver, string tabla, string campoCondicional)
        {
            string idDelDidioma = null;
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.CommandText = "SELECT " + devolver + " FROM " + tabla + " WHERE " + campoCondicional + " = @texto";


                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@texto";
                param1.Value = nombre;
                param1.SqlDbType = System.Data.SqlDbType.VarChar;

                sqlcomm.Parameters.Add(param1);
                DataRow row = Acceso.Instance.ExecuteDataTable(sqlcomm).Rows[0];
                idDelDidioma = row[0].ToString();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un problema");
            }
            return idDelDidioma;
        }

        /// <summary>
        /// Devuelve todos los IDs de Usuarios
        /// </summary>
        /// <returns></returns>
        public List<BE_Usuario> TraerUsuarios()
        {
            List<BE_Usuario> users = new List<BE_Usuario>();
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.CommandText = "SELECT Id_Usuario, Usuario from Usuario";

                DataTable dt = Acceso.Instance.ExecuteDataTable(sqlcomm);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr != null)
                    {
                        BE_Usuario us = new BE_Usuario();
                        us.IdUsuario = (int)dr[0];
                        us.User = dr[1].ToString();
                        //permisos seguro tmb
                        users.Add(us);
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un problema al traer los ids de usuarios");
            }
            return users;
        }

        private string DameTexto(string id, string devolver, string tabla, string campoCondicional)
        {
            string idioma = string.Empty;
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.CommandText = "SELECT " + devolver + " FROM " + tabla + " WHERE " + campoCondicional + " = @ID";
                sqlcomm.Connection = Acceso.Instance.sqlCon;

                SqlParameter param1 = new SqlParameter();
                param1.ParameterName = "@ID";
                param1.Value = id;
                param1.SqlDbType = System.Data.SqlDbType.VarChar;

                sqlcomm.Parameters.Add(param1);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sqlcomm);
                Acceso.Instance.sqlCon.Open();

                da.Fill(ds);
                Acceso.Instance.sqlCon.Close();

                DataRow row = ds.Tables[0].Rows[0];
                idioma = row[0].ToString();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un problema");
            }
            return idioma;
        }

        public bool ValidarSiExisteEnDAL(string tabla, string comparacion, string datoAComparar)
        {
            bool respuesta = false;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                String query = "SELECT * FROM " + tabla + " WHERE EXISTS(SELECT * FROM  " + tabla + " WHERE " + comparacion + " = " + datoAComparar + ")";
                SqlCommand command = new SqlCommand(query, connection);

                command.Connection.Open();
                try
                {
                    int resquery = Convert.ToInt32(command.ExecuteScalar());
                    if (resquery == 1)
                    {
                        respuesta = true;
                    }
                }
                catch
                { respuesta = false; }
                command.Connection.Close();

            }
            return respuesta;

        }
    }
}

