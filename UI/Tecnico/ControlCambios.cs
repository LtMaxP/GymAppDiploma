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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarGrilla()
        {
            dataGridView1.DataSource = null;

            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].Name = "idEntidad";
            dataGridView1.Columns[0].DataPropertyName = "idEntidad";
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].Name = "descripcion";
            dataGridView1.Columns[1].DataPropertyName = "descripcion";

            dataGridView1.Columns[2].Name = "Secuencia";
            dataGridView1.Columns[2].DataPropertyName = "Secuencia";
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[3].Name = "UsuarioID";
            dataGridView1.Columns[3].DataPropertyName = "UsuarioID";

            dataGridView1.Columns[4].Name = "valorOriginal";
            dataGridView1.Columns[4].DataPropertyName = "valorOriginal";

            dataGridView1.Columns[5].Name = "valorNuevo";
            dataGridView1.Columns[5].DataPropertyName = "valorNuevo";

            dataGridView1.Columns[6].Name = "fechaModificacion";
            dataGridView1.Columns[6].DataPropertyName = "fechaModificacion";

            dataGridView1.Columns[7].Name = "Operacion";
            dataGridView1.Columns[7].DataPropertyName = "Operacion";


            dataGridView1.DataSource = BLL.Tecnico.ControlCambiosBLL.TraerCC();
            dataGridView1.Update();
            dataGridView1.ReadOnly = true;
        }
    }
}
