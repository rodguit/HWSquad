using Gtwave.App.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Authentication.Common
{
    public record AuthenticatiAppesult(
    Usuario Usuario,
    string Password);
}
