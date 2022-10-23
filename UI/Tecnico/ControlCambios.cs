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
            CargarGrilla();
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
    }
}
