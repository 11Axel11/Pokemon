using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pokemon.Business.Services;
using Pokemon.BusinessModels;
using System.Net.Http.Headers;

namespace Pokemon.Business
{
    public static class ServiceCollectionExtension
    {

        public static IServiceCollection AddClientHttp(this IServiceCollection services, IConfiguration configuration)
        {
            var ApiInformation = configuration.GetSection(Configuration.Services).Get<ConfigurationApi>().ApiInformation;

            services.AddHttpClient("POKEMON-API", c =>
            {

                //Se especifica que se aceptará por defecto el encabezado ContentType en formato Json
                c.DefaultRequestHeaders.Accept.Clear();
                c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                c.BaseAddress = new Uri(ApiInformation.BaseUri);
            });
            return services;
        }


        public static IServiceCollection AddServices(this IServiceCollection services) 
        {

            services.AddTransient<IHttpClientService, HttpClientService>();
            services.AddTransient<IPokemonService, PokemonService>();
            services.AddTransient<IConfigurationService, ConfigurationService>();
            return services;
        }

     
    }
}
