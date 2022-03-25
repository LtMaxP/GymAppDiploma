using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Singleton
    {
        //private const string sqlConnect = "Data Source=DESKTOP-N4A8Q47\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True"; //nb
        //private string ruta = "Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";//PCFija

        private SqlCommand sqlCommand { get; set; }

        public SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True");

        private Singleton()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public int ExecuteScalar(SqlCommand _paramCommand)
        {
            if(sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
            _paramCommand.Connection = sqlCon;
            sqlCon.Open();
            return Convert.ToInt32(_paramCommand.ExecuteScalar());
        }

        public DataTable ExecuteDataTable(SqlCommand _paramCommand)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            } 
            try
            {
                DataTable _dt = new DataTable();
                SqlDataAdapter _dataAdapter = new SqlDataAdapter(_paramCommand);
                _dataAdapter.Fill(_dt);
                return _dt;
            }
            catch (Exception e)
            { throw e; }
        }
    }
}
