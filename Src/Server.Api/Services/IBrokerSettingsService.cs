using Kurs.Api.Server.Settings;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    /// <summary>
    /// Настройки сервера
    /// </summary>
    public interface IBrokerSettingsService : IKursApiService
    {
        BrokerSettings Read();

        BrokerSettings Update( BrokerSettings setting );
    }
}