using System.Collections.Generic;

namespace Kurs.Api.Server.Settings
{
    /// <summary>
    /// Настройки сети объктов ПАК КУРС
    /// </summary>
    public class EsbFederationSettings
    {
        /// <summary>
        /// Объекты ПАК КУРС
        /// </summary>
        public ICollection<EsbNodeSettings> Nodes { get; set; }
    }
}