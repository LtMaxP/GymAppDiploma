using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Observer
{
    public class SingletonIdioma
    {
        private SingletonIdioma()
        {
            Idioma = new Idioma();
        }

        private static SingletonIdioma _instance;

        public static SingletonIdioma GetInstance()
        {
            if(_instance == null)
            {
                _instance = new SingletonIdioma();
            }

            return _instance;
        }

        public Idioma Idioma{ get; set;}


    }
}
