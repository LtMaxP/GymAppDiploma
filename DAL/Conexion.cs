using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class Conexion
    {
        protected string cadenaConexion = "Data Source=GONZALO-PC\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";
        protected SqlConnection sqlConn = new SqlConnection();
        private static Conexion instancia;

        private Conexion()
        {
            sqlConn.ConnectionString = cadenaConexion;
        }

        public static Conexion getInstance()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
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
