
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
    public partial class Permisos : Form, BE.ObserverIdioma.IObserverIdioma
    {
        private BLL.Tecnico.PermisosBLL PermBLL = new BLL.Tecnico.PermisosBLL();
        public Permisos()
        {
            InitializeComponent();
        }


        private void Permisos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            //comboBox1.DataSource = PermBLL.TraerFamilias();
            //arreglar para q divida entre patentes y familias a mostrar en List como le gusta a comboBox
            comboBox1.DataSource = PermBLL.TraerComponentesFyP();
            comboBox1.ValueMember = "descripcion";
            //comboBox2.DataSource = PermBLL.TraerPatentes();
            comboBox2.DataSource = PermBLL.TraerComponentesFyP();
            comboBox2.ValueMember = "descripcion";

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            if (!ListaPerm.Items.Contains(comboBox1.SelectedItem))
            {
                ListaPerm.Items.Add(comboBox1.SelectedItem);
                ListaPerm.ValueMember = "descripcion";
            }
            else
            {
                MessageBox.Show("Ya fue agregado ^_~");
            }
        }

        private void AgregarBtn2_Click(object sender, EventArgs e)
        {
            if (!ListaPerm.Items.Contains(comboBox2.SelectedItem))
            {
                ListaPerm.Items.Add(comboBox2.SelectedItem);
                ListaPerm.ValueMember = "descripcion";
            }
            else
            {
                MessageBox.Show("Ya fue agregado ^_~");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                BE.BE_Usuario user = new BE.BE_Usuario();
                user.User = txtName.Text;
                if (PermBLL.DetectarUsuario(user))
                {   ////////////////MODIFICAR EL LISTADO PARA Q CONTENGA COMPONENTES Y PASE LOS OBJETOS DIRECTOS PARA MANIPULAR
                    foreach (BE.Composite.Component element in ListaPerm.Items)
                    {
                        user.Permisos.Agregar(element);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario");
            }
        }
    }
}
