using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BusquedaDAL
    {
        /// <summary>
        /// Devuelve todos los IDs de Usuarios
        /// </summary>
        /// <returns></returns>
        public List<BE_Usuario> TraerUsuarios()
        {
            List<BE_Usuario> users = new List<BE_Usuario>();
            try
            {
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.CommandText = "SELECT Id_Usuario, Usuario from Usuario";

                DataTable dt = Acceso.Instance.ExecuteDataTable(sqlcomm);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr != null)
                    {
                        BE_Usuario us = new BE_Usuario();
                        us.IdUsuario = (int)dr[0];
                        us.User = dr[1].ToString();
                        users.Add(us);
                    }
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un problema al traer los ids de usuarios");
            }
            return users;
        }


    }
}

