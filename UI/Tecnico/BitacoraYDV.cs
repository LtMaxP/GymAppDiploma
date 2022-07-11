﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Observer;

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

        private void button3_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BE.Bitacora> tableBit = bit.CargarBitacora();
            dataGridView1.DataSource = tableBit;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tableDV = dv.TraerDVV();
            dataGridView1.DataSource = tableDV;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dv.RecalcularDVV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dv.RecalcularDVH();
        }

        private void BitacoraYDV_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }

        public void Update()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable tableDV = dv.TraerDVH();
            dataGridView1.DataSource = tableDV;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string mensajeD = string.Empty;
            mensajeD = dv.RecalcularDVV() ? "Digito Verificador Vertical Correcto" : "Digito Verificador Vertical Incorrecto!! ERROR";
            MessageBox.Show(mensajeD);
        }
    }
}
