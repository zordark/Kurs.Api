using Kurs.Api.Server.Settings;

namespace Kurs.Api.Server.Services
{
    /// <summary>
    /// Настройки сети объктов ПАК КУРС
    /// </summary>
    public interface IFederationSettingsService
    {
        /// <summary>
        /// Метод чтения настроек узлов для Federation
        /// </summary>
        /// <returns></returns>
        EsbFederationSettings Read();

        /// <summary>
        /// Метод создания узла в Federation
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        EsbNodeSettings Create( EsbNodeSettings node );

        /// <summary>
        /// Обновление настроек узла в Federation
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        EsbNodeSettings Update( EsbNodeSettings node );

        /// <summary>
        /// Метод удаления узла из настроек Federation
        /// </summary>
        /// <param name="kursId"></param>
        void Delete( string kursId );
    }
}