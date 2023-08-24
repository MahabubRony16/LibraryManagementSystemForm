using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelperClasses
{
    public class Processor
    {
        public async static Task<T> InformationGet<T>(string url)
        {

            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    T result = await response.Content.ReadAsAsync<T>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async static Task<HttpResponseMessage> InformationDelete(string url)
        {

            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync(url))
            {
                return response;
            }
        }

        public async static Task<HttpResponseMessage> InformationPost<T>(string url, T data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var contentData = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(url, contentData))
            {
                return response;
            }
        }

        
    }
}
