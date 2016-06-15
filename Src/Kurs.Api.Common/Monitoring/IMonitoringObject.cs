using System.Collections.Generic;

namespace Kurs.Api.Monitoring
{
    /// <summary>
    /// Интерфейс объекта мониторинга (для отображения на дашбордах)
    /// </summary>
    public interface IMonitoringObject
    {
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Тип объекта
        /// </summary>
        IMonitoringObjectType Type { get; }

        /// <summary>
        /// Имя объекта
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Значение объекта, может быть null
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Состояние объекта.
        /// Отражает реальное состояние объекта. Например, для датчика ОПС:
        /// Взят на охрану, снят с охраны, пожар, неисправность и т.д.
        /// Допустимые значения и описания состояний можно получить из Type.TypeOfState
        /// </summary>
        int State { get; }

        /// <summary>
        /// Статус объекта.
        /// Отражает аларменное состояние объекта. Например, авария, предупреждение, квитирован, ...
        /// Допустимые значения и описания статусов можно получить из Type.TypeOfStatus
        /// </summary>
        AlarmStatus Status { get; }

        /// <summary>
        /// Родительский объект, может быть null
        /// </summary>
        IMonitoringObject Parent { get; }

        /// <summary>
        /// Идентификаторы дочерних объектов, может быть null или пустой массив, если их нет
        /// </summary>
        IEnumerable<IMonitoringObject> Childs { get; }
    }
}