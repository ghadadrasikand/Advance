using Advance.Aplication.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Aplication.Services
{
    public class HttpRequest:IHttpRequest
    {
        private readonly HttpClient _httpClient;
        public HttpRequest(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient(); 
        }
        public async Task<string> Get(string url)
        {
            string response = "";
            var partyResponse = await _httpClient.GetAsync(url);
            if (partyResponse.StatusCode == HttpStatusCode.OK)
            {
                var strResponse = await partyResponse.Content.ReadAsStringAsync();
                response = strResponse;
            }
            return response;
        }
        public async Task<string> Post<T>(T model,string url) where T : class
        {
            string response = "";
            string serializedModel=JsonConvert.SerializeObject(model);
            var content = new StringContent(serializedModel,Encoding.UTF8,"Application/json");
            var partyResponse = await _httpClient.PostAsync(url,content);
            if (partyResponse.StatusCode == HttpStatusCode.OK)
            {
                var strResponse = await partyResponse.Content.ReadAsStringAsync();
                response = strResponse;
            }
            return response;
        }

       
    }
}
