﻿using System;
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
    public partial class BitacoraYDV : Form
    {
        BLL.BitacoraBLL bit = new BLL.BitacoraBLL();
        BLL.DV dv = new BLL.DV();

        public BitacoraYDV()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio ini = new Inicio();
            ini.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tableBit = bit.CargarBitacora();
            dataGridView1.DataSource = tableBit;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DataTable tableBit = 
            //dataGridView1.DataSource = tableBit;
        }
    }
}
