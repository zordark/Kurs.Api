using System;

namespace Kurs.Api.Server.Dto
{
    /// <summary>
    /// �������� ��������� �����������
    /// </summary>
    public class SubstitutionArgumentValue
    {
        public int Id { get; set; }

        /// <summary>
        /// ������ �� �������� �����������, � ������� ������� �������� 
        /// </summary>
        public SubstitutionArgument Argument { get; set; }

        /// <summary>
        /// ���������� �������� ���������.
        /// </summary>
        public string Value { get; set; }
    }
}