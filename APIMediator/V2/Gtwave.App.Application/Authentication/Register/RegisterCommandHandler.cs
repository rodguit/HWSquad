using ErrorOr;
using MediatR;
using Gtwave.App.Application.Authentication.Common;
using Gtwave.App.Application.Authentication.Common.Interfaces.Authentication;
using Gtwave.App.Application.Authentication.Common.Interfaces.Repository;
using Gtwave.App.Domain.Common;
using Gtwave.App.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Authentication.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticatiAppesult>>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUsuarioRepository _usuariosRepository;
        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUsuarioRepository usuarioRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _usuariosRepository = usuarioRepository;
        }
        public async Task<ErrorOr<AuthenticatiAppesult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
        {
            // Verificar se o usuario existe
            if (_usuariosRepository.Get(command.Email) is not null)
            {
                return Errors.User.DuplicateEmail;
            }
            // Criar novo usuario (gerar id usuario)
            var usuario = new Usuario
            {
                Nome = command.NomeUsuario,
                CnsCartorio = command.CnsCartorio, 
                Email = command.Email,
                Senha = command.Senha
            };
            _usuariosRepository.Add(usuario);

            // Gerar JWT token
            var token = _jwtTokenGenerator.GenerateToken(usuario);

            return new AuthenticatiAppesult(usuario, token);
        }
    }
}
