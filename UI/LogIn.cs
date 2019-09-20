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

    public partial class LogIn : Form
    {
        private BLL.Login bllLog = new BLL.Login();
        private BE.Usuario user;

        public LogIn()
        {
            InitializeComponent();
        }

        public void LogIn_Load(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario o contraseña para avanzar");
            }

            //Detecta que el usuario exista
            if (bllLog.DetectarUsuario(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                if (user.Rol == "Administrador")
                {
                    Inicio ini = new Inicio();
                    ini.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
            }


        }
    }
}
