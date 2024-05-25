using Microsoft.AspNetCore.Mvc;
using Pokemon.Business.Services;

namespace ApiPokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
      
        private readonly IPokemonService _pokemonService;
        public PokemonController(IPokemonService PokemonService)
        {
            
            _pokemonService = PokemonService;
        }


        [HttpGet(Name = "GetPokemon")]
        public async Task<IActionResult> GetPokemon(string name)
        {
            var response = await _pokemonService.GetPokemonAsync(name);
            return response.Name == null ? BadRequest(response) : Ok(response);
            

        }
    }
}

