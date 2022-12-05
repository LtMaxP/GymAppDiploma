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
        /// <summary>
        /// Borrar permisos por id de usuario
        /// </summary>
        /// <param name="user"></param>
        public void QuitarPermisosUsuario(BE_Usuario user)
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = @"DELETE FROM [GymApp].[dbo].[PermisosUsuarios] WHERE [Id_Usuario] = @idUser";
            sqlcomm.Parameters.AddWithValue("@idUser", user.IdUsuario);

            try
            {
                Acceso.Instance.ExecuteNonQuery(sqlcomm);
            }
            catch { }
        }
        /// <summary>
        /// Guardar permisos al usuario asignado
        /// </summary>
        /// <param name="permisos"></param>
        /// <param name="user"></param>
        /// <returns></returns>
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
                    if (perfil is Hoja)
                    {
                        sqlcomm.Parameters["@Id_Permiso"].Value = perfil.iDPatente;
                        sqlcomm.Parameters["@Id_Usuario"].Value = user.IdUsuario;
                        Acceso.Instance.ExecuteNonQuery(sqlcomm);
                    }
                    if (perfil is Composite)
                    {
                        sqlcomm.Parameters["@Id_Permiso"].Value = perfil.iDPatente;
                        sqlcomm.Parameters["@Id_Usuario"].Value = user.IdUsuario;
                        Acceso.Instance.ExecuteNonQuery(sqlcomm);
                        GuardarPermisosAsignados(perfil, user);
                    }
                }
                returnable = true;
            }
            catch
            { }

            DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se modificaron los permisos en usuario " + user.User, "Ninguno"));
            return returnable;
        }


        /// <summary>
        /// Eliminar familia y relaciones
        /// </summary>
        /// <param name="idFam"></param>
        /// <returns></returns>
        public bool EliminarFamilia(int idFam)
        {
            bool rpta = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = @"DELETE FROM [GymApp].[dbo].[PerfilPyF] WHERE [Id_Perfil] = @idFam
                                    DELETE FROM [GymApp].[dbo].[PermisosRelacion] WHERE [Id_Perfil] = @idFam OR [Id_Padre] = @idFam
                                    DELETE FROM [GymApp].[dbo].[PermisosUsuarios] WHERE [Id_Permiso] = @idFam";
            sqlcomm.Parameters.AddWithValue("@idFam", idFam);

            try
            {
                int i = Acceso.Instance.ExecuteNonQuery(sqlcomm);
                if (i >= 1)
                    rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("No se pudo eliminar la familia"); }
            return rpta;
        }
        /// <summary>
        /// Eliminar permisos y relaciones
        /// </summary>
        /// <param name="idFam"></param>
        /// <returns></returns>
        public bool EliminarPermisosFamilia(int idFam)
        {
            bool rpta = false;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = @"DELETE FROM [GymApp].[dbo].[PermisosRelacion] WHERE [Id_Padre] = @idFam OR [Id_Perfil] = @idFam ";
            sqlcomm.Parameters.AddWithValue("@idFam", idFam);

            try
            {
                int i = Acceso.Instance.ExecuteNonQuery(sqlcomm);
                if (i > 1)
                    rpta = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("No se pudo eliminar relaciones de la familia"); }
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
        public BE_Usuario PermisosPorUsuario(BE_Usuario user)
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
                            newcompo = ArmarArbolIdUsuarioConsulta(new BE.Composite.Composite(element[1].ToString(), element[2].ToString()), user);
                            //newcompo = ArmarArbolConIdPadre(new BE.Composite.Composite(element[1].ToString(), element[2].ToString()));
                            if (!Permisos.VerificarSiExiste(newcompo))
                            {
                                ReiteracionCompo(Permisos, newcompo);
                                Permisos.Agregar(newcompo);
                            }
                        }
                        else if (element[3].ToString().Contains("P"))
                        {
                            var prm = new BE.Composite.Hoja(element[1].ToString(), element[2].ToString());
                            if (!Permisos.VerificarSiExiste(prm))
                            {
                                Permisos.Agregar(prm);
                            }
                        }
                    }
                }
                //Permisos = ArmarArbolIdUsuarioConsulta(Permisos, user);
                user.Permisos = Permisos;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Obtener PermisosUsuario."); }
            return user;
        }
        /// <summary>
        /// Armar component arbol con IdPadre
        /// </summary>
        /// <param name="cmp"></param>
        /// <returns></returns>
        private Component ArmarArbolConIdPadre(Component cmp)
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
                            if (!cmp.VerificarSiExiste(newcompo))
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

        private Component ArmarArbolIdUsuarioConsulta(Component cmp, BE_Usuario user)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = @"SELECT PR.Id_Perfil, PPF.Nombre, PPF.Tipo, PR.Id_Padre
                                        FROM PermisosRelacion AS PR
                                        inner join PerfilPyF PPF on PPF.Id_Perfil = PR.Id_Perfil 
										INNER JOIN [dbo].[PermisosUsuarios] PU ON PU.Id_Permiso = PR.Id_Perfil
										INNER JOIN [dbo].[Usuario] U ON U.Id_Usuario = PU.Id_Usuario
										WHERE PU.Id_Usuario = @id AND PR.Id_Padre = @id_P";
                comm.Parameters.AddWithValue("@id", user.IdUsuario);
                comm.Parameters.AddWithValue("@id_P", cmp.iDPatente);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow element in dt.Rows)
                {
                    BE.Composite.Component newcompo = null;

                    if (!String.IsNullOrEmpty(element[0].ToString()))
                    {
                        if (element[2].ToString().Contains("F"))
                        {
                            newcompo = ArmarArbolIdUsuarioConsulta(new BE.Composite.Composite(element[0].ToString(), element[1].ToString()), user);
                            if (!cmp.VerificarSiExiste(newcompo))
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
        /// <summary>
        /// Busca repeticion dentro y elimina
        /// </summary>
        /// <param name="compoList"></param>
        /// <param name="newcompo"></param>
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
                                ReiteracionCompo(compoList, newcompo);
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
            int fam = GenerarFamilia(familiaNombre);
            if (fam != 0)
            {
                //RelacionarConPadreAdmin(fam);
                returnable = GenerarRelacionesPatenteFamilia(newFamilia, fam);
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se creo una nueva Familia " + familiaNombre, "Ninguno"));
            }

            return returnable;
        }

        private void RelacionarConPadreAdmin(int fam)
        {
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "INSERT INTO [PermisosRelacion] ([Id_Perfil], [Id_Padre]) VALUES (@ID_PERFIL, @ID_PADRE)";
            sqlcomm.Parameters.AddWithValue("@ID_PERFIL", fam);
            sqlcomm.Parameters.AddWithValue("@ID_PADRE", "15");
            try
            {
                Acceso.Instance.ExecuteNonQuery(sqlcomm);
            }
            catch { }
        }

        /// <summary>
        /// Valida si ya existe la familia
        /// </summary>
        /// <param name="newFamilia"></param>
        /// <returns></returns>
        public bool ValidarSiYaExiste(string familiaNombre)
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
        public bool GenerarRelacionesPatenteFamilia(Composite newFamilia, int familia)
        {
            bool ret = true;
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandText = "INSERT INTO [PermisosRelacion] ([Id_Perfil], [Id_Padre]) VALUES (@ID_PERFIL, @ID_PADRE)";
            sqlcomm.Parameters.Add("@ID_PERFIL", SqlDbType.Int);
            sqlcomm.Parameters.Add("@ID_PADRE", SqlDbType.Int);

            sqlcomm.Parameters["@ID_PERFIL"].Value = familia;
            sqlcomm.Parameters["@ID_PADRE"].Value = 15;
            Acceso.Instance.ExecuteNonQuery(sqlcomm);
            try
            {
                MetodoInsercionContinua(newFamilia, familia, sqlcomm);
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Se Modifico la Familia " + familia, "Ninguno"));
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("No se pudo generar los permisos familia");
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("No se pudo Modificar la Familia " + familia, "Bajo"));
                ret = false;
            }
            return ret;
        }

        private static void MetodoInsercionContinua(Composite newFamilia, int familia, SqlCommand sqlcomm)
        {
            foreach (var perfil in newFamilia.List())
            {
                if (perfil.iDPatente != familia.ToString())
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
                //Esto es para mantener lo que tiene ya dentro del perfil
                else
                {
                    MetodoInsercionContinua((Composite)perfil, familia, sqlcomm);
                }
            }
        }
    }
}
