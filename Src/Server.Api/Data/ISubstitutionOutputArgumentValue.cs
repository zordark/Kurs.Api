using System;

namespace Kurs.Api.Server.Data
{
    /// <summary>
    /// �������� ��������� ��������� �����������
    /// </summary>
    public interface ISubstitutionOutputArgumentValue
    {
        int Id { get; }

        /// <summary>
        /// �������� �����������, � ������� ������� �������� 
        /// </summary>
        ISubstitutionOutputArgument Argument { get; }

        /// <summary>
        /// �������� ��������� ��������� �����������.
        /// </summary>
        string Value { get; set; }
    }
}