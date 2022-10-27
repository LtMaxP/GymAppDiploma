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
            String query = @"select nombre, apellido, T.Descripcion, C.Cantidad, Es.Id_Estado 
                                    from Empleado E inner join Trabajo T on T.Id_Trabajo = E.id_Trabajo inner join Cuenta C on E.id_Cuenta = C.Id_Cuenta inner join Estado Es on Es.Id_Estado = E.Id_Estado";
            SqlCommand command = new SqlCommand(query);

            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }

        public DataTable TraerTrabajos()
        {
            DataTable dt = new DataTable();
            String query = "select Descripcion from [Trabajo]";
            SqlCommand command = new SqlCommand(query);
            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }



        public bool Alta(BE_Empleado valAlta)
        {
            return true;
        }

        public bool Baja(BE_Empleado valBaja)
        {
            String query = "select Descripcion from [Trabajo]";
            SqlCommand command = new SqlCommand(query);

            int result = Acceso.Instance.ExecuteNonQuery(command);
            if (result != -1) 
                return true;
            else 
                return false;
        }

        public bool Modificar(BE_Empleado valMod)
        {
            return true;
        }

        public BE_Empleado Leer(BE_Empleado valBuscar)
        {
            return new BE_Empleado();
        }

        public List<BE_Empleado> Leer2(BE_Empleado valBuscar)
        {
            List<BE_Empleado> empleadosList = new List<BE_Empleado>();


            return empleadosList;
        }
    }
}
