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
    public partial class Bitacora : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.BitacoraBLL bit = new BLL.BitacoraBLL();
        BLL.DV dv = new BLL.DV();
        private BLL.Usuario bLLUsuario = new BLL.Usuario();
        public Bitacora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
        /// <summary>
        /// Traer bitacoras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            BE.Bitacora bitacor = new BE.Bitacora();
            bitacor.NivelDeProblema = comboBoxProblema.Text;
            var user = (BE.BE_Usuario)comboBoxUsuario.SelectedItem;
            bitacor.Usuario = user.User;
            var dt1 = dateTimePicker1.Value;
            var dt2 = dateTimePicker2.Value;
            List<BE.Bitacora> tableBit = bit.CargarBitacoraConFiltrado(bitacor, dt1, dt2);
            dataGridView1.DataSource = tableBit;
        }
        private void CargaInicialBit()
        {
            dataGridView1.Refresh();
            var dt1 = dateTimePicker1.Value;
            var dt2 = dateTimePicker2.Value;
            List<BE.Bitacora> tableBit = bit.CargarBitacoraFechas(dt1, dt2);
            dataGridView1.DataSource = tableBit;
        }
        //-
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BitacoraYDV_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            cargarComboUser();
            CargaInicialBit();
        }
        private void cargarComboUser()
        {
            foreach (var id in bLLUsuario.TraerUsuarios())
            {
                comboBoxUsuario.Items.Add(id);
            }
            comboBoxUsuario.ValueMember = "User";
        }
        public void Update()
        {

        }
    }
}
