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
        /// �������� �����������, � ������� ������� �������� 
        /// <see cref="SubstitutionArgument"/>
        /// </summary>
        public int ArgumentId { get; set; }

        /// <summary>
        /// ���������� ����������� �������� ���������.
        /// </summary>
        public string Value { get; set; }
    }
}