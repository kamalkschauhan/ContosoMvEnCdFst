using EdLern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace EdLern.Controllers
{
    public class ValuesController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }

        // GET api/values/5
        public decimal? GetConvertedRate(decimal amount, string fromCurrency, string toCurrency)
        {
            WebClient web = new WebClient();

            //below link was working before but somehow later it was blocked. 
            //However it does work from within browser.
            //string url = string.Format("https://www.google.com/finance/converter?a={0}&from={1}&to={2}", amount, fromCurrency.ToUpper(), toCurrency.ToUpper());

            //now using below only available free(without any conditions of use) api on internet.
            string url = string.Format("https://api.fixer.io/latest?base={0}", fromCurrency.ToUpper());
            try
            {
                string response = web.DownloadString(url);
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                ConversionBase objConversionBase = new ConversionBase();

                //first deserializing the response by using dynamic type
                var dict = oJS.Deserialize<dynamic>(response);

                //getting the same into a strong typed object
                objConversionBase.Base = dict["base"];
                objConversionBase.Date = Convert.ToDateTime(dict["date"]);
                objConversionBase.Rates = new Dictionary<string, decimal>();
                foreach (var item in dict["rates"])
                {
                    objConversionBase.Rates.Add(item.Key, item.Value);  //item.Key, item.Value);
                }

                //getting the target rate from the list of converstion rates for the base(fromCurrency) currency.
                KeyValuePair<string, decimal> currentTargetRate =
                    objConversionBase.Rates.Where(kv => kv.Key == toCurrency.ToUpper()).FirstOrDefault();

                decimal? rate = amount * currentTargetRate.Value;
                return rate;
            }
            catch (Exception)
            {
                return null;
            }
            //final conversion 
        }

        public Currencies GetCurrencies()
        {
            WebClient web = new WebClient();
            string url = "https://api.fixer.io/latest";
            try
            {
                string response = web.DownloadString(url);
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                List<string> lstCurrencies = new List<string>();
                //first deserializing the response by using dynamic type
                var dict = oJS.Deserialize<dynamic>(response);

                //getting the same into a strong typed object
                lstCurrencies.Add(dict["base"]);
                foreach (var item in dict["rates"])
                {
                    lstCurrencies.Add(item.Key);  //item.Key, item.Value);
                }
                Currencies objCurrencies = new Currencies
                {
                    CurrenciesList = lstCurrencies
                };
                return objCurrencies;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}