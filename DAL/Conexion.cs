﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        private string cadenaConexion = "Data Source=GONZALO-PC\\SQLEXPRESS;Initial Catalog=GymApp;Integrated Security=True";
        private SqlConnection sqlConn = new SqlConnection();
        //private static Conexion instancia;

        public Conexion()
        {
            sqlConn.ConnectionString = cadenaConexion;
            
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
