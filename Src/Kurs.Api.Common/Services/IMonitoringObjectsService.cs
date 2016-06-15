using System;
using System.Collections.Generic;
using Kurs.Api.Monitoring;

namespace Kurs.Api.Services
{
    /// <summary>
    /// ������ �������� ����������� (������� ������ ������������ �� ���������)
    /// </summary>
    public interface IMonitoringObjectsService : IKursApiService
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
        IMonitoringObject Find( int objectId );

        /// <summary>
        /// ������ ���������
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