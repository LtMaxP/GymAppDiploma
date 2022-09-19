using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tecnico
{
    public class RestoreDAL
    {
        public void GenerarRestore(string ruta)
        {
            try
            {
                string query = null;
                query = @"USE master
                            ALTER DATABASE GymApp
                            SET SINGLE_USER WITH ROLLBACK IMMEDIATE

                            RESTORE DATABASE GymApp FROM DISK = '" + ruta + "'" + " WITH REPLACE " +
                            "ALTER DATABASE GymApp SET MULTI_USER";
                SqlCommand cmd = new SqlCommand(query);
                Acceso.Instance.ExecuteNonQuery(cmd);
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Es generando Restore en BD", "Ninguno"));
            }
            catch (Exception)
            {
                DAL.BitacoraDAL.NewRegistrarBitacora(Servicios.BitacoraServicio.RegistrarMovimiento("Problema generando Restore en BD", "Bajo"));
                throw new Exception("Error al realizar Restore");
            }
        }
    }
}
