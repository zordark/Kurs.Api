using System;
using System.Collections.Generic;
using Kurs.Api.Monitoring;

namespace Kurs.Api.Services
{
    /// <summary>
    /// Сервис объектов мониторинга (которые должны отображаться на дашбордах)
    /// </summary>
    public interface IMonitoringObjectsService : IKursApiService
    {
        /// <summary>
        /// Список типов объектов мониторинга
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMonitoringObjectType> GetTypes();

        /// <summary>
        /// Получить список корневых объектов мониторинга (объекты собраны в дерево, если нет дочерних объектов, то получится просто список)
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMonitoringObject> GetRootObjects();

        /// <summary>
        /// Получить линейный список всех объектов мониторинга адаптера
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMonitoringObject> GetAllObjects();

        /// <summary>
        /// Найти объект по его uid
        /// </summary>
        IMonitoringObject Find( int objectId );

        /// <summary>
        /// Объект изменился
        /// </summary>
        IObservable<MonitoringObjectChanged> Changed { get; }
    }

    public class MonitoringObjectChanged
    {
        public MonitoringObjectChanged( IMonitoringObject monitoringObject, ChangeTypes changeType )
        {
            Object = monitoringObject;
            ChangeType = changeType;
        }

        public IMonitoringObject Object { get; }
        public ChangeTypes ChangeType { get;  }

        public enum ChangeTypes
        {
            Created,
            Changed,
            Deleted,
        }
    }
}