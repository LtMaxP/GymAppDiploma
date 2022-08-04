﻿using BE.ObserverIdioma;
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
    public partial class PermisosUsuario : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Usuario bLLUsuario = new BLL.Usuario();
        BLL.Tecnico.PermisosBLL Perm = new BLL.Tecnico.PermisosBLL();
        private List<BE.BE_Usuario> users;
        public PermisosUsuario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void PermisosUsuario_Load_1(object sender, EventArgs e)
        {
            SubjectIdioma.AddObserverIdioma(this);
            users = bLLUsuario.TraerUsuarios(); //traer usuario con permisos aca o luego? o hacer otra clase?
            foreach (var id in users)
            {
                comboBox1.Items.Add(id);
            }
            comboBox1.ValueMember = "User";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE.BE_Usuario us = (BE.BE_Usuario)comboBox1.SelectedItem;
            lblUserName.Text = us.User;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblUserName.Text))
            {
                lblUserName.Text = users.First(x => x.IdUsuario == int.Parse(comboBox1.Text)).User;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            BE.BE_Usuario user = (BE.BE_Usuario)comboBox1.SelectedItem;
            user = Perm.TraerUsuarioConPermisos(user);
            int cnt = 0;
            foreach (var perm in user.Permisos.List())
            {
                if (!perm.descripcion.Equals("Arbol"))
                {
                    treeView2.Nodes.Add(cnt++.ToString(), perm.descripcion);
                    if(perm is BE.Composite.Component)
                        foreach(var subperm in perm.List())
                        {
                            treeView2.Nodes.Add((cnt + 1).ToString(), subperm.descripcion);
                        }
                }
            }
        }
    }
}
