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

        public SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True");

        private Acceso()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        private static Acceso instance = null;
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
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
            _paramCommand.Connection = sqlCon;
            sqlCon.Open();
            return Convert.ToInt32(_paramCommand.ExecuteScalar());
        }

        public int ExecuteNonQuery(SqlCommand _paramCommand)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
            _paramCommand.Connection = sqlCon;
            sqlCon.Open();
            return Convert.ToInt32(_paramCommand.ExecuteNonQuery());
        }

        public DataTable ExecuteDataTable(SqlCommand _paramCommand)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
            DataTable _dt = new DataTable();
            try
            {
                //_paramCommand.Connection = sqlCon;
                //sqlCon.Open();
                
                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_paramCommand.CommandText, sqlCon);
                _dataAdapter.Fill(_dt);
            }
            catch (Exception e)
            { throw e; }
            return _dt;
        }
    }
}
