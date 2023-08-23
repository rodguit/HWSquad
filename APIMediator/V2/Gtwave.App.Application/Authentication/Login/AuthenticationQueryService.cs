using Sipe.ONR.Application.Authentication.Common;
using Sipe.ONR.Application.Authentication.Common.Interfaces.Authentication;
using Sipe.ONR.Application.Authentication.Common.Interfaces.Repository;
using Sipe.ONR.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipe.ONR.Application.Authentication.Login
{
    public class AuthenticationQueryService : IAuthenticationQueryService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUsuarioRepository _usuariosRepository;
        public AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator, IUsuarioRepository usuarioRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _usuariosRepository = usuarioRepository;
        }

        public AuthenticationResult Login(string nomeUsuario, string senha)
        {
            // Verificar se o usuario existe ///TODO: Alterar para email
            if (_usuariosRepository.Get(nomeUsuario) is not Usuario usuario)
            {
                throw new Exception("Usuário não cadastrado.");
            }

            if (senha != usuario.Senha)
            {
                throw new Exception("Senha Incorreta.");
            }

            // Gerar JWT token
            var token = _jwtTokenGenerator.GenerateToken(usuario);

            return new AuthenticationResult(usuario, token);
        }
    }
}
