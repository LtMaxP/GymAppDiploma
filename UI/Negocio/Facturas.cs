using BLL.Observer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            BE.ObserverIdioma.SubjectIdioma.Notify();
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
            if (dataGridViewFactura.RowCount != 0)
            {
                List<BE.BE_Factura> listadoFacturas = new List<BE.BE_Factura>();
                foreach (DataGridViewRow it in dataGridViewFactura.Rows)
                {
                    var fact = (BE.BE_Factura)it.DataBoundItem;
                    listadoFacturas.Add(fact);
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
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string dni = textBox.Text;
                if (bllFacturas.DetectarCliente(dni))
                {
                    dataGridViewFactura.DataSource = null;
                    List<BE.BE_Factura> facturas = bllFacturas.TraerFacturas(dni);
                    dataGridViewFactura.DataSource = facturas;
                    //dataGridViewFactura.DataMember = "[fecha]";
                    //dataGridViewFactura.DataMember = "[monto]";

                    //foreach (BE.BE_Factura factu in facturas)
                    //{
                    //    ListViewItem elementos = new ListViewItem(listBox.Items["Monto"]);
                    //    elementos.SubItems.Add(factu.Monto.ToString());
                    //    ListViewItem elementos2 = new ListViewItem(listBox.Items["Fecha"]);
                    //    elementos2.SubItems.Add(factu.Fecha.ToString());
                    //}
                    //foreach (var dr in facturas)
                    //{
                    //    listBoxFactura.Items.Add(dr.Monto.ToString() + "|" + dr.Fecha.ToString());
                    //}
                }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI a buscar");
            }
        }

        private void btn_PDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactura.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe Seleccionar una factura ");
            }
            else
            {
                BE.BE_Factura factura = (BE.BE_Factura)dataGridViewFactura.SelectedRows[0].DataBoundItem;
                factura = bllFacturas.TraerFacturaConItems(factura);
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string rooTFoolder = folderDlg.SelectedPath;
                    if (Servicios.GeneradorPDF.GenerarFactura(rooTFoolder, factura))
                        MessageBox.Show("Exportación realizada con exito");
                    else
                        MessageBox.Show("Error en la exportación");
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
    }
}
