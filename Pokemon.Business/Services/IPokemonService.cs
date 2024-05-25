using Pokemon.BusinessModel.Models;

namespace Pokemon.Business.Services
{
    public interface IPokemonService
    {
    Task<Poke> GetPokemonAsync(string name);

    }
}
