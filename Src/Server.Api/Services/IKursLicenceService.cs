using Kurs.Api.Server.Data;

namespace Kurs.Api.Server.Services
{
    public interface IKursLicenceService
    {
        KursLicenseInfo Read();

        void UploadLicence( byte[] licence );
    }
}