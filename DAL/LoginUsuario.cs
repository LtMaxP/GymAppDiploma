using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginUsuario
    {
        Conexion conn = new Conexion();
        public bool BuscarUsuarioBD(string user, string pass)
        {
            conn.Conectar();
            SqlCommand sqlcomm = new SqlCommand("SELECT * FROM Usuario WHERE usuario.Usuario = " + user + " AND Usuario.Password = " + pass );
            SqlDataReader sqlDR = sqlcomm.ExecuteReader();
            return true;
        }
    }
}
