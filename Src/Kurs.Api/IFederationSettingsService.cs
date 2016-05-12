using Kurs.Api.Data;

namespace Kurs.Api
{
    public interface IFederationSettingsService
    {
        /// <summary>
        /// Метод создания узла в Federation
        /// </summary>
        /// <param name="nodeSettings"></param>
        EsbNodeSettings Create(EsbNodeSettings nodeSettings);

        /// <summary>
        /// Метод чтения настроек узлов для Federation
        /// </summary>
        /// <returns></returns>
        EsbFederationSettings Read();

        /// <summary>
        /// Обновление настроек узла в Federation
        /// </summary>
        /// <param name="nodeSettings"></param>
        void Update(EsbNodeSettings nodeSettings);

        /// <summary>
        /// Метод удаления узла из настроек Federation
        /// </summary>
        /// <param name="kursId"></param>
        void Delete(string kursId);
    }
}