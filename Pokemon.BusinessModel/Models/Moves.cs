using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.BusinessModels.Models
{
    public class Moves
    {

        [JsonProperty("move")]
        public Move Move { get; set; }


    }
}
