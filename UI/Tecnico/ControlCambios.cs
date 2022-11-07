using BE.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Tecnico
{
    public partial class ControlCambios : Form, BE.ObserverIdioma.IObserverIdioma
    {
        private BLL.Usuario bLLUsuario = new BLL.Usuario();
        public ControlCambios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlCambios_Load(object sender, EventArgs e)
        {
            SubjectIdioma.AddObserverIdioma(this);
            //CargarGrilla();
            cargarComboUser();
        }
        private void cargarComboUser()
        {
            foreach (var id in bLLUsuario.TraerUsuarios())
            {
                comboBoxUsuario.Items.Add(id);
            }
            comboBoxUsuario.ValueMember = "User";
        }

        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
        //-
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Formar grilla
        /// </summary>
        private void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.Tecnico.ControlCambiosBLL.TraerCC();
            dataGridView1.Update();
            dataGridView1.ReadOnly = true;
        }
        /// <summary>
        /// Traer Controles de cambio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                BE.Tecnico.ControlCambio cc = (BE.Tecnico.ControlCambio)row.DataBoundItem;
                cc.operacion = "Recupero de secuencia " + cc.secuencia;
                BLL.Tecnico.ControlCambiosBLL.GuardarCC(cc);
                CargarGrilla();
            }
        }
        public void Update()
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if(comboBoxUsuario.SelectedItem != null)
            {
                dataGridView1.DataSource = null;
                BE.Tecnico.ControlCambio cc = new BE.Tecnico.ControlCambio();
                var user = (BE.BE_Usuario)comboBoxUsuario.SelectedItem;
                cc.usuarioID = user.IdUsuario;
                var dt1 = dateTimePicker1.Value;
                var dt2 = dateTimePicker2.Value;
                dataGridView1.DataSource = BLL.Tecnico.ControlCambiosBLL.TraerCC(cc,dt1,dt2);
                dataGridView1.Update();
                dataGridView1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
        }
    }
}
