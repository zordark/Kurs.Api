using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs.Api.Data;

namespace Kurs.Api
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
