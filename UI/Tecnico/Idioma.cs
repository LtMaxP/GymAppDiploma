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

            CargarComboIdiomas();
        }
        private void CargarComboIdiomas()
        {
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

        /// <summary>
        /// Mostrar idioma seleccionado en tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BE_Idioma lang = new BE_Idioma();
            lang.NombreIdioma = comboBox1.Text;
            MostrarSeleccion(lang);
        }
        private void MostrarSeleccion(BE_Idioma lang)
        {
            lang = BLLIdioma.MostrarIdioma(lang);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = lang.Leyendas;
            dataGridView1.Columns[0].HeaderCell.Value = "Texto";
            dataGridView1.Columns[1].HeaderCell.Value = "Nuevo Texto";
            LabelIdi.Text = lang.NombreIdioma;
        }

        /// <summary>
        /// Modificar el idioma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            BE_Idioma idioma = new BE_Idioma();
            idioma.NombreIdioma = LabelIdi.Text;
            if (BLLIdioma.ValidarExistencia(idioma))
            {
                List<Leyenda> ley = new List<Leyenda>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string txt = row.Cells[1].FormattedValue.ToString();
                    if (!string.IsNullOrWhiteSpace(txt))
                    {
                        Leyenda leyenda = new Leyenda();
                        leyenda._nombreEtiqueta = row.Cells[0].Value.ToString();
                        leyenda._textoLabel = row.Cells[1].Value.ToString();
                        ley.Add(leyenda);
                    }
                }
                idioma.Leyendas = ley;
                BLLIdioma.ModificarIdioma(idioma);
                MessageBox.Show("Idioma modificado ! ヾ(•ω•`)o");
                MostrarSeleccion(idioma);
            }
            else
            {
                MessageBox.Show("Seleccione un idioma existente a modificar ヾ(•ω•`)o");
            }

        }

        /// <summary>
        /// Crear nuevo idioma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                BE_Idioma idioma = new BE_Idioma();
                idioma.NombreIdioma = textBox1.Text;
                if (!BLLIdioma.ValidarExistencia(idioma))
                {
                    List<Leyenda> ley = new List<Leyenda>();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string txt = row.Cells[1].FormattedValue.ToString();
                        if (!string.IsNullOrWhiteSpace(txt))
                        {
                            Leyenda leyenda = new Leyenda();
                            leyenda._nombreEtiqueta = row.Cells[0].Value.ToString();
                            leyenda._textoLabel = row.Cells[1].Value.ToString();
                            ley.Add(leyenda);
                        }
                    }
                    idioma.Leyendas = ley;
                    BLLIdioma.CrearIdioma(idioma);

                    MessageBox.Show("Idioma creado ! ヾ(•ω•`)o");
                    MostrarSeleccion(idioma);
                }
                else
                {
                    MessageBox.Show("Nombre de idioma ya existente ヾ(•ω•`)o");
                }
            }
            else
            {
                MessageBox.Show("Debe nombrar el nuevo idioma ヾ(•ω•`)o");
            }
        }
    }
}
