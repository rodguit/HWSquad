using Gtwave.App.Application.Common.Interface;
using Gtwave.App.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Application.Authentication.Common.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario? Get(string email);
        void Add(Usuario usuario);
    }
}
