using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ObserverIdioma
{
    public class Leyenda
    {
        /// <summary>
        /// Texto
        /// </summary>
        private string texto_label;
        public string _textoLabel
        {
            get { return texto_label; }
            set { texto_label = value; }
        }

        /// <summary>
        /// Etiqueta TAG
        /// </summary>
        private string nombreEtiqueta;
        public string _nombreEtiqueta
        {
            get { return nombreEtiqueta; }
            set { nombreEtiqueta = value; }
        }


    }
}
