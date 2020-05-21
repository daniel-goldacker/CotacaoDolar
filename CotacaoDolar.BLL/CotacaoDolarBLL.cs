using ContacaoDolar.Domain;
using RestSharp;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CotacaoDolar.BLL
{
    public class CotacaoDolarBLL
    {

        public CotacaoDolarDia[] BuscaDadosCotacaoDolarAPI(int diasCotacaoDolar)
        {
            // Faz a chamada da API
            var client = new RestClient("https://api.bcb.gov.br/dados/serie/bcdata.sgs.1/dados/ultimos/"+diasCotacaoDolar+"?formato=json");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "cookie_p=!AZ2UXsTy9rMdDWm7zbbtnqNgyxC+ovGcH3vXX3PhTht5JgUY3nPZ+lv9DsPEkXL6ald1aXziGKc4AQs=; TS01799025=0198c2d644cdbafda912a3dd8bbdbc7aafeb0bc9cca1e81e5745bed593d1cdf24b0b28ead4632e200e48bd48d51dd3f44a49cbc9e4c1075efa87703e7eac72401d87576115");
            IRestResponse response = client.Execute(request);

            // Deserializa JSON e converte em array
            JavaScriptSerializer js = new JavaScriptSerializer();
            CotacaoDolarDia[] cotacaodolardia = js.Deserialize<CotacaoDolarDia[]>(response.Content);
          
            return cotacaodolardia;
        }
    }
}
