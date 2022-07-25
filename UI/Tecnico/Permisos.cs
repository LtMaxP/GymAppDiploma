
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
            //comboBox1.DataSource = PermBLL.TraerComponentesFyP();
            BE.Composite.Component asd = PermBLL.TraerComponentesFyP();
            //comboBox1.DataSource = asd.List();
            BE.Composite.Component family = new BE.Composite.Composite();
            BE.Composite.Component childs = new BE.Composite.Composite();
            foreach (var adsd in asd.List())
            {
                if (adsd.GetType() == typeof(BE.Composite.Composite))
                {
                    family.Agregar(adsd);
                }
                if (adsd.GetType() == typeof(BE.Composite.Hoja))
                {
                    childs.Agregar(adsd);
                }
            }
            comboBox1.DataSource = family.List();
            comboBox2.DataSource = childs.List();

            comboBox1.ValueMember = "descripcion";
            ////comboBox2.DataSource = PermBLL.TraerPatentes();
            //comboBox2.DataSource = PermBLL.TraerComponentesFyP();
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
                {   
                    BE.Composite.Component permisos = new BE.Composite.Composite();
                    foreach (BE.Composite.Component element in ListaPerm.Items)
                    {
                        permisos.Agregar(element);
                    }
                    user.Permisos = permisos;
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
