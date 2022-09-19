using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using BE.Tecnico;

namespace DAL.Tecnico
{
    public class BackupDAL
    {
        Servicios.Backup bkserv = new Servicios.Backup();
        /// <summary>
        /// Realizar backup de la base de datos
        /// </summary>
        /// <returns></returns>
        public bool BackupDBDAL()
        {
            bool okb = false;
            string path = bkserv.BackupBDDir();
            SqlCommand command = new SqlCommand("BackupRegistry");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@path", SqlDbType.VarChar).Value = path;
            try
            {
                Acceso.Instance.ExecuteNonQuery(command);
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Backup Ok", "Ninguno"));
                okb = true;
            }
            catch
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Backup fallido", "Alto"));
                System.Windows.Forms.MessageBox.Show("Problema al hacer Backup");
            }
            return okb;
        }
        /// <summary>
        /// Traer listado de los Backups de la base de datos
        /// </summary>
        /// <returns></returns>
        public List<BE_BackUp> TraerBackupDBDAL()
        {
            List<BE_BackUp> listBkp = new List<BE_BackUp>();
            SqlCommand command = new SqlCommand();
            command.CommandText = "select path, fecha from [dbo].[BackupTable]";
            try
            {
                DataTable dt = Acceso.Instance.ExecuteDataTable(command);
                foreach (DataRow dr in dt.Rows)//esto es al pedo porq te traeria 1 Row
                {
                    if(!dr.IsNull(1))
                    {
                        listBkp.Add(new BE_BackUp(dr["path"].ToString(), (DateTime)dr["fecha"]));
                    }
                }
                DAL.BitacoraDAL.NewRegistrarBitacora(new BE.Bitacora("Trae listado de backups", "Ninguno"));
            }
            catch 
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(new BE.Bitacora("Problema al traer Backups", "Medio"));
                System.Windows.Forms.MessageBox.Show("Problema al traer Backups");
            }
            return listBkp;
        }
    }
}
