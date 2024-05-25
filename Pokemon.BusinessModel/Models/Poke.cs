using Newtonsoft.Json;
using Pokemon.BusinessModels.Models;

namespace Pokemon.BusinessModel.Models
{
    public class Poke
    {

        [JsonProperty("id")]
        public int Id { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("types")]
        public List<Types> Types { get; set; } = new List<Types>();



        [JsonProperty("moves")]
        public List<Moves> Moves { get; set; } = new List<Moves>();



        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }



        // [JsonProperty("elaborado_por")] 
        public string ElaboradoPor { get; set; } = "Axel";


    }
}
