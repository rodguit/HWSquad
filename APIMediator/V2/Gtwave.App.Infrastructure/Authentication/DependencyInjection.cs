using Microsoft.Extensions.DependencyInjection;
using Gtwave.App.Application.Authentication.Common.Interfaces.Authentication;
using Gtwave.App.Application.Authentication.Common.Interfaces.Repository;
using Gtwave.App.Infrastructure.Repository;

namespace Gtwave.App.Infrastructure.Authentication
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {
            services.Configure<InfraestructureSettings>(configuration.GetSection(InfraestructureSettings.SectionName ));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
