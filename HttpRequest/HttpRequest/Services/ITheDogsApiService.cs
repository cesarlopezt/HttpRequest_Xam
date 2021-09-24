using HttpRequest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequest.Services
{
    interface ITheDogsApiService
    {
        Task<List<Dog>> GetDogsAsync();
    }
}
