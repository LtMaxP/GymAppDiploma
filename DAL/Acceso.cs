using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection SQLC = null;
        private SqlTransaction tx;

        private static Acceso instance;
        public static Acceso Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Acceso();
                }
                return instance;
            }
        }
        /// <summary>
        /// Consulta que retorna 1 valor int
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public int ExecuteScalar(SqlCommand _paramCommand)
        {
            try
            {
                _paramCommand.Connection = Abrir();
                var returnable = _paramCommand.ExecuteScalar();
                Cerrar();
                return Convert.ToInt32(returnable);
            }
            catch (Exception e) { throw e; }
        }
        /// <summary>
        /// Consulta que retorna 1 valor int String
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public String ExecuteScalar2(SqlCommand _paramCommand)
        {
            try
            {
                _paramCommand.Connection = Abrir();
                String returnable = _paramCommand.ExecuteScalar().ToString();
                Cerrar();
                return returnable;
            }
            catch (Exception e) { throw e; }
        }
        /// <summary>
        /// Consulta y devuelve por true o false
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public Boolean ExecuteScalarBool(SqlCommand _paramCommand)
        {
            try
            {
                _paramCommand.Connection = Abrir();
                Boolean returnable = Convert.ToBoolean(_paramCommand.ExecuteScalar());
                Cerrar();
                return returnable;
            }
            catch (Exception e) { throw e; }
        }
        /// <summary>
        /// Clase que impacta en la base de datos
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(SqlCommand _paramCommand)
        {
            try
            {
                _paramCommand.Connection = Abrir();
                var returnable = _paramCommand.ExecuteNonQuery();
                Cerrar();
                return Convert.ToInt32(returnable);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //-
        public int Escribir(string nombre, List<SqlParameter> parametros)
        {
            try
            {
                SqlCommand cmd = CrearComando2(nombre, parametros);
                var returnable = cmd.ExecuteNonQuery();
                Cerrar();
                return Convert.ToInt32(returnable);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Clase Acceso para Traer Data Tables
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(SqlCommand _paramCommand)
        {
            DataTable _dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                try
                {
                    _paramCommand.Connection = Abrir();
                    da.SelectCommand = _paramCommand;
                    da.Fill(_dt);
                    Cerrar();
                }
                catch (Exception e)
                { throw e; }
            }
            return _dt;
        }
        /// <summary>
        /// Crear comando SP
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public SqlCommand CrearComando2(string nombre, List<SqlParameter> pars)
        {
            SqlCommand cmd = new SqlCommand(nombre, SQLC);
            if (tx != null)
            {
                cmd.Transaction = tx;
            }
            if (pars != null && pars.Count > 0)
            {
                cmd.Parameters.AddRange(pars.ToArray());
            }
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
        public SqlCommand CrearComando(string nombre, SqlParameter pars)
        {
            SqlCommand cmd = new SqlCommand(nombre, Abrir());
            if (tx != null)
            {
                cmd.Transaction = tx;
            }
            if (pars != null)
            {
                cmd.Parameters.Add(pars);
            }
            return cmd;
        }
        /// <summary>
        /// Clase que ingresan parametros y retorna dataTable ||||| Reveer
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable2(SqlCommand _paramCommand, List<IDbDataParameter> parametros = null)
        {
            try
            {
                DataTable _dt = new DataTable();
                _paramCommand.Connection = Abrir();
                if (parametros != null && parametros.Count > 0)
                {
                    _paramCommand.Parameters.AddRange(parametros.ToArray());
                }
                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_paramCommand);
                _dataAdapter.Fill(_dt);
                return _dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// int returnable
        /// </summary>
        /// <param name="familiaNombre"></param>
        /// <returns></returns>
        public int ExecuteSPWithReturnable(SqlCommand sqlCmd)
        {
            int retval = 0;
            try
            {
                sqlCmd.Connection = Abrir();
                sqlCmd.ExecuteNonQuery();
                retval = (int)sqlCmd.Parameters["@retValue"].Value;
            }
            catch { }
            finally { Cerrar(); }
            return retval;
        }
        /// <summary>
        /// Crear comando SP por nombre
        /// </summary>
        /// <param name="SP"></param>
        /// <returns></returns>
        public SqlCommand CrearCommandStoredProcedure(string SP)
        {
            SqlCommand sqlCmd = new SqlCommand(SP);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@retValue", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            return sqlCmd;
        }
        /// <summary>
        /// Obtener resultados multiples (Por ejemplo, SELECT col1, col2 from sometable)
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public DataTable ExecuteReader(SqlCommand _paramCommand)
        {
            try
            {
                Abrir();
                DataTable _dt = new DataTable();
                _paramCommand.Connection = SQLC;
                _dt.Load(_paramCommand.ExecuteReader());
                Cerrar();
                return _dt;
            }
            catch (Exception e)
            { throw e; }
        }
        /// <summary>
        /// Abrir conexión
        /// </summary>
        private SqlConnection Abrir()
        {
            try
            {
                if (SQLC == null)
                {
                    SQLC = new SqlConnection(ConexionRuta());
                    SQLC.Open();
                }
                else if (SQLC.State == ConnectionState.Open)
                {
                    SQLC.Close();
                    SQLC.Open();
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            return SQLC;
        }
        /// <summary>
        /// Ruta al app.config
        /// </summary>
        /// <returns></returns>
        private string ConexionRuta()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
            return connString;
        }
        /// <summary>
        /// Cerrar conexión
        /// </summary>
        public void Cerrar()
        {
            SQLC.Close();
            SQLC.Dispose();
            SQLC = null;
            GC.Collect();
        }
        /// <summary>
        /// Begin tran
        /// </summary>
        public void ComenzarTransaccion()
        {
            if (tx == null)
            {
                if (SQLC == null)
                {
                    Abrir();
                    tx = SQLC.BeginTransaction();
                }
                else
                    tx = SQLC.BeginTransaction();
            }
        }
        /// <summary>
        /// Rollback ran
        /// </summary>
        public void CancelarTransaccion()
        {
            if (tx != null)
            {
                tx.Rollback();
            }
        }
        /// <summary>
        /// Commit tran
        /// </summary>
        public void ConfirmarTransaccion()
        {
            if (tx != null)
            {
                tx.Commit();
            }
        }
        /// <summary>
        /// Crear comando SP por nombre y con listado de parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="pars"></param>
        /// <returns></returns>
        public SqlCommand CrearComando(string nombre, List<SqlParameter> pars)
        {
            SqlCommand cmd = new SqlCommand(nombre, Abrir());
            if (tx != null)
            {
                cmd.Transaction = tx;
            }
            if (pars != null && pars.Count > 0)
            {
                cmd.Parameters.AddRange(pars.ToArray());
            }
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
