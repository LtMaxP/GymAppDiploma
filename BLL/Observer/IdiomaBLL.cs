using BE.ObserverIdioma;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Observer
{
    public class IdiomaBLL
    {
        public IdiomaBLL()
        { }

        private DAL.IdiomaT idiom = new DAL.IdiomaT();


        public BE_Idioma DamePackDeIdioma(BE_Idioma idioma)
        {
            return idiom.TraerListaDeIdioma(idioma);
        }
        /// <summary>
        /// Retorna listado de Idiomas existentes
        /// </summary>
        /// <returns></returns>
        public List<BE_Idioma> DameIdiomas()
        {
            return idiom.IdiomasExistentes();
        }

        public void CambiarIdiomaDeUsuario(BE_Idioma idioma)
        {
            idioma = idiom.DameIdIdioma(idioma);
            idiom.CambiarIDIdiomaDeUsuarioDAL(idioma);
            idiom.CargarIdiomaAUsuarioPorId();
        }

        public BE.ObserverIdioma.BE_Idioma MostrarIdioma(BE_Idioma lang)
        {
            return idiom.VerListadoIdioma(lang);
        }
    }
}
