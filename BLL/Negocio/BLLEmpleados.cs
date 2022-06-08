using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLEmpleados
    {

        public List<BE_Empleado> DameEmpleados(int id_Sucursal)
        {
            List<BE_Empleado> emplist = new List<BE_Empleado>();
            DALEmpleado dalemp = new DALEmpleado();
            DataTable data = dalemp.DameEmpleados(id_Sucursal);
            foreach (DataRow emp in data.Rows)
            {
                BE_Empleado empleadoActual = (new Profesor());
                empleadoActual.Id = int.Parse(emp.ItemArray[0].ToString());
                empleadoActual.Nombre = emp.ItemArray[1].ToString();
                empleadoActual.Apellido = emp.ItemArray[2].ToString();
                emplist.Add(empleadoActual);
            }
            return emplist;
        }
    }
}
