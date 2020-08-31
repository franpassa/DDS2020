using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Apis_Provincias
{
    class Program
    {
        static void Main(string[] args)
        {

            WebRequest request = HttpWebRequest.Create("https://apis.datos.gob.ar/georef/api/provincias?campos=nombre");
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string root_JSON = reader.ReadToEnd();
            Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(root_JSON);

            foreach (Provincia provincia in root.provincias)
            {
                Console.WriteLine("Provincia: " + provincia.nombre);
                Console.WriteLine("ID: " + provincia.id);
            }
            Console.ReadLine();

            /*
            foreach (Provincia provincia in root.provincias) {
                WebRequest prov_request = HttpWebRequest.Create("https://apis.datos.gob.ar/georef/api/provincias?campos=nombre" + provincia);
                WebResponse prov_response = prov_request.GetResponse();
                StreamReader prov_reader = new StreamReader(prov_response.GetResponseStream());

                string prov_JSON = prov_reader.ReadToEnd();
                provincia.insertarJson(prov_JSON);

                Console.WriteLine(provincia.nombre);
                Console.WriteLine(provincia.id);
                Console.WriteLine(provincia.centroide.lat);
                Console.WriteLine(provincia.centroide.lon);
            }
            */
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    // Clases creadas con https://json2csharp.com/
    public class Centroide
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Provincia
    {
        public string nombre { get; set; }
        public string id { get; set; }
        public Centroide centroide { get; set; }

        public void insertarJson(string prov_JSON)
        {
            Provincia aux = Newtonsoft.Json.JsonConvert.DeserializeObject<Provincia>(prov_JSON);

            nombre = aux.nombre;
            id = aux.id;
            centroide.lat = aux.centroide.lat;
            centroide.lon = aux.centroide.lon;
        }
    }

    public class Municipio
    {
        public string nombre { get; set; }
        public string id { get; set; }
    }

    public class Root
    {
        public List<Provincia> provincias { get; set; }

    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Parametros
    {
        public List<string> campos { get; set; }
    }

}
