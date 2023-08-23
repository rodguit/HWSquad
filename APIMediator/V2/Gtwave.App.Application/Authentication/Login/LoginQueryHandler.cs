using MediatR;
using Gtwave.App.Application.Authentication.Common.Interfaces.Authentication;
using Gtwave.App.Application.Authentication.Common.Interfaces.Repository;
using Gtwave.App.Application.Authentication.Common;
using Gtwave.App.Application.Authentication.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gtwave.App.Domain.Models.Entities;
using ErrorOr;
using Gtwave.App.Domain.Common;

namespace Gtwave.App.Application.Authentication.Login
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticatiAppesult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUsuarioRepository _usuariosRepository;
        public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUsuarioRepository usuarioRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _usuariosRepository = usuarioRepository;
        }
        public async Task<ErrorOr<AuthenticatiAppesult>> Handle(LoginQuery query, CancellationToken cancellationToken)
        {
            // Verificar se o usuario existe ///TODO: Alterar para email
            if (_usuariosRepository.Get(query.NomeUsuario) is not Usuario usuario)
            {
                return Errors.User.UsuarioNaoExiste;
            }

            if (query.Senha != usuario.Senha)
            {
                return Errors.User.SenhaIncorreta;
            }

            // Gerar JWT token
            var token = _jwtTokenGenerator.GenerateToken(usuario);

            return new AuthenticatiAppesult(usuario, token);
        }
    }
}
