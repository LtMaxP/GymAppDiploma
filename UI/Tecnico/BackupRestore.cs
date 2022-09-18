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
    public partial class BackupRestore : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Tecnico.Backup bkpBLL = new BLL.Tecnico.Backup();
        BLL.Tecnico.Restore rstBLL = new BLL.Tecnico.Restore();
        public BackupRestore()
        {
            InitializeComponent();
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
            string msg = bkpBLL.BackupBD() ? "Backup Ok" : "Backup Fallo";
            MessageBox.Show(msg);
        }

        private void btnVerBackUp_Click(object sender, EventArgs e)
        {
            DgBackup.DataSource = bkpBLL.TraerBackupsBD();
            DgBackup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEjecutarRestore_Click(object sender, EventArgs e)
        {
            if (DgBackup.SelectedRows.Count == 1)
            {
                string ruta = DgBackup.SelectedRows[0].Cells[0].Value.ToString();
                rstBLL.RestoreBD(ruta);
            }
        }

        private void DgBackup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
