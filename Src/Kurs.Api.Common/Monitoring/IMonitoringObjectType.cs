using System.Collections.Generic;

namespace Kurs.Api.Monitoring
{
    public interface IMonitoringObjectType
    {
        /// <summary>
        /// UID этого типа
        /// </summary>
        string Uid { get; }

        /// <summary>
        /// Человеческое имя типа объекта, например "Камера" или "Датчик"
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Перечень допустимых значений для атрибута "Состояние", может быть null, если объект не имеет состояния
        /// </summary>
        IDictionary<int, string> StateValues { get; }
    }
}