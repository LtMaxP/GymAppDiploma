
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
        BE.Composite.Component family = new BE.Composite.Composite();
        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            var PermisosTotal = PermBLL.TraerComponentesFyP();
            foreach (var element in PermisosTotal.List())
            {
                if (element.GetType() == typeof(BE.Composite.Composite))
                {
                    comboBox1.Items.Add(element);
                }
                else
                {
                    comboBox2.Items.Add(element);
                }
            }
            comboBox1.ValueMember = "descripcion";
            comboBox2.ValueMember = "descripcion";
            ListaPerm.ValueMember = "descripcion";
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
            BE.Composite.Component elem = (BE.Composite.Component)comboBox1.SelectedItem;
            VerificarSiEsta(elem);
        }

        private void AgregarBtn2_Click(object sender, EventArgs e)
        {
            BE.Composite.Component elem = (BE.Composite.Component)comboBox2.SelectedItem;
            VerificarSiEsta(elem);

        }
        private void VerificarSiEsta(BE.Composite.Component element)
        {
            if(element == null)
            {
                MessageBox.Show("Debe seleccionar un permiso");
            }
            else if (family.VerificarSiExiste(element))
            {
                MessageBox.Show("El permiso ya existe");
            }
            else
            {
                family.Agregar(element);
                ListaPerm.Items.Add(element);
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
                    //agregar al usuario permisos y fin
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
