using System;
using System.Net.Http;
using System.Net.Http.Headers;
namespace HelperClasses
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("http://localhost:5000");
            ApiClient.BaseAddress = new Uri("https://www.googleapis.com/books/v1/volumes/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}
