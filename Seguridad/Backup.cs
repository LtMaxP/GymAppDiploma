using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Backup
    {
        private string NameDB = "GymAppFull";
        private string dir = @"C:\BackUps\";

        /// <summary>
        /// Forma el directorio Backup del sistema con nombre
        /// </summary>
        /// <param name="rutaDestino"></param>
        public string BackupBDDir()
        {
            if (!Directory.Exists(dir + NameDB))
                Directory.CreateDirectory(dir + NameDB);
            return dir+NameDB;
        }
    }
}
