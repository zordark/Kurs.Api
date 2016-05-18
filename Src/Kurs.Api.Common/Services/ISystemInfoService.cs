using System.Collections.Generic;

namespace Kurs.Api.Services
{
    public interface ISystemInfoService
    {
        /// <summary>
        /// Получение списка зарегестрированных адаптеров
        /// </summary>
        /// <returns></returns>
        IEnumerable<AdapterDescriptor> GetRegisteredAdapters();

        /// <summary>
        /// Метод получения информации о системе
        /// </summary>
        /// <returns></returns>
        SystemDescriptor GetSystemDescriptor();

    }
}