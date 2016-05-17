using Kurs.Api.Server.Settings;

namespace Kurs.Api.Server.Services
{
    /// <summary>
    /// Настрйоки сервера
    /// </summary>
    public interface IBrokerSettingsService
    {
        BrokerSettings Read();

        BrokerSettings Update( BrokerSettings setting );
    }
}