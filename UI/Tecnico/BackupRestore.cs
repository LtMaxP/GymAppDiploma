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
    public partial class BackupRestore : Form, IObserver
    {
        BLL.Tecnico.Backup bkpBLL = new BLL.Tecnico.Backup();

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
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }

        public void Update(Idioma idioma)
        {

        }

        private void btnVolverBackUp_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
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
        }
    }
}
