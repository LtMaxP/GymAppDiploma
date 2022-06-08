using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Acceso
    {
        //private const string sqlConnect = "Data Source=DESKTOP-N4A8Q47\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True"; //nb
        //private string ruta = "Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";//PCFija

        public SqlConnection sqlCon = null; /* new SqlConnection("Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True");*/
        private SqlConnection SQLC = null;
        //private SqlTransaction TX;

        //private Acceso()
        //{
        //    if (sqlCon.State == ConnectionState.Open)
        //    {
        //        sqlCon.Close();
        //    }
        //}
        public static Acceso instance;
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

        public int ExecuteScalar(SqlCommand _paramCommand)
        {
            Abrir();
            var returnable = _paramCommand.ExecuteScalar();
            Cerrar();
            return Convert.ToInt32(returnable);
        }

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
        private void Abrir()
        {
            try
            {

                if (SQLC == null)
                {
                    SQLC = new SqlConnection("Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True");
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
        public void Cerrar()
        {
            SQLC.Close();
            SQLC.Dispose();
            SQLC = null;
        }
    }
}
