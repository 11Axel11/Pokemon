using Newtonsoft.Json;
using Pokemon.BusinessModel.Models;

namespace Pokemon.Business.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IHttpClientService _httpClientService;
        public PokemonService(IHttpClientService httpClientService) 
        { 
        
            _httpClientService = httpClientService;
        }

        public async Task<Poke> GetPokemonAsync(string name)
        {
            Poke pokemon = new Poke();
            var ResponseApi = await _httpClientService.CallMethod(name);
            var JsonResponse = await ResponseApi.Content.ReadAsStringAsync();
            if (ResponseApi.IsSuccessStatusCode) 
            {
                pokemon = JsonConvert.DeserializeObject<Poke>(JsonResponse);
            }
            
            return pokemon;
        }
    }
}
