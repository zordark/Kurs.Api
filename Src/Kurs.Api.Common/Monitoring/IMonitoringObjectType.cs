using System.Collections.Generic;

namespace Kurs.Api.Monitoring
{
    public interface IMonitoringObjectType
    {
        /// <summary>
        /// ������������� ����� ����
        /// </summary>
        int Id { get; }

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