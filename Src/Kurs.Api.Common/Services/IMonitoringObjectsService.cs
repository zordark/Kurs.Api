using System;
using System.Collections.Generic;
using Kurs.Api.Monitoring;

namespace Kurs.Api.Services
{
    /// <summary>
    /// сервис объектов мониторинга (которые должны отображаться на дашбордах)
    /// </summary>
    public interface IMonitoringObjectsService
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
        IMonitoringObject Find( string uid );

        /// <summary>
        /// Объект появился
        /// </summary>
        event EventHandler<MonitoringObjectEventArgs> Created;

        /// <summary>
        /// Объект удален
        /// </summary>
        event EventHandler<MonitoringObjectEventArgs> Removed;

        /// <summary>
        /// Объект изменился
        /// </summary>
        event EventHandler<MonitoringObjectEventArgs> Changed;
    }

    public class MonitoringObjectEventArgs : EventArgs
    {
        public MonitoringObjectEventArgs( IMonitoringObject monitoringObject )
        {
            Object = monitoringObject;
        }

        public IMonitoringObject Object { get; private set; }
    }
}