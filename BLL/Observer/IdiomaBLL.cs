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

        /// <summary>
        /// Retorna listado de Idiomas existentes
        /// </summary>
        /// <returns></returns>
        public List<BE_Idioma> DameIdiomas()
        {
            return idiom.IdiomasExistentes();
        }
        /// <summary>
        /// Cambiar idioma del usuario
        /// </summary>
        /// <param name="idioma"></param>
        public void CambiarIdiomaDeUsuario(BE_Idioma idioma)
        {
            idioma = idiom.DameIdIdioma(idioma);
            idiom.CambiarIDIdiomaDeUsuarioDAL(idioma);
            idiom.CargarIdiomaAUsuarioPorId();
        }
        /// <summary>
        /// Traer listado de Textos del idioma
        /// </summary>
        /// <param name="lang"></param>
        /// <returns></returns>
        public BE.ObserverIdioma.BE_Idioma MostrarIdioma(BE_Idioma lang)
        {
            return idiom.VerListadoIdioma(lang);
        }
        /// <summary>
        /// Envio del pack idioma con leyendas para modificar
        /// </summary>
        /// <param name="idiom"></param>
        public void ModificarIdioma(BE_Idioma idioma)
        {
            idioma = idiom.DameIdIdioma(idioma);
            idiom.ModificalIdiomaDAL(idioma);
        }
        /// <summary>
        /// Crear nuevo idioma
        /// </summary>
        /// <param name="idioma"></param>
        public void CrearIdioma(BE_Idioma idioma)
        {
            idiom.CrearIdiomaDAL(idioma);
        }
        /// <summary>
        /// Validar que el idioma exista
        /// </summary>
        /// <param name="idioma"></param>
        /// <returns></returns>
        public bool ValidarExistencia(BE_Idioma idioma)
        {
            return idiom.ValidarExistenciaIdioma(idioma);
        }
        /// <summary>
        /// EliminarIdioma
        /// </summary>
        /// <param name="idioma"></param>
        public void EliminarIdioma(BE_Idioma idioma)
        {
            idiom.EliminarIdioma(idioma);
        }
    }
}
