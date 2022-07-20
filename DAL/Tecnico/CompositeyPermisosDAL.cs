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

        /// <summary>
        /// Con el usuario que le pases te va a devolver un listo con: el Usuario, Los permisos asociados, el nombre de cada permiso y el Tipo si es P o F (Patente/Familia)
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public List<BE.Compositex> ObtenerPermisoUsuario(int idUsuario)
        {
            List<BE.Compositex> listPermisos = new List<BE.Compositex>();

            //BE.Composite compo = new BE.Composite("idusuario", "idComponente", "descripcion", "idcomponenteHijo");
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosUsuarios.Id_Usuario, PermisosUsuarios.Id_Permiso, PerfilPyF.Nombre, PerfilPyF.Tipo
                                    FROM PermisosUsuarios
                                    inner join PerfilPyF ON
                                    PerfilPyF.Id_Perfil = PermisosUsuarios.Id_Permiso
                                    AND Id_Usuario = @id;";
                comm.Parameters.AddWithValue("@id", idUsuario);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);

                foreach (DataRow dr in dt.Rows)//esto es al pedo porq te traeria 1 Row
                {
                    if (!String.IsNullOrEmpty(dr["Id_Permiso"].ToString()))
                    {
                        listPermisos.Add(new BE.Compositex(idUsuario.ToString(), dr["Id_Permiso"].ToString(), dr["Nombre"].ToString(), "hijos", dr["Tipo"].ToString()));
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return listPermisos;
        }

        /// <summary>
        /// Inicio de la obtencion de permisos al usuario logeado
        /// </summary>
        public void NewObtenerPermisoUsuario()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosUsuarios.Id_Usuario, PermisosUsuarios.Id_Permiso, PerfilPyF.Nombre, PerfilPyF.Tipo
                                    FROM PermisosUsuarios
                                    inner join PerfilPyF ON
                                    PerfilPyF.Id_Perfil = PermisosUsuarios.Id_Permiso
                                    AND Id_Usuario = @id;";
                comm.Parameters.AddWithValue("@id", BE.Usuario.Instance.IdUsuario);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);

                BE.Composite.Component Permisos = new BE.Composite.Composite();

                foreach (DataRow element in dt.Rows)
                {
                    if (!String.IsNullOrEmpty(element["Tipo"].ToString()))
                    {
                        BE.Composite.Component newcompo = null;
                        if (element[3].ToString().Contains("F"))
                        {
                            //newcompo = new BE.Composite.Composite(element[1].ToString(), element[2].ToString());
                            newcompo = ArmarArbolConIdPadre(new BE.Composite.Composite(element[1].ToString(), element[2].ToString()));
                            Permisos.Agregar(newcompo);
                        }
                        else if (element[3].ToString().Contains("P"))
                        {
                            newcompo = new BE.Composite.Hoja(element[1].ToString(), element[2].ToString());
                            Permisos.Agregar(newcompo);
                        }
                    }
                    Permisos.Agregar(Permisos);
                }
                BE.Usuario.Instance.Permisos = Permisos;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

        }

        /// <summary>
        /// Pasandole el Perfil a buscar, devuelve los perfiles a los que tiene asociado y aclara si son P o F así si son F, los tenes q volvera buscar vos
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <returns></returns>
        public List<BE.Compositex> ObtenerPerfilConTipo(string idPerfil)
        {
            List<BE.Compositex> listPermisos = new List<BE.Compositex>();

            //BE.Composite compo = new BE.Composite("idusuario", "idComponente", "descripcion", "idcomponenteHijo");
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosRelacion.Id_Perfil, PerfilPyF.Nombre, PerfilPyF.Tipo
                                        FROM PermisosRelacion
                                        inner join PerfilPyF on PermisosRelacion.Id_Padre = @id
                                        AND PerfilPyF.Id_Perfil = PermisosRelacion.Id_Perfil;";
                comm.Parameters.AddWithValue("@id", idPerfil);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    if (!String.IsNullOrEmpty(dr["Id_Perfil"].ToString()) & !idPerfil.Equals(dr["Id_Perfil"].ToString()))///////isnot the same idPerfil
                    {
                        listPermisos.Add(new BE.Compositex("", dr["Id_Perfil"].ToString(), dr["Nombre"].ToString(), "hijos", dr["Tipo"].ToString()));
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return listPermisos;
        }
        public void NewObtenerPerfilConTipoUsuario()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosRelacion.Id_Perfil, PerfilPyF.Nombre, PerfilPyF.Tipo
                                        FROM PermisosRelacion
                                        inner join PerfilPyF on PermisosRelacion.Id_Padre = @id
                                        AND PerfilPyF.Id_Perfil = PermisosRelacion.Id_Perfil;";
                comm.Parameters.AddWithValue("@id", BE.Usuario.Instance.IdUsuario);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    if (!String.IsNullOrEmpty(dr["Tipo"].ToString()) && Equals("P"))
                    {
                        BE.Usuario.Instance.Permisos.Agregar(new BE.Composite.Composite(dr["Id_Permiso"].ToString(), dr["Nombre"].ToString()));
                    }
                    else if (!String.IsNullOrEmpty(dr["Tipo"].ToString()) && Equals("F"))
                    {
                        BE.Usuario.Instance.Permisos.Agregar(new BE.Composite.Hoja(dr["Id_Permiso"].ToString(), dr["Nombre"].ToString()));
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

        }
        public BE.Composite.Component ArmarArbolConIdPadre(BE.Composite.Component cmp)
        {
            BE.Composite.Component Permisos = new BE.Composite.Composite(cmp.iDPatente, cmp.descripcion);
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosRelacion.Id_Perfil, PerfilPyF.Nombre, PerfilPyF.Tipo
                                        FROM PermisosRelacion
                                        inner join PerfilPyF on PermisosRelacion.Id_Padre = @id
                                        AND PerfilPyF.Id_Perfil = PermisosRelacion.Id_Perfil;";
                comm.Parameters.AddWithValue("@id", cmp.iDPatente);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow element in dt.Rows)
                {
                    BE.Composite.Component newcompo = null;

                    if (!String.IsNullOrEmpty(element[0].ToString()))
                    {
                        if (element[2].ToString().Contains("F"))
                        {
                            newcompo = new BE.Composite.Composite(element[0].ToString(), element[1].ToString());
                            Permisos.Agregar(newcompo);
                            newcompo = ArmarArbolConIdPadre(newcompo);
                        }
                        else if (element[2].ToString().Contains("P"))
                        {
                            newcompo = new BE.Composite.Hoja(element[0].ToString(), element[1].ToString());
                            Permisos.Agregar(newcompo);
                        }
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return Permisos;
        }
        /// <summary>
        /// Cargar usuario con Permisos
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public void CargarPermisoUsuario()
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosUsuarios.Id_Usuario, PermisosUsuarios.Id_Permiso, PerfilPyF.Nombre, PerfilPyF.Tipo
                                    FROM PermisosUsuarios
                                    inner join PerfilPyF ON
                                    PerfilPyF.Id_Perfil = PermisosUsuarios.Id_Permiso
                                    AND Id_Usuario = @id;";
                comm.Parameters.AddWithValue("@id", BE.Usuario.Instance.IdUsuario);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)//esto es al pedo porq te traeria 1 Row
                {
                    if (!String.IsNullOrEmpty(dr["Tipo"].ToString()) && Equals("P"))
                    {
                        BE.Usuario.Instance.Permisos.Agregar(new BE.Composite.Composite(dr["Id_Permiso"].ToString(), dr["Nombre"].ToString()));
                    }
                    else if (!String.IsNullOrEmpty(dr["Tipo"].ToString()) && Equals("F"))
                    {
                        BE.Usuario.Instance.Permisos.Agregar(new BE.Composite.Hoja(dr["Id_Permiso"].ToString(), dr["Nombre"].ToString()));
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }
        }




    }
}
