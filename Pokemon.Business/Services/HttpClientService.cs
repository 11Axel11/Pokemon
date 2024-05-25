using Pokemon.BusinessModels;
using System.Net;

namespace Pokemon.Business.Services
{
    public class HttpClientService : IHttpClientService
    {

        private readonly IHttpClientFactory _httpClient;
        private readonly IConfigurationService _configurationService;
        private readonly ApiModel _apiModel = new ApiModel();
        public HttpClientService(IHttpClientFactory httpClient, IConfigurationService configurationService)
        {

            _httpClient = httpClient;
            _configurationService = configurationService;
            _apiModel = _configurationService.Get<ConfigurationApi>(Configuration.Services).ApiInformation;
        }



        public async Task<HttpResponseMessage> CallMethod(string complementaryUri, StringContent? stringContent = null)
        {
            HttpResponseMessage response = new();
            string FinallyComplementaryUri = _apiModel.GeneralUri + complementaryUri; 
            try
            {
                var httpClient = _httpClient.CreateClient("POKEMON-API");
                response = await httpClient.GetAsync(FinallyComplementaryUri);
                return response;
            }
            catch (Exception ex)
            {

                response = new(HttpStatusCode.BadRequest);

                return response;
            }
            

        }
    }
}
