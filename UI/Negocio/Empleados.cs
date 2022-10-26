using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Empleados : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.BLLEmpleados bllEmp = new BLL.BLLEmpleados();
        public Empleados()
        {
            InitializeComponent();
        }
        public void Update()
        {
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Empleados_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);

            comboBox1.DataSource = bllEmp.CargarComboTrabajos();
            comboBox1.DisplayMember = "Descripcion";
            cmbBoxEmpleado.DataSource = bllEmp.DameEmpleados();
            cmbBoxEmpleado.DisplayMember = "Nombre";
        }
        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelSalir_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
        //--
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Dar de alta nuevo empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAlta_Click(object sender, EventArgs e)
        {
            string name = txtbox_Nombre.Text;
            string apellido = txtbox_Apellido.Text;
            string dni = txtBox_DNI.Text;
            string trabajo = comboBox1.Text;
            string sueldo = txtbox_Sueldo.Text;
            if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(trabajo) || String.IsNullOrEmpty(sueldo))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                BE.BE_Empleado emp = new BE.BE_Empleado();
                emp.Nombre = name;
                emp.Apellido = apellido;
                emp.Dni = int.Parse(dni);
                emp.Id_Estado = 1;
                emp.Cuenta = new BE.BE_Cuenta()
                {
                    Monto = Double.Parse(sueldo)
                };
                bllEmp.AltaNuevoEmpleado(emp);
            }
        }
        /// <summary>
        /// Baja empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaja_Click(object sender, EventArgs e)
        {
            string name = txtbox_Nombre.Text;
            string apellido = txtbox_Apellido.Text;
            string dni = txtBox_DNI.Text;
            string trabajo = comboBox1.Text;
            string sueldo = txtbox_Sueldo.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(trabajo) || String.IsNullOrEmpty(sueldo))
            {
                MessageBox.Show("Debe tener todos los campos");
            }
            else
            {
                bllEmp.EliminarEmpleado(dni);
            }
        }
    }
}
