using HttpRequest.Models;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequest.Services
{
    class TheDogsApi : ITheDogsApi
    {

        public Task<List<Dog>> GetRandomDog()
        {
            var theDogAPI = RestService.For<ITheDogsApi>("https://api.thedogapi.com");
            return theDogAPI.GetRandomDog();
        }
    }
}
