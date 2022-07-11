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

        private void Empleados_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);

            comboBox1.DataSource = bllEmp.CargarComboTrabajos();
            comboBox1.DisplayMember = "Descripcion";
        }

        private void labelSalir_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(string.Empty))
            {
                //BE.BE_Usuarios usuario = new BE.BE_Usuarios();
                //usuario.User = textBox2.Text;
                //List<BE.BE_Usuarios> filaDeDatos = usuarioABM.BuscarUsuario(usuario);

                //if (filaDeDatos.Count > 0)
                //{
                //    if (listView1.Items.Count > 0)
                //    {
                //        listView1.Items.RemoveAt(0);
                //    }
                //    foreach (BE.BE_Empleado u in filaDeDatos)
                //    {
                //        ListViewItem lista = new ListViewItem();
                //        lista.SubItems.Add(u.User.ToString());
                //        listView1.Items.AddRange(new ListViewItem[] { lista });
                //    }
                //}
            }
            else
            { MessageBox.Show("Debe ingresar un Empleado!"); }
        }

        private void labelAgregar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
