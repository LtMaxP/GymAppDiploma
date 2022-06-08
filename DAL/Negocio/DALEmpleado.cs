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
    public class DALEmpleado
    {
        
        public DataTable DameEmpleados()
        {
            DataTable dt = new DataTable();
            String query = "select * from Empleado";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }
        public DataTable DameProfesores()
        {
            DataTable dt = new DataTable();
            String query = "select * from Empleado where id_Trabajo between 1 AND 4";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }
        public DataTable DameAsistentes()
        {
            DataTable dt = new DataTable();
            String query = "select * from Empleado where id_Trabajo = 5";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }
        public DataTable DameProfesorPorTipo(string trabajo)
        {
            DataTable dt = new DataTable();
            String query = "Select * from Empleado where id_Trabajo = (select id_Trabajo from Trabajo where Descripcion = '@trabajo')";
            SqlCommand command = new SqlCommand(query, Acceso.Instance.sqlCon);
            command.Parameters.AddWithValue("@trabajo", trabajo);
            dt = Acceso.Instance.ExecuteDataTable(command);
            return dt;
        }
    }
}
