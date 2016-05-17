using System;
using System.Collections.Generic;
using Kurs.Api.Monitoring;

namespace Kurs.Api.Services
{
    /// <summary>
    /// ������ �������� ����������� (������� ������ ������������ �� ���������)
    /// </summary>
    public interface IMonitoringObjectsService
    {
        /// <summary>
        /// ������ ����� �������� �����������
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMonitoringObjectType> GetTypes();

        /// <summary>
        /// �������� ������ �������� �������� ����������� (������� ������� � ������, ���� ��� �������� ��������, �� ��������� ������ ������)
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMonitoringObject> GetRootObjects();

        /// <summary>
        /// �������� �������� ������ ���� �������� ����������� ��������
        /// </summary>
        /// <returns></returns>
        IEnumerable<IMonitoringObject> GetAllObjects();

        /// <summary>
        /// ����� ������ �� ��� uid
        /// </summary>
        IMonitoringObject Find( string uid );

        /// <summary>
        /// ������ ��������
        /// </summary>
        event EventHandler<MonitoringObjectEventArgs> Created;

        /// <summary>
        /// ������ ������
        /// </summary>
        event EventHandler<MonitoringObjectEventArgs> Removed;

        /// <summary>
        /// ������ ���������
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