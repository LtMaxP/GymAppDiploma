using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Observer
{
    public class Idioma : BLL.Observer.Subject
    {

        DAL.IdiomaT idiom = new DAL.IdiomaT();

        private IdiomaEnum _idioma;
        public IdiomaEnum IdiomaSelected
        {
            get
            {
                return _idioma;
            }
            set
            {
                _idioma = value;
                Notify(this);
            }
        }

        private List<BE.Idioma> _idiomasTotales;

        public List<BE.Idioma> DamePackDeIdiomas
        {
            get
            {
                if(_idiomasTotales == null)
                {
                    this.packIdioma();
                }

                return _idiomasTotales;
            }
        }


        private void packIdioma()
        {
            DataTable dt = idiom.TraerListaDeIdiomas();
            BE.Idioma transitorio = new BE.Idioma();

            foreach (DataRow fila in dt.Rows)  //manda aca de la dal
            {
                transitorio._idiomaPerteneciente = fila[0].ToString();
                transitorio._textoLabel = fila[1].ToString();
                transitorio._nombreEtiqueta = fila[2].ToString();
                _idiomasTotales.Add(transitorio);
            }

        }
 
    }
}
