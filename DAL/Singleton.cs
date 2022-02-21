using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Singleton
    {
        //private const string cadenaConexion = "Data Source=DESKTOP-N4A8Q47\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True"; //nb
        private const string cadenaConexion = "Data Source=DESKTOP-SLGG4A0\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";//PCFija

        private SqlConnection sqlConn = new SqlConnection();
        public string ConexionRuta
        {
            get { return cadenaConexion; }
        }

        private Singleton() { }
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
        public void Conectar()
        {
            try
            {
                sqlConn.Open();
                Console.WriteLine("Conexión Exitosa");
            }
            catch
            {
                Console.WriteLine("Conexión Fallida");
            }

        }

        public void Desconectar()
        {
            sqlConn.Close();
        }
    }
}
