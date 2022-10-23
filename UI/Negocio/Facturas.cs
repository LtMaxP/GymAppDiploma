using BLL.Observer;
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
    public partial class Facturas : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.BLLFacturas bllFacturas;
        public Facturas()
        {
            InitializeComponent();
            bllFacturas = new BLL.BLLFacturas();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        public void Update()
        {
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Serializar y exportar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            if(listBox.Items.Count != 0)
            {
                List<BE.BE_Factura> listadoFacturas = new List<BE.BE_Factura>();
                foreach(DataRow it in listBox.Items)
                {
                    BE.BE_Factura fac = new BE.BE_Factura();
                    fac.Fecha = DateTime.Parse(it["fecha"].ToString());
                    fac.Monto = decimal.Parse(it["monto"].ToString());
                    fac.Id_Factura = int.Parse(it["Id_Factura"].ToString());
                    listadoFacturas.Add(fac);
                }
                
                //Ruta a llevar
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string rooTFoolder = folderDlg.SelectedPath;
                    BLL.BLLFacturas.ExportarFactura(listadoFacturas, rooTFoolder);
                    MessageBox.Show("Exportación realizada con exito");
                }
            }
            else
                MessageBox.Show("Debe cargar la tabla con items para exportar");
        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {
            string dni = textBox.Text;
            if (bllFacturas.DetectarCliente(dni))
            {
                listBox.Items.Clear();
                List<BE.BE_Factura> facturas = bllFacturas.TraerFacturas(dni);
                listBox.DataSource = facturas;
            }
        }
    }
}
