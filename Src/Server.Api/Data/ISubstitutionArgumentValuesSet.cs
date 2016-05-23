using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// ����� ��������� ����� ������� � ��������������� �� �������� �������� ����������
    /// </summary>
    public interface ISubstitutionArgumentValuesSet
    {
        /// <summary>
        /// ������������� ������ �������� ���������� ����������� 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// ������� ����������/����� ������ (��� UI)
        /// </summary>
        int Order { get; }

        /// <summary>
        /// �������� ������� ����������
        /// </summary>
        IEnumerable<ISubstitutionArgumentValue> InputValues { get; }

        /// <summary>
        /// �������� �������� ����������
        /// </summary>
        IEnumerable<ISubstitutionArgumentValue> OutputValues { get; }
    }
}