using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pokemon.BusinessModels.Models
{
    public class Type
    {
        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("url")]
        public string Url { get; set; }


    }
}
