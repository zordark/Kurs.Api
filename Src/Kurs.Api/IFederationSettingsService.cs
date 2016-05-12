using Kurs.Api.Data;

namespace Kurs.Api
{
    public interface IFederationSettingsService
    {
        /// <summary>
        /// ����� �������� ���� � Federation
        /// </summary>
        /// <param name="nodeSettings"></param>
        EsbNodeSettings Create(EsbNodeSettings nodeSettings);

        /// <summary>
        /// ����� ������ �������� ����� ��� Federation
        /// </summary>
        /// <returns></returns>
        EsbFederationSettings Read();

        /// <summary>
        /// ���������� �������� ���� � Federation
        /// </summary>
        /// <param name="nodeSettings"></param>
        void Update(EsbNodeSettings nodeSettings);

        /// <summary>
        /// ����� �������� ���� �� �������� Federation
        /// </summary>
        /// <param name="kursId"></param>
        void Delete(string kursId);
    }
}