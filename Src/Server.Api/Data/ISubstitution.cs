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
        IEnumerable<ISubstitutionInputArgument> InputArguments { get; }

        /// <summary>
        /// ����� �������� ���������� �����������
        /// </summary>
        IEnumerable<ISubstitutionOutputArgument> OutputArguments { get; }

        /// <summary>
        /// ����� �������� ������� � ��������������� �� ����� �������� �������� ����������
        /// </summary>
        IEnumerable<ISubstitutionArgumentValuesSet> ArgumentValues { get; }
    }
}