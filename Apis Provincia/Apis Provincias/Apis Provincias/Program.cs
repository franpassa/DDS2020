using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

namespace Apis_Provincias
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pido info de la API del gobierno
            WebRequest requestGob = HttpWebRequest.Create("https://apis.datos.gob.ar/georef/api/provincias");
            WebResponse responseGob = requestGob.GetResponse();
            StreamReader readerGob = new StreamReader(responseGob.GetResponseStream());

            // Guardo la info de la API del gobierno en un objeto
            string rootGob_JSON = readerGob.ReadToEnd();
            RootGob rootGob = Newtonsoft.Json.JsonConvert.DeserializeObject<RootGob>(rootGob_JSON);

            // Pido info de la API de MercadoLibre
            WebRequest requestML = HttpWebRequest.Create("https://api.mercadolibre.com/classified_locations/countries/AR");
            WebResponse responseML = requestML.GetResponse();
            StreamReader readerML = new StreamReader(responseML.GetResponseStream());

            // Guardo la info de la API de MercadoLibre en un objeto
            string rootML_JSON = readerML.ReadToEnd();
            RootML rootML = Newtonsoft.Json.JsonConvert.DeserializeObject<RootML>(rootML_JSON);

            // Listas para guardar nombres de las provincias
            List<string> provinciasGob = new List<string> { };
            List<string> provinciasML = new List<string> { };

            // Meto los nombres de las provincias en listas de strings para cada una
            foreach (ProvinciaGob provincia in rootGob.provincias) 
                provinciasGob.Add(provincia.nombre);
            foreach (StateML provincia in rootML.states)           
                provinciasML.Add(provincia.name);

            // (La interseccion menos la union da todos los diferentes)
            List<string> provinciasTotal = provinciasGob.Union<string>(provinciasML).ToList();
            List<string> provinciasComun = provinciasGob.Intersect<string>(provinciasML).ToList();
            List<string> provinciasDiferentes = provinciasTotal.Except(provinciasComun).ToList();

            provinciasGob.Sort();
            provinciasML.Sort();
            provinciasDiferentes.Sort();

            // Imprimo el resultado
            Console.WriteLine("\n\nProvincias diferentes entre las 2 APIS______________________________\n");
            foreach (string provincia in provinciasDiferentes)  
                Console.WriteLine(provincia);

            // (Para chequear)
            Console.WriteLine("\n\nProvincias de la API del gobierno___________________________________\n");
            foreach (string provincia in provinciasGob)         
                Console.WriteLine(provincia);
            Console.WriteLine("\n\nProvincias de la API de MercadoLibre________________________________\n");
            foreach (string provincia in provinciasML)          
                Console.WriteLine(provincia);

            Console.ReadLine();
        }
    }

    // Clase de la API del gobierno
    public class RootGob
    {
        public int cantidad { get; set; }
        public int inicio { get; set; }
        public ParametrosGob parametros { get; set; }
        public List<ProvinciaGob> provincias { get; set; }
        public int total { get; set; }
    }

    // Clase de la API del gobierno
    public class RootML
    {
        public string id { get; set; }
        public string name { get; set; }
        public string locale { get; set; }
        public string currency_id { get; set; }
        public string decimal_separator { get; set; }
        public string thousands_separator { get; set; }
        public string time_zone { get; set; }
        public GeoInformationML geo_information { get; set; }
        public List<StateML> states { get; set; }
    }

    public class ParametrosGob
    {
    }

    public class CentroideGob
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class ProvinciaGob
    {
        public CentroideGob centroide { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }


    public class LocationML
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class GeoInformationML
    {     
        public LocationML location { get; set; }
    }

    public class StateML
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}