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
    public partial class BitacoraYDV : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.BitacoraBLL bit = new BLL.BitacoraBLL();
        BLL.DV dv = new BLL.DV();

        public BitacoraYDV()
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
            //List<BE.Bitacora> tableBit = bit.CargarBitacora();
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
        }
        public void Update()
        {
            
        }
    }
}
