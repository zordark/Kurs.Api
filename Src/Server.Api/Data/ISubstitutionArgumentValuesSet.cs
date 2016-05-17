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

        IEnumerable<ISubstitutionInputArgumentValue> InputValues { get; }

        IEnumerable<ISubstitutionOutputArgumentValue> OutputValues { get; }
    }
}