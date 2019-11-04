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

        private DAL.IdiomaT idiom = new DAL.IdiomaT();

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
                    _idiomasTotales = new List<BE.Idioma>();
                    this.packIdioma();
                }

                return _idiomasTotales;
            }
        }


        private void packIdioma()
        {
            DataTable dt = idiom.TraerListaDeIdiomas();
            

            foreach (DataRow fila in dt.Rows)  //manda aca de la dal
            {
                BE.Idioma transitorio = new BE.Idioma();
                transitorio._idiomaPerteneciente = int.Parse(fila[0].ToString());
                transitorio._textoLabel = fila[1].ToString();
                transitorio._nombreEtiqueta = fila[2].ToString();

                _idiomasTotales.Add(transitorio);
            }

        }
        
        public void CambiarIdiomaDeUsuario()
        {
            if(SingletonIdioma.GetInstance().Idioma.IdiomaSelected == IdiomaEnum.Español)
            {
                idiom.CambiarIdiomaDeUsuarioDAL(BE.Usuario.Instance.IdUsuario, 1);
            }
            else
            {
                idiom.CambiarIdiomaDeUsuarioDAL(BE.Usuario.Instance.IdUsuario, 2);
            }
        }
    }
}
