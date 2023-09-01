using ErrorOr;
using MediatR;
using Gtwave.App.Application.Authentication.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Authentication.Login
{
    public record LoginQuery(
        string NomeUsuario,
        string Senha): IRequest<ErrorOr<AuthenticatiAppesult>>;
}
