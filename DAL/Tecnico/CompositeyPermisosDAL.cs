using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CompositeyPermisosDAL
    {
        public void CompoDAL()
        {

        }

        public void LlenarIdsComposita()
        {
            bool respuesta = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = Acceso.Instance.sqlCon;
                comm.CommandText = "Select Id_perfil, Id_Padre FROM PermisosRelacion;";
                comm.Parameters.AddWithValue("@nombre", BE.Usuario.Instance.IdUsuario.ToString());

                comm.Connection.Open();
                respuesta = bool.Parse(comm.ExecuteScalar().ToString());
                comm.Connection.Close();
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de Leer la tabla."); }

        }

        /// <summary>
        /// Con el usuario que le pases te va a devolver un listo con: el Usuario, Los permisos asociados, el nombre de cada permiso y el Tipo si es P o F (Patente/Familia)
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public List<BE.Composite> ObtenerPermisoUsuario(string idUsuario)
        {
            List<BE.Composite> listPermisos = new List<BE.Composite>();

            //BE.Composite compo = new BE.Composite("idusuario", "idComponente", "descripcion", "idcomponenteHijo");
            try
            {
                DataSet ds = new DataSet();
                SqlCommand comm = new SqlCommand();
                comm.Connection = Acceso.Instance.sqlCon;
                comm.CommandText = @"SELECT PermisosUsuarios.Id_Usuario, PermisosUsuarios.Id_Permiso, PerfilPyF.Nombre, PerfilPyF.Tipo
                                    FROM PermisosUsuarios
                                    inner join PerfilPyF ON
                                    PerfilPyF.Id_Perfil = PermisosUsuarios.Id_Permiso
                                    AND Id_Usuario = @id;";
                comm.Parameters.AddWithValue("@id", idUsuario);
                SqlDataAdapter da = new SqlDataAdapter(comm);

                comm.Connection.Open();
                da.Fill(ds);
                comm.Connection.Close();
                foreach (DataRow dr in ds.Tables[0].Rows)//esto es al pedo porq te traeria 1 Row
                {
                    if (!String.IsNullOrEmpty(dr["Id_Permiso"].ToString()))
                    {
                        listPermisos.Add(new BE.Composite(idUsuario, dr["Id_Permiso"].ToString(), dr["Nombre"].ToString(), "hijos", dr["Tipo"].ToString()));
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return listPermisos;
        }


        /// <summary>
        /// Pasandole el Perfil a buscar, devuelve los perfiles a los que tiene asociado y aclara si son P o F así si son F, los tenes q volvera buscar vos
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <returns></returns>
        public List<BE.Composite> ObtenerPerfilConTipo(string idPerfil)
        {
            List<BE.Composite> listPermisos = new List<BE.Composite>();

            //BE.Composite compo = new BE.Composite("idusuario", "idComponente", "descripcion", "idcomponenteHijo");
            try
            {
                DataSet ds = new DataSet();
                SqlCommand comm = new SqlCommand();
                comm.Connection = Acceso.Instance.sqlCon;
                comm.CommandText = @"SELECT PermisosRelacion.Id_Perfil, PerfilPyF.Nombre, PerfilPyF.Tipo
                                        FROM PermisosRelacion
                                        inner join PerfilPyF on PermisosRelacion.Id_Padre = @id
                                        AND PerfilPyF.Id_Perfil = PermisosRelacion.Id_Perfil;";
                comm.Parameters.AddWithValue("@id", idPerfil);
                SqlDataAdapter da = new SqlDataAdapter(comm);

                comm.Connection.Open();
                da.Fill(ds);
                comm.Connection.Close();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (!String.IsNullOrEmpty(dr["Id_Perfil"].ToString()) & !idPerfil.Equals(dr["Id_Perfil"].ToString()))///////isnot the same idPerfil
                    {
                        listPermisos.Add(new BE.Composite("", dr["Id_Perfil"].ToString(), dr["Nombre"].ToString(), "hijos", dr["Tipo"].ToString()));
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return listPermisos;
        }






    }
}
