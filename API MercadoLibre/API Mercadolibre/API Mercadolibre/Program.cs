using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using RestSharp;

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
    class Program
    {
        WebRequest webRequestCurrency = HttpWebRequest.Create("https://api.mercadolibre.com/currencies/" + currency_id);

        //    if (webRequestCurrency.GetResponse()) { return null; }
        WebResponse responseCurrency = webRequestCurrency.GetResponse();
        StreamReader readerCurrency = new StreamReader(responseCurrency.GetResponseStream());


        string currency_JSON = readerCurrency.ReadToEnd();
        MLCurrencyInfo currencyObj = Newtonsoft.Json.JsonConvert.DeserializeObject<MLCurrencyInfo>(currency_JSON);
    }
}
