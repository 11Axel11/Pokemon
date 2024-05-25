using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.BusinessModels
{
    public class ConfigurationApi
    {
        public ApiModel ApiInformation { get; set; } = new ApiModel();
    }

    public class ApiModel
    {
        public string BaseUri { get; set; } = string.Empty;
        public string GeneralUri { get; set; } = string.Empty;
    }
}
