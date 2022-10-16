using BLL.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class BackupRestore : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Tecnico.Backup bkpBLL;
        BLL.Tecnico.Restore rstBLL;
        public BackupRestore()
        {
            InitializeComponent();
            bkpBLL = new BLL.Tecnico.Backup();
            rstBLL = new BLL.Tecnico.Restore();
        }

        private void btnExaminarBackUp_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminarRestore_Click(object sender, EventArgs e)
        {
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
        }

        public void Update()
        {

        }

        private void btnVolverBackUp_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void btnEjecutarBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string rooTFoolder = folderDlg.SelectedPath;
                string msg = bkpBLL.BackupBD(rooTFoolder) ? "Backup Ok" : "Backup Fallo";
                MessageBox.Show(msg);
            }
        }

        private void btnVerBackUp_Click(object sender, EventArgs e)
        {
            DgBackup.DataSource = bkpBLL.TraerBackupsBD();
            DgBackup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEjecutarRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog().Equals(true))
            {
                string ruta = openFileDialog.FileName;
                rstBLL.RestoreBD(ruta);
            }
        }

        private void DgBackup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Boton de recalcular DV totales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BLL.DV.RecalcularDigitosVerificadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
