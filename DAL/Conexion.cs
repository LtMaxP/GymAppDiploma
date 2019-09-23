using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        private string cadenaConexionNotebook = "Data Source=DESKTOP-N4A8Q47\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";
        private string cadenaConexionPCFija = "Data Source=DESKTOP-8EVUSLI\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";
        public SqlConnection sqlConn = new SqlConnection();


        public Conexion()
        {
            sqlConn.ConnectionString = cadenaConexionNotebook;
            
        }
        
        //public static Conexion getInstance()
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new Conexion();
        //    }
        //    return instancia;
        //}

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
