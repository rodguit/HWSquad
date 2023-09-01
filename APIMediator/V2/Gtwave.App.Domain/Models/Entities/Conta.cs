using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Models.Entities
{
    public class Conta
    {
        public int Id { get; set; }
        public string Cns { get; set; }
        public string ApplicationKey { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string NomeBeneficiario { get; set; }
        public long NumeroInscricao { get; set; }
        public int TipoInscricao { get; set; }
        public int CodigoModalidade { get; set; }
        public int NumeroConvenio { get; set; }
        public int NumeroCarteira { get; set; }
        public int NumeroVariacaoCarteira { get; set; }
        public string IndicadoPix { get; set; }
        public string Chave { get; set; }
        public string AgenciaBeneficiario { get; set; }
        public string DigitoAgenciaBenefificario { get; set; }
        public string ContaBeneficiario { get; set; }
        public string DigitoContaBenefificario { get; set; }
    }
}
