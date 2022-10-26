using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class DALEmpleado : ICRUD<BE.BE_Empleado>
    {

        public DataTable DameEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                String query = @"select nombre, apellido, T.Descripcion, C.Cantidad, Es.Id_Estado 
                                    from Empleado E inner join Trabajo T on T.Id_Trabajo = E.id_Trabajo inner join Cuenta C on E.id_Cuenta = C.Id_Cuenta inner join Estado Es on Es.Id_Estado = E.Id_Estado";
                SqlCommand command = new SqlCommand(query);

                dt = Acceso.Instance.ExecuteDataTable(command);
            }
            catch { }
            return dt;
        }

        public DataTable TraerTrabajos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                try
                {
                    String query = "select Descripcion from [Trabajo]";
                    SqlCommand command = new SqlCommand(query);
                    dt = Acceso.Instance.ExecuteDataTable(command);
                }
                catch { }
                return dt;
            }
        }


        public bool Alta(BE_Empleado valAlta)
        {
            bool ret = false;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                try
                {

                    ret = true;
                }
                catch { }
            }
            return ret;
        }

        public bool Baja(BE_Empleado valBaja)
        {
            bool ret = false;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                try
                {
                    String query = "select Descripcion from [Trabajo]";
                    SqlCommand command = new SqlCommand(query);

                    Acceso.Instance.ExecuteNonQuery(command);
                    ret = true;
                }
                catch { }
            }
            return ret;
        }

        public bool Modificar(BE_Empleado valMod)
        {
            bool ret = false;
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                try
                {

                    ret = true;
                }
                catch { }
            }
            return ret;
        }

        public BE_Empleado Leer(BE_Empleado valBuscar)
        {
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                try
                {
                    //valBuscar.
                }
                catch { }
            }
            return valBuscar;
        }

        public List<BE_Empleado> Leer2(BE_Empleado valBuscar)
        {
            List<BE_Empleado> empleadosList = new List<BE_Empleado>();
            using (SqlConnection connection = Acceso.Instance.sqlCon)
            {
                try
                {
                    ///
                }
                catch { }
            }
            return empleadosList;
        }
    }
}
