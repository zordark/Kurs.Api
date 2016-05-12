using Kurs.Api.Data;

namespace Kurs.Api
{
    public interface IKursLicenceService
    {
        KursLicenseInfo Read();

        void UploadLicence(byte[] licence);
    }
}