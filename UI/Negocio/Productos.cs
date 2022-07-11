﻿using BE;
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

namespace UI.Negocio
{
    public partial class Productos : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Negocio.BLLProducto BLLProd = new BLL.Negocio.BLLProducto();

        public Productos()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //check cliente y guardar para productos a comprarle
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);

            comboBox1.DataSource = BLLProd.TraerProductos();
            comboBox1.DisplayMember = "Descripcion";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Update()
        {
        }
    }
}
