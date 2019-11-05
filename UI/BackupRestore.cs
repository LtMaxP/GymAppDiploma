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
    public partial class BackupRestore : Form
    {
        public BackupRestore()
        {
            InitializeComponent();
        }

        private void btnExaminarBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MiDirectorio = new FolderBrowserDialog();
            if (MiDirectorio.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectorioBackUp.Text = MiDirectorio.SelectedPath;
            }
            else
            {
                MessageBox.Show("Ruta incorrecta.");
            }
        }

        private void btnExaminarRestore_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog MiDirectorio = new FolderBrowserDialog();
            if (MiDirectorio.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectorioRestore.Text = MiDirectorio.SelectedPath;
            }
            else
            {
                MessageBox.Show("Ruta incorrecta.");
            }
        }
    }
}
