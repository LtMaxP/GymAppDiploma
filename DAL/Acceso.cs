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
        
        public SqlConnection sqlCon = null; /* new SqlConnection("Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True");*/
        private SqlConnection SQLC = null;
        //private SqlTransaction TX;

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
                Abrir();
                _paramCommand.Connection = SQLC;
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
                Abrir();
                _paramCommand.Connection = SQLC;
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
                Abrir();
                _paramCommand.Connection = SQLC;
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
                Abrir();
                _paramCommand.Connection = SQLC;
                var returnable = _paramCommand.ExecuteNonQuery();
                Cerrar();
                return Convert.ToInt32(returnable);
            }
            catch (Exception e) { throw e; }
        }
        /// <summary>
        /// Clase Acceso para Traer Data Tables
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(SqlCommand _paramCommand)
        {
            try
            {
                Abrir();
                DataTable _dt = new DataTable();
                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_paramCommand);
                _paramCommand.Connection = SQLC;
                _dataAdapter.Fill(_dt);
                Cerrar();
                return _dt;
            }
            catch (Exception e)
            { throw e; }

        }
        /// <summary>
        /// Clase que ingresan parametros y retorna dataTable ||||| Reveer
        /// </summary>
        /// <param name="_paramCommand"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable2(SqlCommand _paramCommand, List<IDbDataParameter> parametros = null)
        {
            DataTable _dt = new DataTable();
            _paramCommand.Connection = SQLC;
            if (parametros != null && parametros.Count > 0)
            {
                _paramCommand.Parameters.AddRange(parametros.ToArray());
            }
            SqlDataAdapter _dataAdapter = new SqlDataAdapter(_paramCommand);
            _dataAdapter.Fill(_dt);
            return _dt;
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
                Abrir();
                sqlCmd.Connection = SQLC;
                sqlCmd.ExecuteNonQuery();
                retval = (int)sqlCmd.Parameters["@retValue"].Value;
            }
            catch { }
            finally { Cerrar(); }
            return retval;
        }
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

        private void Abrir()
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
        }
        private string ConexionRuta()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
            return connString;
        }
        public void Cerrar()
        {
            SQLC.Close();
            SQLC.Dispose();
            SQLC = null;
        }
    }
}
