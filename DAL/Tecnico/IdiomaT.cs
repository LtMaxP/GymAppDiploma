using BE.ObserverIdioma;
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
        public BE.ObserverIdioma.BE_Idioma TraerListaDeIdioma(BE.ObserverIdioma.BE_Idioma ListadoIdioma)
        {
            #region block
            String qry = @"SELECT c.Id_Idioma, I.Idioma, c.Texto_Lbl, LblI.NombreEtiqueta 
                            FROM CampoIdioma as C
                            INNER JOIN Label_Etiqueta as LblI
                            ON C.Id_label = LblI.Id_label
                            INNER JOIN Idioma as I
                            ON I.Id_Idioma = C.Id_Idioma
                            where I.Idioma = " + ListadoIdioma.NombreIdioma;
            SqlCommand command = new SqlCommand(qry);
            try
            {
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                ListadoIdioma.Id = int.Parse(dt.Rows[0]["Id_Idioma"].ToString());
                foreach (DataRow fila in dt.Rows)
                {
                    BE.ObserverIdioma.Leyenda transitorio = new BE.ObserverIdioma.Leyenda();
                    transitorio._textoLabel = fila[2].ToString();
                    transitorio._nombreEtiqueta = fila[3].ToString();

                    ListadoIdioma.Leyendas.Add(transitorio);
                }

            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer idioma"); }
            return ListadoIdioma;
            #endregion
        }

        /// <summary>
        /// Buscar si existe el nombre de un idioma
        /// </summary>
        /// <param name="idioma"></param>
        /// <returns></returns>
        public bool ValidarExistenciaIdioma(BE_Idioma idioma)
        {
            String qry2 = @"SELECT CASE WHEN EXISTS (SELECT * FROM [dbo].[Idioma] WHERE Idioma = @Nombre) THEN 1 ELSE 0 END";
            SqlCommand command = new SqlCommand(qry2);
            command.Parameters.AddWithValue("@Nombre", idioma.NombreIdioma);
            Boolean resultado = false;
            try
            {
                resultado = Acceso.Instance.ExecuteScalar(command) == 1 ? true : false;
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer el id del idioma"); }
            return resultado;
        }

        /// <summary>
        /// Inicio de Accion de modificar un idioma en la DAL
        /// </summary>
        /// <param name="idioma"></param>
        public void ModificalIdiomaDAL(BE_Idioma idioma)
        {
            foreach (Leyenda leye in idioma.Leyendas)
            {
                String query = "UPDATE CampoIdioma SET Texto_Lbl = @label WHERE Id_Idioma = @idioma AND Texto_Lbl = @Texto";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@idioma", idioma.Id);
                //string txt = (from L in idioma.Leyendas where L._textoLabel == "ElLabelBabe" select L._textoLabel).FirstOrDefault();
                command.Parameters.AddWithValue("@Texto", leye._nombreEtiqueta);
                command.Parameters.AddWithValue("@label", leye._textoLabel);
                try
                {
                    Acceso.Instance.ExecuteNonQuery(command);
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se modifico el idioma " + idioma.Id, "Ninguno"));
                }
                catch { System.Windows.Forms.MessageBox.Show("Error al intentar Modificar idioma"); }
            }
        }

        /// <summary>
        /// Crear NUEVO idioma 
        /// </summary>
        /// <param name="idioma"></param>
        public void CrearIdiomaDAL(BE_Idioma idioma)
        {
            try
            {
                String query = "INSERT INTO Idioma values (@nombre)";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@nombre", idioma.NombreIdioma);
                Acceso.Instance.ExecuteNonQuery(command);
                idioma = DameIdIdioma(idioma);
                CrearLabelsIdiomaDAL(idioma);
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se creo el idioma " + idioma.Leyendas, "Ninguno"));
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar crear idioma"); }
        }

        /// <summary>
        /// Insertar Labels nuevos
        /// </summary>
        /// <param name="idioma"></param>
        public void CrearLabelsIdiomaDAL(BE_Idioma idioma)
        {
            foreach (Leyenda leye in idioma.Leyendas)
            {
                String query = "INSERT INTO [GymApp].[dbo].[CampoIdioma] VALUES(@idioma, @txtLbl, (select Id_label from [CampoIdioma] where Texto_Lbl = @Texto))";
                SqlCommand command = new SqlCommand(query);
                command.Parameters.AddWithValue("@idioma", idioma.Id);
                //string txt = (from L in idioma.Leyendas where L._textoLabel == "ElLabelBabe" select L._textoLabel).FirstOrDefault();
                command.Parameters.AddWithValue("@Texto", leye._nombreEtiqueta);
                command.Parameters.AddWithValue("@txtLbl", leye._textoLabel);
                try
                {
                    Acceso.Instance.ExecuteNonQuery(command);
                }
                catch { System.Windows.Forms.MessageBox.Show("Error al intentar crear labels del idioma"); }
            }
        }

        /// <summary>
        /// Devuelve el id del Nombre de idioma q se pase
        /// </summary>
        /// <param name="idioma"></param>
        /// <returns></returns>
        public BE_Idioma DameIdIdioma(BE_Idioma idioma)
        {
            String qry = "SELECT Id_Idioma FROM [Idioma] WHERE Idioma = @Nombre";
            SqlCommand command = new SqlCommand(qry);
            command.Parameters.AddWithValue("@Nombre", idioma.NombreIdioma);

            try
            {
                idioma.Id = Acceso.Instance.ExecuteScalar(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer el id del idioma"); }
            return idioma;
        }

        /// <summary>
        /// Devuelve el listado de Textos Del idioma
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        public BE_Idioma VerListadoIdioma(BE_Idioma lang)
        {
            String qry = @"SELECT c.Id_Idioma, I.Idioma, c.Texto_Lbl, LblI.NombreEtiqueta 
                            FROM CampoIdioma as C
                            INNER JOIN Label_Etiqueta as LblI
                            ON C.Id_label = LblI.Id_label
                            INNER JOIN Idioma as I
                            ON I.Id_Idioma = C.Id_Idioma
                            where I.Idioma = @Nombre ";
            SqlCommand command = new SqlCommand(qry);
            command.Parameters.AddWithValue("@Nombre", lang.NombreIdioma);
            try
            {
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                lang.Id = int.Parse(dt.Rows[0]["Id_Idioma"].ToString());
                List<Leyenda> ley = new List<Leyenda>();
                foreach (DataRow fila in dt.Rows)
                {
                    BE.ObserverIdioma.Leyenda transitorio = new BE.ObserverIdioma.Leyenda();
                    //transitorio._nombreEtiqueta = fila[3].ToString();
                    transitorio._textoLabel = fila[2].ToString();
                    ley.Add(transitorio);
                }
                lang.Leyendas = ley;
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer idioma"); }
            return lang;
        }

        public void CargarIdiomaAUsuario()
        {
            #region block
            String qry = @"SELECT c.Id_Idioma, I.Idioma, c.Texto_Lbl, LblI.NombreEtiqueta 
                            FROM CampoIdioma as C
                            INNER JOIN Label_Etiqueta as LblI
                            ON C.Id_label = LblI.Id_label
                            INNER JOIN Idioma as I
                            ON I.Id_Idioma = C.Id_Idioma
                            where I.Idioma = @Nombre";
            SqlCommand command = new SqlCommand(qry);
            command.Parameters.AddWithValue("@Nombre", Servicios.Sesion.GetInstance.usuario.Idioma.NombreIdioma);
            try
            {
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                Servicios.Sesion.GetInstance.usuario.Idioma.Id = int.Parse(dt.Rows[0]["Id_Idioma"].ToString());
                foreach (DataRow fila in dt.Rows)
                {
                    BE.ObserverIdioma.Leyenda transitorio = new BE.ObserverIdioma.Leyenda();
                    transitorio._textoLabel = fila[2].ToString();
                    transitorio._nombreEtiqueta = fila[3].ToString();

                    Servicios.Sesion.GetInstance.usuario.Idioma.Leyendas.Add(transitorio);
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer idioma"); }
            #endregion
        }


        public void CargarIdiomaAUsuarioPorId()
        {
            #region block
            String qry = @"SELECT c.Id_Idioma, I.Idioma, c.Texto_Lbl, LblI.NombreEtiqueta 
                            FROM CampoIdioma as C
                            LEFT JOIN Label_Etiqueta as LblI
                            ON C.Id_label = LblI.Id_label
                            LEFT JOIN Idioma as I
                            ON I.Id_Idioma = C.Id_Idioma
                            WHERE I.Id_Idioma = (select Id_Idioma from Usuario where Id_Usuario = @idIdi)";
            SqlCommand command = new SqlCommand(qry);
            command.Parameters.AddWithValue("@idIdi", Servicios.Sesion.GetInstance.usuario.IdUsuario);
            try
            {
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                BE_Idioma idiom = new BE_Idioma();
                List<Leyenda> ley = new List<Leyenda>();

                int idIdioma = int.Parse(dt.Rows[0]["Id_Idioma"].ToString());
                idiom.Id = idIdioma;

                foreach (DataRow fila in dt.Rows)
                {
                    Leyenda transitorio = new Leyenda();
                    transitorio._textoLabel = fila[2].ToString();
                    transitorio._nombreEtiqueta = fila[3].ToString();

                    ley.Add(transitorio);
                }
                idiom.Leyendas = ley;
                Servicios.Sesion.GetInstance.usuario.Idioma = idiom;
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Cambio de idioma a " + idIdioma, "Ninguno"));
            }

            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer idioma"); }
            #endregion
        }
        public void CambiarIDIdiomaDeUsuarioDAL(BE_Idioma Idioma)
        {
            String query = "UPDATE Usuario SET id_idioma = '" + Idioma.Id + "' WHERE Id_Usuario = '" + Servicios.Sesion.GetInstance.usuario.IdUsuario + "'";
            SqlCommand command = new SqlCommand(query);
            try
            {
                int i = Acceso.Instance.ExecuteNonQuery(command);
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar CAMBIAR idioma del usuario"); }
            //if (i == 1)
            //{
            //    BE.Usuario.Instance.Idioma = idIdioma;
            //}
        }

        public List<BE.ObserverIdioma.BE_Idioma> IdiomasExistentes()
        {
            String qry = "SELECT Idioma FROM [Idioma]";
            SqlCommand command = new SqlCommand(qry);
            List<BE.ObserverIdioma.BE_Idioma> ListadoIdioma = new List<BE.ObserverIdioma.BE_Idioma>();
            try
            {
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                foreach (DataRow fila in dt.Rows)
                {
                    BE.ObserverIdioma.BE_Idioma transitorio = new BE.ObserverIdioma.BE_Idioma();
                    transitorio.NombreIdioma = fila[0].ToString();
                    ListadoIdioma.Add(transitorio);
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Error al intentar traer idiomas"); }
            return ListadoIdioma;
        }
    }
}

