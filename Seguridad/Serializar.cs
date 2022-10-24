using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Servicios
{
    public class Serializar
    {
        public static void Guardar<T>(T data, String url)
        {
            url += "/Serializado.xml";
            try
            {
                XmlSerializer serializer = new XmlSerializer(data.GetType());
                FileStream fStream = File.Open(url, FileMode.Create, FileAccess.Write);
                serializer.Serialize(fStream, data);
                fStream.Close();
                fStream.Dispose();
            }
            catch (Exception e)
            {
            }

        }

    }
}
