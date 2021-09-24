using HttpRequest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequest.Services
{
    class TheDogsApiService : ITheDogsApiService
    {
        public async Task<List<Dog>> GetDogsAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.thedogapi.com/v1/images/search");
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Dog>>(responseString);
            }
            return null;
        }
    }
}
