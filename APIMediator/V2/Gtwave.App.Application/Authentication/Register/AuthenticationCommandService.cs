using Sipe.ONR.Application.Authentication.Common;
using Sipe.ONR.Application.Authentication.Common.Interfaces.Authentication;
using Sipe.ONR.Application.Authentication.Common.Interfaces.Repository;
using Sipe.ONR.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipe.ONR.Application.Authentication.Register
{
    public class AuthenticationCommandService : IAuthenticationCommandService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUsuarioRepository _usuariosRepository;
        public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator, IUsuarioRepository usuarioRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _usuariosRepository = usuarioRepository;
        }

        public AuthenticationResult Register(string nomeUsuario, string cnsCartorio, string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
