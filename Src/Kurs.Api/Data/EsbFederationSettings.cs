using System.Collections.Generic;

namespace Kurs.Api.Data
{
    public class EsbFederationSettings
    {
        public ICollection<EsbNodeSettings> Nodes { get; set; }
    }
}