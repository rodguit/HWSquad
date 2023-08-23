using Mapster;
using Gtwave.App.Api.Contracts;
using Gtwave.App.Application.Authentication.Common;
using Gtwave.App.Application.Authentication.Register;

namespace Gtwave.App.Api.Common.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<AuthenticatiAppesult, AuthenticatiAppesponse>()
                .Map(dest=> dest.Token, src => src.Password)
                .Map(dest => dest, src => src.Usuario);

            config.NewConfig<RegisterRequest, RegisterCommand>()
                .Map(dest => dest.Senha, src => src.Password)
                .Map(dest => dest.CnsCartorio, src => src.CNSCartorio);
        }
    }
}
