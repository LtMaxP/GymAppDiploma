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

        private static BE_Usuarios _instance;
        public static BE_Usuarios Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BE_Usuarios();
                }
                return _instance;
            }
        }
        #endregion


    }
}
