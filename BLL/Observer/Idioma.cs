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
        
    }
}
