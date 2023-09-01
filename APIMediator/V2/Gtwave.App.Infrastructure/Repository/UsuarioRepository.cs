using Gtwave.App.Application.Authentication.Common.Interfaces.Repository;
using Gtwave.App.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Infrastructure.Repository
{
    public class UsuarioRepository : SQLRepository<Usuario>, IUsuarioRepository
    {
        private static readonly List<Usuario> _usuarios = new();
        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public Usuario? Get(string email)
        {
            return _usuarios.SingleOrDefault(p=> p.Email == email);
        } 
    }
}
