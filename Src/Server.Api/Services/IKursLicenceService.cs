using Kurs.Api.Server.Data;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    public interface IKursLicenceService : IKursApiService
    {
        KursLicenseInfo Read();

        void UploadLicence( byte[] licence );
    }
}