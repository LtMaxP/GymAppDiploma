using BE.Composite;
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

                BE.Composite.Component Permisos = new BE.Composite.Composite("0", "Arbol");

                foreach (DataRow element in dt.Rows)
                {
                    if (!String.IsNullOrEmpty(element["Tipo"].ToString()))
                    {
                        BE.Composite.Component newcompo = null;
                        if (element[3].ToString().Contains("F"))
                        {
                            newcompo = ArmarArbolConIdPadre(new BE.Composite.Composite(element[1].ToString(), element[2].ToString()));
                            Permisos.Agregar(newcompo);
                        }
                        else if (element[3].ToString().Contains("P"))
                        {
                            Permisos.Agregar(new BE.Composite.Hoja(element[1].ToString(), element[2].ToString()));
                        }
                    }
                    Permisos.Agregar(Permisos);
                }
                BE.Usuario.Instance.Permisos = Permisos;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }
        }

        /// <summary>
        /// Obtener los permisos del usuario enviado
        /// </summary>
        public BE.BE_Usuario PermisosPorUsuario(BE.BE_Usuario user)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PermisosUsuarios.Id_Usuario, PermisosUsuarios.Id_Permiso, PerfilPyF.Nombre, PerfilPyF.Tipo
                                    FROM PermisosUsuarios
                                    inner join PerfilPyF ON
                                    PerfilPyF.Id_Perfil = PermisosUsuarios.Id_Permiso
                                    AND Id_Usuario = @id;";
                comm.Parameters.AddWithValue("@id", user.IdUsuario);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);

                BE.Composite.Component Permisos = new BE.Composite.Composite("0", "Arbol");

                foreach (DataRow element in dt.Rows)
                {
                    if (!String.IsNullOrEmpty(element["Tipo"].ToString()))
                    {
                        BE.Composite.Component newcompo = null;
                        if (element[3].ToString().Contains("F"))
                        {
                            newcompo = ArmarArbolConIdPadre(new BE.Composite.Composite(element[1].ToString(), element[2].ToString()));
                            Permisos.Agregar(newcompo);
                        }
                        else if (element[3].ToString().Contains("P"))
                        {
                            Permisos.Agregar(new BE.Composite.Hoja(element[1].ToString(), element[2].ToString()));
                        }
                    }
                    Permisos.Agregar(Permisos);
                }
                user.Permisos = Permisos;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }
            return user;
        }

        public BE.Composite.Component ArmarArbolConIdPadre(BE.Composite.Component cmp)
        {
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
                            newcompo = ArmarArbolConIdPadre(new BE.Composite.Composite(element[0].ToString(), element[1].ToString()));
                            cmp.Agregar(newcompo);
                        }
                        else if (element[2].ToString().Contains("P"))
                        {
                            cmp.Agregar(new BE.Composite.Hoja(element[0].ToString(), element[1].ToString()));
                        }
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return cmp;
        }

        public List<Component> TraerFamiliasOPatentesDAL(string fop)
        {
            List<Component> compoList = new List<Component>();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT * FROM [PerfilPyF] WHERE Tipo = @charFoP";
                comm.Parameters.AddWithValue("@charFoP", fop);
                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    compoList.Add(new Hoja(dr[0].ToString(), dr[1].ToString()));
                }
            }
            catch
            { }
            return compoList;
        }
        /// <summary>
        /// Trae todos los componentes de la lista para mostrar
        /// </summary>
        /// <returns></returns>
        public Component TraerTodoFamiliasOPatentesDALNEW()
        {
            Component compoList = new BE.Composite.Composite("0", "Arbol");
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT * FROM [PerfilPyF]";
                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);

                foreach (DataRow element in dt.Rows)
                {
                    BE.Composite.Component newcompo = null;

                    if (!String.IsNullOrEmpty(element[0].ToString()))
                    {
                        if (element[2].ToString().Contains("F"))
                        {
                            newcompo = ArmarArbolConIdPadre(new BE.Composite.Composite(element[0].ToString(), element[1].ToString()));
                            if (!compoList.VerificarSiExiste(newcompo))
                            {
                                compoList.Agregar(newcompo);
                            }
                        }
                        else if (element[2].ToString().Contains("P"))
                        {
                            newcompo = new BE.Composite.Hoja(element[0].ToString(), element[1].ToString());
                            if (!compoList.VerificarSiExiste(newcompo))
                            {
                                compoList.Agregar(newcompo);
                            }
                        }
                    }
                }
            }
            catch
            { }
            return compoList;
        }

        /// <summary>
        /// Valida si el usuario existe
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Boolean DetectarUsuario(BE.BE_Usuario user)
        {
            Boolean returnable = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "select CASE WHEN count(*) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @user;";
            sqlcomm.Parameters.AddWithValue("@user", user.User);
            try
            {
                returnable = Acceso.Instance.ExecuteScalarBool(sqlcomm);
            }
            catch { System.Windows.Forms.MessageBox.Show("No se encontro el usuario"); }

            return returnable;
        }
        /// <summary>
        /// Funcionalidades para crear la familia
        /// </summary>
        /// <param name="newFamilia"></param>
        /// <param name="familiaNombre"></param>
        /// <returns></returns>
        public bool CrearFamilia(Composite newFamilia, string familiaNombre)
        {
            //validar q no existe ya
            ValidarSiYaExiste();
            //crear aca y sacar el id [PerfilPyF] 
            int fam = GenerarFamilia(familiaNombre);
            //Hacer la relacion de cada idPerfil aca [PermisosRelacion]
            GenerarRelacionesPatenteFamilia(fam);
            return true;
        }
        private void ValidarSiYaExiste()
        {

        }
        private int GenerarFamilia(string familiaNombre)
        {

            return 1;
        }
        private bool GenerarRelacionesPatenteFamilia(int familia)
        {
            return true;
        }
    }
}
