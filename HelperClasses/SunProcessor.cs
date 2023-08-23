using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelperClasses
{
    public class SunProcessor
    {
        public async static Task<SunModel> LoadSunInformation()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400&date=today";

            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();
                    return result.results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
