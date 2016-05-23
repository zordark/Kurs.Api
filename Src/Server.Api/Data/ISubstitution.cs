using System.Collections.Generic;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// �����������. ������������ ��� ������������ ���������� ������� �������� ��� �������� ��������
    /// </summary>
    public interface ISubstitution
    {
        /// <summary>
        /// ������������� ����������� 
        /// </summary>
        int Id { get; }

        /// <summary>
        /// ��� �����������
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// ������� ����, ��� ����������� ������ ������������� ������ ������� ��������� � ��������, ��� ����
        /// ���������� ������ ������ ����� ������� � �������� ����������, � ������� ��������� ��������� ����������� �������.
        /// � ����� ������������ �������� ���������� �� ����� ���� �������.
        /// </summary>
        bool AutoMapping { get; }

        /// <summary>
        /// ����� ������� ���������� ����������� 
        /// </summary>
        IEnumerable<ISubstitutionArgument> InputArguments { get; }

        /// <summary>
        /// ����� �������� ���������� �����������
        /// </summary>
        IEnumerable<ISubstitutionArgument> OutputArguments { get; }

        /// <summary>
        /// ����� �������� ������� � ��������������� �� ����� �������� �������� ����������
        /// </summary>
        IEnumerable<ISubstitutionArgumentValuesSet> ArgumentValues { get; }
    }
}