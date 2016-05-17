using System.Collections.Generic;

namespace Kurs.Api.Monitoring
{
    public interface IMonitoringObjectType
    {
        /// <summary>
        /// UID ����� ����
        /// </summary>
        string Uid { get; }

        /// <summary>
        /// ������������ ��� ���� �������, �������� "������" ��� "������"
        /// </summary>
        string Name { get; }

        /// <summary>
        /// �������� ���������� �������� ��� �������� "���������", ����� ���� null, ���� ������ �� ����� ���������
        /// </summary>
        IDictionary<int, string> StateValues { get; }
    }
}