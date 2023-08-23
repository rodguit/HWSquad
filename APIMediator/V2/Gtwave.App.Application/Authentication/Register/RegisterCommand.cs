using ErrorOr;
using MediatR;
using Gtwave.App.Application.Authentication.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Authentication.Register
{
    public record RegisterCommand(
        int Id,
        string NomeUsuario,
        string CnsCartorio,
        string Email,
        string Senha):IRequest<ErrorOr<AuthenticatiAppesult>>;
}
