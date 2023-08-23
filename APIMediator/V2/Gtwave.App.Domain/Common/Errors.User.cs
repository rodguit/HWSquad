using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Common
{
    public static class Errors
    {
        public static class User
        {
            public static Error DuplicateEmail => Error.Conflict(
                code: "User.DuplicateEmail",
                description: "Email já cadastrado"
                );

            public static Error UsuarioNaoExiste => Error.NotFound(
                code: "User.UsuarioNaoExiste",
                description: "Usuario Não cadastrado"
                );

            public static Error SenhaIncorreta => Error.Failure(
                code: "User.SenhaIncorreta",
                description: "Senha Incorreta"
                );
        }
    }
}
