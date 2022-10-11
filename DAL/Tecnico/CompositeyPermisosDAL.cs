using BE;
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
                comm.Parameters.AddWithValue("@id", Servicios.Sesion.GetInstance.usuario.IdUsuario);

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
                }
                Servicios.Sesion.GetInstance.usuario.Permisos = Permisos;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }
        }

        public void QuitarPermisosUsuario(BE_Usuario user)
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = @"DELETE FROM [GymApp].[dbo].[PermisosRelacion] WHERE [Id_Usuario] = @idUser";
            sqlcomm.Parameters.AddWithValue("@idUser", user.IdUsuario);

            try
            {
                Acceso.Instance.ExecuteNonQuery(sqlcomm);
            }
            catch { }
        }

        public bool GuardarPermisosAsignados(Component permisos, BE_Usuario user)
        {
            bool returnable = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "INSERT INTO [PermisosUsuarios] ([Id_Permiso], [Id_Usuario]) VALUES (@Id_Permiso, @Id_Usuario)";
            sqlcomm.Parameters.Add("@Id_Permiso", SqlDbType.Int);
            sqlcomm.Parameters.Add("@Id_Usuario", SqlDbType.Int);
            try
            {
                foreach (var perfil in permisos.List())
                {
                    sqlcomm.Parameters["@Id_Permiso"].Value = perfil.iDPatente;
                    sqlcomm.Parameters["@Id_Usuario"].Value = user.IdUsuario;
                    Acceso.Instance.ExecuteNonQuery(sqlcomm);
                }
                returnable = true;
            }
            catch
            { }

            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se modificaron los permisos en usuario " + user.User, "Ninguno"));
            return returnable;
        }

        public bool EliminarFamilia(int idFam)
        {
            bool rpta = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = @"DELETE FROM [GymApp].[dbo].[PerfilPyF] WHERE [Id_Perfil] = @idFam
                                    DELETE FROM [GymApp].[dbo].[PermisosRelacion] WHERE [Id_Padre] = @idFam";
            sqlcomm.Parameters.AddWithValue("@idFam", idFam);

            try
            {
                int i = Acceso.Instance.ExecuteNonQuery(sqlcomm);
                if (i > 1)
                    rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("No se pudo eliminar la familia"); }
            return rpta;
        }

        /// <summary>
        /// Devolveme el id del Perfil por su nombre
        /// </summary>
        /// <param name="nombreFamilia"></param>
        /// <returns></returns>
        public int DameIdPorNombre(string nombreFamilia)
        {
            int returnable = 404;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "SELECT Id_Perfil FROM [GymApp].[dbo].[PerfilPyF] WHERE [Nombre] =  @nombre";
            sqlcomm.Parameters.AddWithValue("@nombre", nombreFamilia);

            try
            {
                returnable = Acceso.Instance.ExecuteScalar(sqlcomm);
            }
            catch { System.Windows.Forms.MessageBox.Show("No se encontró la familia"); }

            return returnable;
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
                            if (!cmp.VerificarSiExiste(newcompo)) //easdasfasdas
                            {
                                cmp.Agregar(newcompo);
                            }
                        }
                        else if (element[2].ToString().Contains("P"))
                        {
                            newcompo = new BE.Composite.Hoja(element[0].ToString(), element[1].ToString());
                            if (!cmp.VerificarSiExiste(newcompo))
                            {
                                cmp.Agregar(newcompo);
                            }
                        }
                    }
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }

            return cmp;
        }

        /// <summary>
        /// Trae todos los componentes de la lista para mostrar SUELTO
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
                            compoList.Agregar(newcompo);
                        }
                        else if (element[2].ToString().Contains("P"))
                        {
                            newcompo = new BE.Composite.Hoja(element[0].ToString(), element[1].ToString());
                            compoList.Agregar(newcompo);
                        }
                    }
                }
            }
            catch
            { }
            return compoList;
        }

        private void ReiteracionCompo(Component compoList, Component newcompo)
        {
            foreach (var node in compoList.List())
            {
                if (newcompo.VerificarSiExiste(node))
                {
                    compoList.Eliminar(node);
                }
            }
        }

        /// <summary>
        /// Trae todos los componentes de la lista para mostrar AGRUPADO
        /// </summary>
        /// <returns></returns>
        public Component TraerComponentesAgrupadosDAL()
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
                                ReiteracionCompo(compoList, newcompo); //fijate si aca o en ArmarArbol, si se repite algo eliminalo
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
        /// Funcionalidades para crear la familia
        /// </summary>
        /// <param name="newFamilia"></param>
        /// <param name="familiaNombre"></param>
        /// <returns></returns>
        public bool CrearFamilia(Composite newFamilia, string familiaNombre)
        {
            bool returnable = false;
            if (!ValidarSiYaExiste(familiaNombre))
            {
                int fam = GenerarFamilia(familiaNombre);
                if (fam != 0)
                {
                    returnable = GenerarRelacionesPatenteFamilia(newFamilia, fam);
                    DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se creo una nueva Familia " + familiaNombre, "Ninguno"));
                }
            }
            return returnable;
        }

        /// <summary>
        /// Valida si ya existe la familia
        /// </summary>
        /// <param name="newFamilia"></param>
        /// <returns></returns>
        private bool ValidarSiYaExiste(string familiaNombre)
        {
            bool returnable = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "select CASE WHEN count(*) > 0 THEN 'true' ELSE 'false' END from [GymApp].[dbo].[PerfilPyF] where [Nombre] =  @nombre";
            sqlcomm.Parameters.AddWithValue("@nombre", familiaNombre);

            try
            {
                returnable = Acceso.Instance.ExecuteScalarBool(sqlcomm);
            }
            catch { System.Windows.Forms.MessageBox.Show("Validacion - Familia ya existente"); }

            return returnable;
        }

        /// <summary>
        /// Crea nueva familia y devuelve el ID de la creación bajo un SP
        /// </summary>
        /// <param name="familiaNombre"></param>
        /// <returns></returns>
        private int GenerarFamilia(string familiaNombre)
        {
            int returnable = 0;
            try
            {
                var sqlCmd = Acceso.Instance.CrearCommandStoredProcedure("CrearFamilia");
                sqlCmd.Parameters.Add("@NombreFamilia", SqlDbType.VarChar).Value = familiaNombre;
                returnable = Acceso.Instance.ExecuteSPWithReturnable(sqlCmd);
            }
            catch { System.Windows.Forms.MessageBox.Show("No se pudo generar la familia SP"); }
            return returnable;
        }

        /// <summary>
        /// Crea las relaciones pertinentes a la nueva familia previamente creada
        /// </summary>
        /// <param name="newFamilia"></param>
        /// <param name="familia"></param>
        /// <returns></returns>
        private bool GenerarRelacionesPatenteFamilia(Composite newFamilia, int familia)
        {
            bool ret = true;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "INSERT INTO [PermisosRelacion] ([Id_Perfil], [Id_Padre]) VALUES (@ID_PERFIL, @ID_PADRE)";
            sqlcomm.Parameters.Add("@ID_PERFIL", SqlDbType.Int);
            sqlcomm.Parameters.Add("@ID_PADRE", SqlDbType.Int);
            try
            {
                foreach (var perfil in newFamilia.List())
                {
                    if (perfil is Composite)
                    {
                        sqlcomm.Parameters["@ID_PERFIL"].Value = perfil.iDPatente;
                        sqlcomm.Parameters["@ID_PADRE"].Value = familia;
                    }
                    else
                    {
                        sqlcomm.Parameters["@ID_PERFIL"].Value = perfil.iDPatente;// esto si es compo o una hoja es por las dudas q se requiera
                        sqlcomm.Parameters["@ID_PADRE"].Value = familia;
                    }
                    Acceso.Instance.ExecuteNonQuery(sqlcomm);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("No se pudo generar los permisos familia");
                ret = false;
            }
            return ret;
        }
    }
}
