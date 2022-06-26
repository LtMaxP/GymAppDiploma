using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using BE.Tecnico;

namespace BLL.Tecnico
{
    public class Backup
    {
        DAL.Tecnico.BackupDAL bk = new DAL.Tecnico.BackupDAL();
        /// <summary>
        /// Crear Backup de la DB
        /// </summary>
        /// <returns></returns>
        public bool BackupBD()
        {
            return bk.BackupDBDAL();
        }
        /// <summary>
        /// Traer listado de los backups hechos
        /// </summary>
        /// <returns></returns>
        public List<BE_BackUp> TraerBackupsBD()
        {
            return bk.TraerBackupDBDAL();
        }
    }
}
