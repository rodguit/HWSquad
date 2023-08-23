using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Authentication.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator() {
            RuleFor(x => x.NomeUsuario).NotEmpty();
            RuleFor(x => x.CnsCartorio).NotEmpty();
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Senha).NotEmpty();
        }
    }
}
