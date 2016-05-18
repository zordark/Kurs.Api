using Kurs.Api.Server.Settings;

namespace Kurs.Api.Server.Services
{
    /// <summary>
    /// ��������� ���� ������� ��� ����
    /// </summary>
    public interface IFederationSettingsService
    {
        /// <summary>
        /// ����� ������ �������� ����� ��� Federation
        /// </summary>
        /// <returns></returns>
        EsbFederationSettings Read();

        /// <summary>
        /// ����� �������� ���� � Federation
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        EsbNodeSettings Create( EsbNodeSettings node );

        /// <summary>
        /// ���������� �������� ���� � Federation
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        EsbNodeSettings Update( EsbNodeSettings node );

        /// <summary>
        /// ����� �������� ���� �� �������� Federation
        /// </summary>
        /// <param name="kursId"></param>
        void Delete( string kursId );
    }
}