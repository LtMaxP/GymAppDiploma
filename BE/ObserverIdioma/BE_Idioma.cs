using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.ObserverIdioma
{
    public class BE_Idioma
    {
        public BE_Idioma(string idiomaName = null)
        {
            this.NombreIdioma = idiomaName;
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombreIdioma;

        public string NombreIdioma
        {
            get { return _nombreIdioma; }
            set { _nombreIdioma = value; }
        }

        private List<Leyenda> _leyendas;

        public List<Leyenda> Leyendas
        {
            get { return _leyendas; }
            set { _leyendas = value; }
        }

    }
}
