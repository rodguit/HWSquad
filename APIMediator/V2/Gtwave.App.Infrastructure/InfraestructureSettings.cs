using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Infrastructure
{
    public class  InfraestructureSettings
    {
        public const string SectionName = "InfraestructureSettings";

        #region JWT Settings
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int TokenTimeoutMin { get; set; }
        #endregion

    }
}
