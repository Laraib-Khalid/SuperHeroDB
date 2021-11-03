using SuperHeroDB.Shared;
using System.Net.Http.Json;

namespace SuperHeroDB.Client.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly HttpClient _httpClient;

        public SuperHeroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<SuperHero>> GetSuperHeroes()
        {
           return await _httpClient.GetFromJsonAsync<List<SuperHero>>("api/superhero"); 
        }
    }
}
