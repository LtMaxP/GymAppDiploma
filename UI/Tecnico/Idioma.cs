using BE.ObserverIdioma;
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

namespace UI.Tecnico
{
    public partial class Idioma : Form, IObserverIdioma
    {
        IdiomaBLL BLLIdioma = new IdiomaBLL();
        public Idioma()
        {
            InitializeComponent();
        }

        public void Update(BLL.Observer.Idioma idioma)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {

            SubjectIdioma.AddObserverIdioma(this);
            //Subject.Notify(SingletonIdioma.GetInstance().Idioma);  usar el notify cuando se hace click en un idioma arriba

            comboBox1.DataSource = BLLIdioma.DameIdiomas();
            comboBox1.DisplayMember = "NombreIdioma";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Update(BE_Idioma idioma)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BE_Idioma selection = new BE_Idioma();
            selection.NombreIdioma = comboBox1.Text.ToString();
            BLLIdioma.CambiarIdiomaDeUsuario(selection);
            SubjectIdioma.Notify();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BE_Idioma lang = new BE_Idioma();
            lang.NombreIdioma = comboBox1.Text;
            lang = BLLIdioma.MostrarIdioma(lang);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = lang.Leyendas;
            dataGridView1.Columns[0].HeaderCell.Value = "Etiqueta";
            dataGridView1.Columns[1].HeaderCell.Value = "Texto";
            dataGridView1.Columns.Add("NewTxt", "Nuevo Texto");

        }

        /// <summary>
        /// Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            BE_Idioma idioma = new BE_Idioma();
            idioma.NombreIdioma = comboBox1.Text;
            if (BLLIdioma.ValidarExistencia(idioma))
            {
                List<Leyenda> ley = new List<Leyenda>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Leyenda leyenda = new Leyenda();
                    leyenda._textoLabel = row.Cells[1].ToString();
                    ley.Add(leyenda);
                }
                idioma.Leyendas = ley;
                BLLIdioma.ModificarIdioma(idioma);
            }
            else
            {
                MessageBox.Show("Idioma Erroneo NO lo modifiques ヾ(•ω•`)o");
            }

        }
    }
}
