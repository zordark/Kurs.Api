using System.Collections.Generic;

namespace Kurs.Api.Monitoring
{
    /// <summary>
    /// ��������� ������� ����������� (��� ����������� �� ���������)
    /// </summary>
    public interface IMonitoringObject
    {
        /// <summary>
        /// ������������� �������
        /// </summary>
        int Id { get; }

        /// <summary>
        /// ��� �������
        /// </summary>
        IMonitoringObjectType Type { get; }

        /// <summary>
        /// ��� �������
        /// </summary>
        string Name { get; }

        /// <summary>
        /// �������� �������, ����� ���� null
        /// </summary>
        string Value { get; }

        /// <summary>
        /// ��������� �������.
        /// �������� �������� ��������� �������. ��������, ��� ������� ���:
        /// ���� �� ������, ���� � ������, �����, ������������� � �.�.
        /// ���������� �������� � �������� ��������� ����� �������� �� Type.TypeOfState
        /// </summary>
        int State { get; }

        /// <summary>
        /// ������ �������.
        /// �������� ���������� ��������� �������. ��������, ������, ��������������, ����������, ...
        /// ���������� �������� � �������� �������� ����� �������� �� Type.TypeOfStatus
        /// </summary>
        AlarmStatus Status { get; }

        /// <summary>
        /// ������������ ������, ����� ���� null
        /// </summary>
        IMonitoringObject Parent { get; }

        /// <summary>
        /// �������������� �������� ��������, ����� ���� null ��� ������ ������, ���� �� ���
        /// </summary>
        IEnumerable<IMonitoringObject> Childs { get; }
    }
}