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
    public partial class AyudaGlobal : Form, BE.ObserverIdioma.IObserverIdioma
    {
        public AyudaGlobal(int tag)
        {
            InitializeComponent();
            CargaLabels(tag);
        }

        private void CargaLabels(int tag)
        {
            if(tag == 1)
            {
                lblAyudaGestionClientes.Visible = true;
                imageBox.Image = Properties.Resources.GestionClientes;
            }
            else if (tag == 2)
            {
                lblAyudaGestionVentas.Visible = true;
                imageBox.Image = Properties.Resources.GestionProductos;
            }
            else if (tag == 3)
            {
                lblAyudaGestionStock.Visible = true;
                imageBox.Image = Properties.Resources.GestionStock;
            }
            else if (tag == 4)
            {
                lblAyudaFacturasPagos.Visible = true;
                imageBox.Image = Properties.Resources.Pagos;
                ImageBox2.Image = Properties.Resources.Facturas;
            }
            else if (tag == 5)
            {
                lblAyudaIdioma.Visible = true;
                imageBox.Image = Properties.Resources.Idioma;
            }
            else if (tag == 6)
            {
                lblAyudaPermisos.Visible = true;
                imageBox.Image = Properties.Resources.AdmPermisos;
                ImageBox2.Image = Properties.Resources.PermisosUsuarios;
            }
            else if (tag == 7)
            {
                lblAyudaControlCambios.Visible = true;
                imageBox.Image = Properties.Resources.ControlCambios;
            }
            else if (tag == 8)
            {
                lblAyudaBitacora.Visible = true;
                imageBox.Image = Properties.Resources.Bitacora;
            }
            else if (tag == 9)
            {
                lblAyudaBackupRestore.Visible = true;
                imageBox.Image = Properties.Resources.BackupRestore;
            }
            else if (tag == 10)
            {
                lblAyudaGestionUsuario.Visible = true;
                imageBox.Image = Properties.Resources.GestionUsuario;
            }
            else if (tag == 11)
            {
                lblAyudaLogin.Visible = true;
                imageBox.Image = Properties.Resources.Login;
                lblAyudaLogOut.Visible = true;
                ImageBox2.Image = Properties.Resources.Logout;
                lblAyudaLoginRecupero.Visible = true;
                ImageBox3.Image = Properties.Resources.LogRecupero;
            }
        }

        private void AyudaGlobal_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            BE.ObserverIdioma.SubjectIdioma.Notify();
        }

        private void labelSalir_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
    }
}
