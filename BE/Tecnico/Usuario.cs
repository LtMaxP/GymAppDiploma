using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class Usuario
    {
        public static void Main(string[] args)
        {
        }
        #region singleton
        private Usuario()
        { }

        private static BE_Usuario _instance;
        public static BE_Usuario Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BE_Usuario();
                }
                return _instance;
            }
        }
        #endregion


    }
}
