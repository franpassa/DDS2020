using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.IO;

namespace API_Mercadolibre
{
    public class MLCountry
    {

        public string id { get; set; }
        public string name { get; set; }
        public string locale { get; set; }
        public string currency_id { get; set; }
        public string decimal_separator { get; set; }
        public string thousands_separator { get; set; }
        public string time_zone { get; set; }
        public MLGeoInformation geo_information { get; set; }
        private List<MLState> states { get; set; }

        // El metodo MLCurrencyInfo no funciona con algunos paises
        public MLCurrencyInfo currencyInfo()
        {
            WebRequest webRequestCurrency = HttpWebRequest.Create("https://api.mercadolibre.com/currencies/" + currency_id);
            
            //    if (webRequestCurrency.GetResponse()) { return null; }
            WebResponse responseCurrency = webRequestCurrency.GetResponse();
            StreamReader readerCurrency = new StreamReader(responseCurrency.GetResponseStream());


            string currency_JSON = readerCurrency.ReadToEnd();
            MLCurrencyInfo currencyObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MLCurrencyInfo>(currency_JSON);

            return currencyObj;
        }

        public double cambiarDivisa(MLCountry _paisCambio, double _cantidad) 
        {
            WebRequest webRequestCurrency = HttpWebRequest.Create("https://api.mercadolibre.com/currency_conversions/search?from=" + currency_id + "&to=" + _paisCambio.currency_id);
            WebResponse responseCurrency = webRequestCurrency.GetResponse();
            StreamReader readerCurrency = new StreamReader(responseCurrency.GetResponseStream());

            string currency_JSON = readerCurrency.ReadToEnd();
            double exchange = Newtonsoft.Json.JsonConvert.DeserializeObject<MLCurrencyExchange>(currency_JSON).inv_rate;
            
            return (double)exchange * _cantidad;
        }

    }
}
