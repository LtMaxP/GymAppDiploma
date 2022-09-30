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
    public partial class ControlCambios : Form, IObserverIdioma
    {
        public ControlCambios()
        {
            InitializeComponent();
        }

        private void ControlCambios_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            CargarGrilla();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BLL.Tecnico.ControlCambiosBLL.TraerCC();
            dataGridView1.Update();
            dataGridView1.ReadOnly = true;
        }

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
    }
}
