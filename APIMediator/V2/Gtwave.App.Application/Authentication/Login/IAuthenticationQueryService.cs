using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sipe.ONR.Application.Authentication.Common;

namespace Sipe.ONR.Application.Authentication.Login
{
    public interface IAuthenticationQueryService
    {
        AuthenticationResult Login(string nomeUsuario, string password);
    }
}
