using System.Collections.Generic;

namespace Kurs.Api.Monitoring
{
    public interface IMonitoringObjectType
    {
        /// <summary>
        /// Идентификатор этого типа
        /// </summary>
        int Id { get; }

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