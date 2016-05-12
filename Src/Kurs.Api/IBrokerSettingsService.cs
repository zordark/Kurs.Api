using Kurs.Api.Data;

namespace Kurs.Api
{
    public interface IBrokerSettingsService
    {
        BrokerSettings Read();

        void Update(BrokerSettings setting);
    }
}