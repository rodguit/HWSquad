using MediatR;
using Gtwave.App.Domain.Commands.Requests;
using Gtwave.App.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Commands.Handlers
{
    public class CreateCartorioHandler : IRequestHandler<CreateCartorioRequest, CreateCartorioResponse>
    {
        public Task<CreateCartorioResponse> Handle(CreateCartorioRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCartorioResponse { 
                Id = 12,
                Cnpj = "12780566000162",
                Razao = "1 Cartorio de Teste de SP",
                Cns = "111000",
                Uf = "SP",
                IdCidade = 1,
                UrlNotificacao = "http://registradores.org.br"
            };

            return Task.FromResult(result);
        }
    }
}
