using MediatR;
using Gtwave.App.Domain.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Commands.Requests
{
    public class CreateCartorioRequest :IRequest<CreateCartorioResponse>
    {
        public int IdCidade { get; set; }
        public string Razao { get; set; }
        public string Cnpj { get; set; }
        public string Cns { get; set; }
        public string Uf { get; set; }
        public string UrlNotificacao { get; set; }
    }
}
