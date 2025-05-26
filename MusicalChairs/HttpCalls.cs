using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;

namespace ChildrensGame
{
    internal class HttpCalls
    {
        public HttpCalls()
        {
            
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://7annld7mde.execute-api.ap-southeast-2.amazonaws.com/main/game");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            using System.Net.Http.HttpResponseMessage response = await client.GetAsync(url);
            string jsonResponse;
            if (response.IsSuccessStatusCode)
            {
                jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"{jsonResponse}\n");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                throw new HttpRequestException($"Request failed with status code {response.StatusCode} and reason {response.ReasonPhrase}.");
            }

            return jsonResponse;
        }
    }
}
