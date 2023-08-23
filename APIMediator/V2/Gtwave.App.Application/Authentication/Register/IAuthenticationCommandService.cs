using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sipe.ONR.Application.Authentication.Common;

namespace Sipe.ONR.Application.Authentication.Register
{
    public interface IAuthenticationCommandService
    {
        AuthenticationResult Register(string nomeUsuario, string cnsCartorio, string email, string password);
    }
}
