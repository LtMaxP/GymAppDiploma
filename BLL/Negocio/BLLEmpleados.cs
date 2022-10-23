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
        DALEmpleado dalemp = new DALEmpleado();

        public List<Persona> DameEmpleados()
        {
            List<Persona> emplist = new List<Persona>();
            DataTable data = dalemp.DameEmpleados();
            foreach (DataRow emp in data.Rows)
            {
                BE_Empleado empleadoActual = new BE_Empleado();
                empleadoActual.Nombre = emp["Nombre"].ToString();
                empleadoActual.Apellido = emp["Apellido"].ToString();
                empleadoActual.Id_Estado = int.Parse(emp["Id_Estado"].ToString());
                empleadoActual.Trabajo = emp["trabajo"].ToString();
                empleadoActual.Cuenta = new BE_Cuenta()
                {
                    Monto = double.Parse(emp["monto"].ToString())
                };
                emplist.Add(empleadoActual);
            }
            return emplist;
        }
        public DataTable CargarComboTrabajos()
        {
            return dalemp.TraerTrabajos();
        }

        public void AltaNuevoEmpleado(BE_Empleado emp)
        {
            dalemp.Alta(emp);
        }

        public void EliminarEmpleado(string dni)
        {
            BE_Empleado emp = new BE_Empleado();
            emp.Dni = int.Parse(dni);
            dalemp.Baja(emp);
        }
    }
}
